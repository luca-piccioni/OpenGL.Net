
@CALL "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsMSBuildCmd.bat"

@SET SLN_PATH=OpenGL.Net_VC14.sln
@SET SLN_BUILD_OPTS=/verbosity:minimal

msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Release /p:Platform="Any CPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Debug   /p:Platform="Any CPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Debug   /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Debug   /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

@SET PATH=%PATH%;%ProgramFiles(x86)%\Android\android-sdk\platform-tools

@SET TEST_OPTS=--noheader --labels=All

@SET OPENGL_NET_PLATFORM=WGL

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

@SET OPENGL_NET_PLATFORM=EGL

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:UnitTest /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

@SET COVER_RUN=packages\OpenCover.4.6.519\tools\OpenCover.Console.exe
@SET COVER_OPTS=-register:user -target:"packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe" -hideskipped:All
@SET COVER_EXCLUDE=-excludebyattribute:*.RequiredByFeature*
@SET COVER_WHERE=--where=\"cat=EGL||cat=WGL||cat=Math||cat=Framework||cat=Toolkit_CoreUI\"

@SET OPENGL_NET_PLATFORM=WGL

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

@SET OPENGL_NET_PLATFORM=EGL

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.Test\OpenGL.Net.Test_net35.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="AnyCPU"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x86"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR
msbuild OpenGL.Net.CoreUI.Test\OpenGL.Net.CoreUI.Test_net461.csproj %SLN_BUILD_OPTS% /target:Coverage /property:Configuration=Release /p:Platform="x64"
IF %ERRORLEVEL% NEQ 0 GOTO :ERROR

@SET REPORT_RUN=packages\ReportGenerator.2.5.7\tools\ReportGenerator.exe

%REPORT_RUN% "-reports:Cov*.xml" "-targetdir:CodeCoverageReport" "-reporttypes:Html"

:ERROR

pause