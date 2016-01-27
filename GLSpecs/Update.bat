
SET SVN_CO=svn --non-interactive --depth=files checkout
SET URL_BASE=https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/api/

%SVN_CO% %URL_BASE% .UpdatedSpecs

copy .UpdatedSpecs\gl.xml gl.xml
copy .UpdatedSpecs\wgl.xml wgl.xml
copy .UpdatedSpecs\glx.xml glx.xml
copy .UpdatedSpecs\egl.xml egl.xml

pause