# PowerShell script to install BuildKit and add it to system PATH

# Configuration
$exeUrl = "https://gcteststorage.blob.core.windows.net/test/c1buildkit/c1buildkit.exe"
$installDir = "C:\Program Files\C1BuildKit"
$aliasName = "c1buildkit.exe"

# Create installation directory if it doesn't exist
if (-not (Test-Path $installDir)) {
    Write-Host "Creating install directory at $installDir"
    New-Item -ItemType Directory -Path $installDir | Out-Null
}

# Download BuildKit.exe
Write-Host "Downloading c1buildkit.exe..."
Invoke-WebRequest -Uri $exeUrl -OutFile "$installDir\c1buildkit.exe"

# Add to system PATH if not already present
$oldPath = [Environment]::GetEnvironmentVariable("Path", [EnvironmentVariableTarget]::Machine)
if ($oldPath -notlike "*${installDir}*") {
    Write-Host "Adding $installDir to system PATH"
    $newPath = "$oldPath;$installDir"
    [Environment]::SetEnvironmentVariable("Path", $newPath, [EnvironmentVariableTarget]::Machine)
    Write-Host "System PATH updated. You may need to restart your terminal or log off and back on."
} else {
    Write-Host "$installDir already in system PATH"
}

Write-Host "Installation complete. You can now run 'c1buildkit' from anywhere."
