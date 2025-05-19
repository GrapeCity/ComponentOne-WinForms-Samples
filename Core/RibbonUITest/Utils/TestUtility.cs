using Microsoft.VisualStudio.TestPlatform.Utilities;
using OpenQA.Selenium.Appium.Windows;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Xunit.Abstractions;

namespace RibbonUITest.Utils
{
    /// <summary>
    /// Provides utility methods for capturing, comparing, and managing test screenshots.
    /// </summary>
    internal static class TestUtility
    {
        private const string BaseImageFolder = "BaseImage";
        private const double DefaultColorTolerance = 0.1; // 10% tolerance

        /// <summary>
        /// Gets the root directory of the test project.
        /// </summary>
        private static string GetProjectRoot() =>
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

        /// <summary>
        /// Gets or creates the screenshots directory.
        /// </summary>
        private static string GetScreenshotsDirectory()
        {
            string dir = Path.Combine(GetProjectRoot(), "Screenshots");
            Directory.CreateDirectory(dir);
            return dir;
        }

        /// <summary>
        /// Gets the full path to a base image file.
        /// </summary>
        private static string GetBaseImagePath(string fileName) =>
            Path.Combine(GetScreenshotsDirectory(), BaseImageFolder, fileName);

        /// <summary>
        /// Captures a screenshot from the specified WindowsDriver and crops it by percentage.
        /// </summary>
        public static void CaptureScreenshotFromPercentage(WindowsDriver driver, string fileName, ITestOutputHelper output,
            double startPercent = 0.33, double endPercent = 0.40)
        {
            try
            {
                Bitmap fullScreenshot = CaptureFullScreenshot(driver);
                Bitmap croppedImage = CropImageByPercentage(fullScreenshot, startPercent, endPercent);

                string fullPath = Path.Combine(GetScreenshotsDirectory(), fileName);
                SaveImage(croppedImage, fullPath);

                output.WriteLine($"Screenshot captured and saved at: {fullPath}");
            }
            catch (Exception ex)
            {
                output.WriteLine($"Screenshot capture failed: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Captures a full screenshot from the WindowsDriver.
        /// </summary>
        private static Bitmap CaptureFullScreenshot(WindowsDriver driver)
        {
            using var stream = new MemoryStream(driver.GetScreenshot().AsByteArray);
            return new Bitmap(stream);
        }

        /// <summary>
        /// Crops an image vertically by percentage.
        /// </summary>
        private static Bitmap CropImageByPercentage(Bitmap original, double startPercent, double endPercent)
        {
            int startY = (int)(original.Height * startPercent);
            int height = (int)(original.Height * (endPercent - startPercent));

            return original.Clone(new Rectangle(0, startY, original.Width, height), original.PixelFormat);
        }

        /// <summary>
        /// Saves an image to the specified path in PNG format.
        /// </summary>
        private static void SaveImage(Bitmap image, string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            image.Save(path, ImageFormat.Png);
        }

        /// <summary>
        /// Compares two images and optionally generates a difference image.
        /// </summary>
        public static bool CompareImages(string expectedFileName, string actualFileName, string diffFileName, ITestOutputHelper output,
            int? targetWidth = null, int? targetHeight = null, double tolerance = DefaultColorTolerance)
        {
            try
            {
                var expectedPath = GetBaseImagePath(expectedFileName);
                var actualPath = Path.Combine(GetScreenshotsDirectory(), actualFileName);
                var diffPath = Path.Combine(GetScreenshotsDirectory(), diffFileName);

                ValidateFileExists(expectedPath);
                ValidateFileExists(actualPath);

                bool areEqual;

                using (var expected = new Bitmap(expectedPath))
                using (var actual = new Bitmap(actualPath))
                {
                    if (targetWidth.HasValue && targetHeight.HasValue)
                    {
                        using var resizedExpected = ResizeImage(expected, targetWidth.Value, targetHeight.Value);
                        using var resizedActual = ResizeImage(actual, targetWidth.Value, targetHeight.Value);
                        areEqual = CompareImagesAndGenerateDiff(resizedExpected, resizedActual, diffPath, tolerance, output);
                    }
                    else
                    {
                        areEqual = CompareImagesAndGenerateDiff(expected, actual, diffPath, tolerance, output);
                    }
                }

                if (areEqual)
                {
                    SafeDeleteFile(actualPath, output);
                    SafeDeleteFile(diffPath, output);
                }

                return areEqual;
            }
            catch (FileNotFoundException ex)
            {
                output.WriteLine($"File comparison failed: {ex.Message}");
                throw new FileNotFoundException("One of the files to compare was not found.", ex);
            }
            catch (IOException ex)
            {
                output.WriteLine($"I/O error during image comparison: {ex.Message}");
                throw new IOException("Error during image comparison process.", ex);
            }
            catch (Exception ex)
            {
                output.WriteLine($"Unexpected error during image comparison: {ex.Message}");
                throw new InvalidOperationException("Unexpected error occurred during image comparison.", ex);
            }

        }

        /// <summary>
        /// Resizes an image to the specified dimensions using high-quality interpolation.
        /// </summary>
        private static Bitmap ResizeImage(Bitmap original, int targetWidth, int targetHeight)
        {
            var resizedImage = new Bitmap(targetWidth, targetHeight);

            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(original, 0, 0, targetWidth, targetHeight);
            }

            return resizedImage;
        }

        /// <summary>
        /// Compares two images and generates a diff image if they don't match.
        /// </summary>
        private static bool CompareImagesAndGenerateDiff(Bitmap expectedImg, Bitmap actualImg, string diffPath, double tolerance, ITestOutputHelper output)
        {
            if (!VerifyImageDimensionsMatch(expectedImg, actualImg, output))
            {
                return false;
            }

            bool isIdentical = true;
            using (Bitmap diffImg = new Bitmap(expectedImg.Width, expectedImg.Height))
            {
                var (expectedData, actualData, diffData) = LockImageBitsForComparison(expectedImg, actualImg, diffImg);

                try
                {
                    isIdentical = ProcessAllPixels(expectedImg, expectedData, actualData, diffData, tolerance);
                }
                finally
                {
                    UnlockImageBits(expectedImg, expectedData);
                    UnlockImageBits(actualImg, actualData);
                    UnlockImageBits(diffImg, diffData);
                }

                if (!isIdentical)
                {
                    SaveImage(diffImg, diffPath);
                    output.WriteLine($"Diff image saved at: {diffPath}");
                }

                return isIdentical;
            }
        }

        /// <summary>
        /// Verifies that two images have the same dimensions.
        /// </summary>
        private static bool VerifyImageDimensionsMatch(Bitmap expected, Bitmap actual, ITestOutputHelper output)
        {
            if (expected.Size == actual.Size) return true;

            output.WriteLine($"Image dimensions mismatch: Expected({expected.Width}x{expected.Height}), Actual({actual.Width}x{actual.Height})");
            return false;
        }

        /// <summary>
        /// Locks the image bits for fast pixel comparison.
        /// </summary>
        private static (BitmapData expected, BitmapData actual, BitmapData diff) LockImageBitsForComparison(
            Bitmap expectedImg, Bitmap actualImg, Bitmap diffImg)
        {
            return (
                expected: expectedImg.LockBits(
                    new Rectangle(0, 0, expectedImg.Width, expectedImg.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb),
                actual: actualImg.LockBits(
                    new Rectangle(0, 0, actualImg.Width, actualImg.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb),
                diff: diffImg.LockBits(
                    new Rectangle(0, 0, diffImg.Width, diffImg.Height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format32bppArgb)
            );
        }

        /// <summary>
        /// Processes all pixels in the images for comparison.
        /// </summary>
        private static bool ProcessAllPixels(
            Bitmap expectedImg,
            BitmapData expectedData,
            BitmapData actualData,
            BitmapData diffData,
            double tolerance)
        {
            bool isIdentical = true;
            int pixelCount = expectedImg.Width * expectedImg.Height;

            for (int i = 0; i < pixelCount; i++)
            {
                Color expectedPixel = Color.FromArgb(Marshal.ReadInt32(expectedData.Scan0, i * 4));
                Color actualPixel = Color.FromArgb(Marshal.ReadInt32(actualData.Scan0, i * 4));

                if (!AreColorsSimilar(expectedPixel, actualPixel, tolerance))
                {
                    isIdentical = false;
                    Marshal.WriteInt32(diffData.Scan0, i * 4, Color.Red.ToArgb());
                }
                else
                {
                    Marshal.WriteInt32(diffData.Scan0, i * 4, expectedPixel.ToArgb());
                }
            }

            return isIdentical;
        }

        /// <summary>
        /// Unlocks the image bits after comparison.
        /// </summary>
        private static void UnlockImageBits(Bitmap image, BitmapData data)
        {
            image.UnlockBits(data);
        }

        /// <summary>
        /// Compares two colors with optional tolerance.
        /// </summary>
        private static bool AreColorsSimilar(Color expected, Color actual, double tolerance)
        {
            if (tolerance <= 0.0) return expected == actual;

            int diffR = Math.Abs(expected.R - actual.R);
            int diffG = Math.Abs(expected.G - actual.G);
            int diffB = Math.Abs(expected.B - actual.B);

            double difference = Math.Sqrt(diffR * diffR + diffG * diffG + diffB * diffB) / Math.Sqrt(255 * 255 * 3);
            return difference <= tolerance;
        }

        /// <summary>
        /// Deletes a file if it exists, handling any IO exceptions.
        /// </summary>
        private static void SafeDeleteFile(string filePath, ITestOutputHelper output)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    output.WriteLine($"Deleted file: {filePath}");
                }
            }
            catch (IOException ex)
            {
                output.WriteLine($"I/O error during file deletion: {ex.Message}");
                throw new IOException($"Failed to delete file {filePath}.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                output.WriteLine($"Permission error during file deletion: {ex.Message}");
                throw new UnauthorizedAccessException($"No permission to delete file {filePath}.", ex);
            }
        }

        /// <summary>
        /// Validates that a file exists at the specified path.
        /// </summary>
        private static void ValidateFileExists(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");
        }

        public static void Wait(int seconds)
        {
#if DEBUG           
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
#else
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
#endif
        }
    }
}