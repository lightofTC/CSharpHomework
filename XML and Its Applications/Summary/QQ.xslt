<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:template match="/">
		<html>
			<head>
				<title>Comprehensive experiment</title>
			</head>
			<body>
				<div align="center">
					<h2>综合实验：XLST指定数据输出</h2>
				</div>
					<xsl:apply-templates mode="a1"/>
					<xsl:apply-templates mode="a2"/>
			</body>
		</html>
	</xsl:template>
	<xsl:template match="QQ" mode="a1">
		<p align="center">
			<div align="center">
			<br/><br/>
				<h4>年龄大于20的男性信息</h4>
			</div>
			<xsl:for-each select="//person[gender/text()='male' and age>=20]">
				<xsl:call-template name="result"/>
			</xsl:for-each>
		</p>
	</xsl:template>
	<xsl:template match="QQ" mode="a2">
		<p align="center">
			<div align="center">
			<br/><br/>
				<h4>所有带有cname属性和dname元素的信息</h4>
			</div>
			<xsl:for-each select="//category[@cname]/person[dname]">
				<xsl:call-template name="result"/>
			</xsl:for-each>
		</p>
	</xsl:template>
	<xsl:template name="result">
		<p align="center">
			<table border="1">
				<tr bgcolor="#4dcd8f">
					<th>number</th>
					<th>dname</th>
					<th>name</th>
					<th>gender</th>
					<th>info</th>
					<th>age</th>
					<th>zodiac</th>
					<th>level</th>
				</tr>
				<tr>
					<td>
						<xsl:value-of select="number"/>
					</td>
					<td>
						<xsl:value-of select="dname"/>
					</td>
					<td>
						<xsl:value-of select="name"/>
					</td>
					<td>
						<xsl:value-of select="gender"/>
					</td>
					<td>
						<xsl:value-of select="info"/>
					</td>
					<td>
						<xsl:value-of select="age"/>
					</td>
					<td>
						<xsl:value-of select="zodiac"/>
					</td>
					<td>
						<xsl:value-of select="level"/>
					</td>
				</tr>
			</table>
		</p>
	</xsl:template>
</xsl:stylesheet>
