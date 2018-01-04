
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

@SET TEST_RUN=packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe
@SET TEST_OPTS=--noheader --labels=All
@SET TEST_WHERE=--where="cat=EGL||cat=WGL||cat=Math||cat=Framework||cat=Toolkit_CoreUI"

@SET OPENGL_NET_PLATFORM=WGL
%TEST_RUN% OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll               %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net461.xml --inprocess
%TEST_RUN% OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll               %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net461_x86.xml --x86
%TEST_RUN% OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll                %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net35.xml --inprocess
%TEST_RUN% OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll                %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net35_x86.xml --x86 
%TEST_RUN% OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net.CoreUI_net461.xml --inprocess
%TEST_RUN% OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net.CoreUI_net461_x86.xml --x86

@SET OPENGL_NET_PLATFORM=EGL
%TEST_RUN% OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll               %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net461.xml --inprocess
%TEST_RUN% OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll               %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net461_x86.xml --x86
%TEST_RUN% OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll                %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net35.xml --inprocess
%TEST_RUN% OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll                %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net_net35_x86.xml --x86 
%TEST_RUN% OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net.CoreUI_net461.xml --inprocess
%TEST_RUN% OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_WHERE% %TEST_OPTS% --result=OpenGL.Net.CoreUI_net461_x86.xml --x86

@SET COVER_RUN=packages\OpenCover.4.6.519\tools\OpenCover.Console.exe
@SET COVER_OPTS=-register:user -target:"packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe" -hideskipped:All
@SET COVER_EXCLUDE=-excludebyattribute:*.RequiredByFeature*
@SET COVER_WHERE=--where=\"cat=EGL||cat=WGL||cat=Math||cat=Framework||cat=Toolkit_CoreUI\"

@SET OPENGL_NET_PLATFORM=WGL
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll %TEST_OPTS% --inprocess" -output:.\CovWglOpenGL.Net_net461.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll %TEST_OPTS% --x86" -output:.\CovWglOpenGL.Net_net461_x86.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll %TEST_OPTS% --inprocess" -output:.\CovWglOpenGL.Net_net35.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll %TEST_OPTS% --x86" -output:.\CovWglOpenGL.Net_net35_x86.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_OPTS% --inprocess" -output:.\CovWglOpenGL.Net.CoreUI_net461.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_OPTS% --x86" -output:.\CovWglOpenGL.Net.CoreUI_net461_x86.xml

@SET OPENGL_NET_PLATFORM=EGL
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll %TEST_OPTS% --inprocess" -output:.\CovEglOpenGL.Net_net461.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll %TEST_OPTS% --x86" -output:.\CovEglOpenGL.Net_net461_x86.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll %TEST_OPTS% --inprocess" -output:.\CovEglOpenGL.Net_net35.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll %TEST_OPTS% --x86" -output:.\CovEglOpenGL.Net_net35_x86.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_OPTS% --inprocess" -output:.\CovEglOpenGL.Net.CoreUI_net461.xml
%COVER_RUN% %COVER_OPTS% %COVER_EXCLUDE% -targetargs:"OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll %TEST_OPTS% --x86" -output:.\CovEglOpenGL.Net.CoreUI_net461_x86.xml

@SET REPORT_RUN=packages\ReportGenerator.2.5.7\tools\ReportGenerator.exe

%REPORT_RUN% "-reports:Cov*.xml" "-targetdir:CodeCoverageReport" "-reporttypes:Html"

:ERROR

pause