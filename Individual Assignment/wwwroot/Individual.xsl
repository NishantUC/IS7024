<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <meta charset="utf-8"/>
        <title>Favourite Shortcuts</title>
     <link rel="stylesheet" href="/css/web.css" ></link>
    <link rel="stylesheet" href="/css/print.css" ></link>
    <link rel="stylesheet" href="/css/mobile.css" ></link>
      </head>
      <body>
        <div>
          <h1>My Team Favourite Shortcuts!</h1>
          <table class="shortcuts">
            <tr>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Bearcat Id</th>
              <th>Shortcut</th>
            </tr>
            <xsl:for-each select="/users/user">
              <tr>
                <td>
                  <xsl:value-of select="firstname"/>
                </td>
                <td>
                  <xsl:value-of select="lastname"/>
                </td>
                <td>
                  <xsl:value-of select="bearcatid"/>
                </td>
                <td>
                  <xsl:value-of select="favoriteshortcut"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </div>

      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>