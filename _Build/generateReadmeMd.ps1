Get-ChildItem ".." -Recurse | where {$_.Name -eq "readme.txt"} | % {
    $readme = $_.FullName
    $readme
    $url="https://github.com/GrapeCity/ComponentOne-WinForms-Samples/archive/master.zip"
    $command = "H:\_GC\Git\c1-winforms-samples\Build\Bin\CreateMDFiles.exe $readme $url"
    Invoke-Expression $command
}