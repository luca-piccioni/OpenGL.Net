<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:param name="class"/>
	
  <!-- Do not output XML declaration -->
	<xsl:output omit-xml-declaration="yes"/>
  <!-- Root template -->
	<xsl:template match="/">
		<xsl:copy>
			<xsl:apply-templates/>
		</xsl:copy>
	</xsl:template>

	<xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
	<xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>

	<!-- Constant renaming: 'GL_FOO' -> 'GL.FOO' -->
	<xsl:template match="constant">
		<xsl:value-of select="$class"/>.<xsl:value-of select="substring(., string-length($class) + 2)"/>
	</xsl:template>

	<!-- Function renaming: 'glFoo' -> 'Gl.Foo' -->
	<xsl:template match="citerefentry/refentrytitle">
		<xsl:value-of select="$class"/>.<xsl:value-of select="substring(., string-length($class) + 1)"/>
	</xsl:template>
	
</xsl:stylesheet>