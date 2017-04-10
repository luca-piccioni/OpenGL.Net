
SET SVN_CO=wget64.exe
SET URL_BASE=https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/

%SVN_CO% %URL_BASE% .UpdatedSpecs

%SVN_CO% %URL_BASE%/gl.xml
%SVN_CO% %URL_BASE%/wgl.xml
%SVN_CO% %URL_BASE%/glx.xml

pause