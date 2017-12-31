
@SET CWD=%CD%
@CALL "C:\Program Files (x86)\Microsoft Visual Studio\Preview\Community\Common7\Tools\VsDevCmd.bat"
cd %CWD%

@SET SLN_PATH=OpenGL.Net_VC15.sln
@SET SLN_BUILD_OPTS=/verbosity:minimal

msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Release /p:Platform="Any CPU"
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Release /p:Platform="x86"
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Release /p:Platform="x64"
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Debug   /p:Platform="Any CPU"
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Debug   /p:Platform="x86"
msbuild %SLN_PATH% %SLN_BUILD_OPTS% /property:Configuration=Debug   /p:Platform="x64"

@SET TEST_RUN=packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe
@SET TEST_OPTS=--noheader
@SET TEST_WHERE=--where="cat=GL || cat=EGL || cat =WGL || cat=GL_VERSION_1_0 || cat=Math || cat=Framework || cat=Toolkit_CoreUI"

%TEST_RUN% %TEST_WHERE% %TEST_OPTS%       --out=OpenGL.Net_net461.xml            OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll
%TEST_RUN% %TEST_WHERE% %TEST_OPTS%       --out=OpenGL.Net_net35.xml             OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll
%TEST_RUN% %TEST_WHERE% %TEST_OPTS%       --out=OpenGL.Net.CoreUI_net461.xml     OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll
%TEST_RUN% %TEST_WHERE% %TEST_OPTS% --x86 --out=OpenGL.Net_net461_x86.xml        OpenGL.Net.Test\bin\net461\Release\OpenGL.Net.Test.dll
%TEST_RUN% %TEST_WHERE% %TEST_OPTS% --x86 --out=OpenGL.Net_net35_x86.xml         OpenGL.Net.Test\bin\net35\Release\OpenGL.Net.Test.dll
%TEST_RUN% %TEST_WHERE% %TEST_OPTS% --x86 --out=OpenGL.Net.CoreUI_net461_x86.xml OpenGL.Net.CoreUI.Test\bin\net461\Release\OpenGL.Net.CoreUI.Test.dll

pause