<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  
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
	<xsl:template match="para/constant">
		<see cref="{.}"/>
	</xsl:template>
	<xsl:template match="term/constant">
		<see cref="{.}"/>
	</xsl:template>

	<!-- Function renaming: 'glFoo' -> 'Gl.Foo' -->
	<xsl:template match="para/function">
		<see cref="{.}"/>
	</xsl:template>
	<xsl:template match="para/citerefentry/refentrytitle">
		<see cref="{.}"/>
	</xsl:template>

	<!-- Parameter reference: 'param' -> <paramref name="param" /> -->
	<xsl:template match="para/parameter">
		<paramref name="{.}"/>
	</xsl:template>

	<!-- Program listing Doxygen markup (<code> does not work, maintains indentation) -->
	<xsl:template match="programlisting/text()">
		@code
		<xsl:value-of select="."/>
		@endcode
	</xsl:template>

	<!-- Variable listing (rendered as dotted point list) -->
	<xsl:template match="variablelist/varlistentry">
		- <xsl:apply-templates select="term/constant"/>: <xsl:apply-templates select="listitem"/>
	</xsl:template>

	<!-- MathML equations -->
	<xsl:template match="para/informalequation">
		@htmlonly <informalequation><xsl:copy-of select="*"/></informalequation> @endhtmlonly
	</xsl:template>
	<xsl:template match="para/inlineequation">
		@htmlonly <inlineequation><xsl:copy-of select="*"/></inlineequation> @endhtmlonly
	</xsl:template>
</xsl:stylesheet>