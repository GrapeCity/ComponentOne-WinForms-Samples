Notes for Dashboard Demo .Net Core 3.0 version
----------------------------------------------

- Microsoft.EntityFramework.Core currently can be used with only .Net Core 3.0 preview 5 version.
- DashboardWinFormsCore.csproj contains a workaround for licesing described here:
https://github.com/Microsoft/msbuild/issues/2836
it fixes the problem with long path (Error: The specified task executable "lc.exe" could not be run. The filename or extension is too long...):
https://developercommunity.visualstudio.com/content/problem/291229/lcexe-the-filename-or-extension-is-too-long-1.html