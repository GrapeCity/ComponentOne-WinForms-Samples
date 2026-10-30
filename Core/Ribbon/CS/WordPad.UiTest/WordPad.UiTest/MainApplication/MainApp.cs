// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.Tools;
using FlaUI.Core.WindowsAPI;
using FlaUI.UIA3;
using System.Diagnostics;

namespace WordPad.UiTest.MainApplication
{
    public sealed class MainApp : IDisposable
    {
        private const string ExecutableName = "WordPad.exe";

        private static readonly string ExecutablePath =
            Path.Combine(AppContext.BaseDirectory, ExecutableName);

        private Application? _app;
        private AutomationBase? _automation;
        private Window? _window;

        public Window Window =>
            _window ?? throw new InvalidOperationException(
                "Application is not initialized.");

        public void Initialize()
        {
            EnsureApplicationExists();

            StartApplication();
        }

        public void Dispose()
        {
            StopApplication();
        }

        private static void EnsureApplicationExists()
        {
            if (!File.Exists(ExecutablePath))
            {
                throw new FileNotFoundException(
                    $"Application executable not found: {ExecutablePath}.{Environment.NewLine}" +
                    "Build the solution before running the UI tests.");
            }
        }

        private void StartApplication()
        {
            _app = Application.Launch(CreateProcessStartInfo);

            _automation = new UIA3Automation();

            _window = CreateWindow(_app, _automation);
        }

        private static Window CreateWindow(
            Application app,
            AutomationBase automation)
        {
            return Retry
                .WhileNull(
                    () => app.GetMainWindow(automation),
                    TimeSpan.FromSeconds(10))
                .Result
                ?? throw new InvalidOperationException(
                    "Unable to locate application main window.");
        }

        private static ProcessStartInfo CreateProcessStartInfo => new()
        {
            FileName = ExecutablePath,
            WorkingDirectory = Path.GetDirectoryName(ExecutablePath),
            UseShellExecute = false
        };

        private void StopApplication()
        {
            try
            {
                _window?.Close();

                Keyboard.Press(VirtualKeyShort.KEY_N);

                _automation?.Dispose();

                _app?.Close();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Invalid operation while closing application: {ex.Message}");
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine($"Timeout while closing application: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected cleanup error: {ex.Message}");
            }
            finally
            {
                _window = null;
                _automation = null;
                _app = null;
            }
        }
    }
}
