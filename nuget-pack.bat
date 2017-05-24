# Utility script for packing nuget packages

set NUGET=nuget.exe
set VERSION=0.5.1-beta

del *.nupkg

%NUGET% pack OpenGL.Net.nuspec -Version %VERSION%
%NUGET% pack OpenGL.Net.WinForms.nuspec -Version %VERSION%

pause