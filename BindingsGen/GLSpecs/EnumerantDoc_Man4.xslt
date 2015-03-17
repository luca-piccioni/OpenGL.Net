<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:x="http://docbook.org/ns/docbook">

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
	<xsl:template match="x:constant">
		<xsl:value-of select="$class"/>.<xsl:value-of select="substring(., string-length($class) + 2)"/>
	</xsl:template>

	<!-- Function renaming: 'glFoo' -> 'Gl.Foo' -->
	<xsl:template match="x:citerefentry/x:refentrytitle">
		<xsl:value-of select="$class"/>.<xsl:value-of select="substring(., string-length($class) + 1)"/>
	</xsl:template>
	
	<xsl:template match="function">
		<xsl:variable name="prefix">&lt;see_cref="Gl.</xsl:variable>
		<xsl:variable name="postfix">"/&gt;</xsl:variable>
		<xsl:value-of select="concat($prefix, substring(., 3), $postfix)" disable-output-escaping="yes"/>
	</xsl:template>

	<!-- Parameter reference: 'param' -> <paramref name="param" /> -->
	<xsl:template match="parameter">
		<xsl:variable name="prefix">&lt;paramref_name="</xsl:variable>
		<xsl:variable name="postfix">"/&gt;</xsl:variable>
		<xsl:value-of select="concat($prefix, ., $postfix)" disable-output-escaping="yes"/>
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