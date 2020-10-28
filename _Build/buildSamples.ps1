Get-ChildItem "H:\_GC\Git\c1-winforms-samples\Core" -Recurse | where {$_.extension -eq ".sln"} | % {
    $sln = $_.FullName
    $sln
    $command = "dotnet msbuild $sln /t:restore,build" 
    Invoke-Expression $command
}