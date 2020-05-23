<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:fn="http://www.w3.org/2005/xpath-functions">
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:template match="/">
	<xsl:comment>Comment</xsl:comment>
		<book>
		<xsl:element name="authors">
     		<xsl:element name="author"/>
     		<xsl:element name="author"/>
     		<xsl:element name="author"/>
		</xsl:element>
			<xsl:apply-templates select="//section[not(parent::section)]"/>
		</book>
	</xsl:template>
	<xsl:template match="section">
	<xsl:comment>Comment</xsl:comment>
		<section>
			<xsl:copy-of select="@*"/>
			<xsl:apply-templates select="./title"/>
			<xsl:if test="./section">
				<xsl:apply-templates select="./section"/>
			</xsl:if>
			<xsl:if test="./figure">
			<figure>
			<xsl:copy-of select="@*"/>
			    <xsl:apply-templates select="./title"/>
			    </figure>
			</xsl:if>
		</section>
	</xsl:template>
	<xsl:template match="title">
		<title>
			<xsl:copy-of select="text()"/>
		</title>
	</xsl:template>
</xsl:stylesheet>
