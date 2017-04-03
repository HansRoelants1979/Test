﻿<?xml version="1.0" ?><xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0"><xsl:output method="text" indent="no"/><xsl:template match="/data"><![CDATA[<font face=Tahoma size=2><span style="color:rgb(51, 51, 51);">Sehr geehrter Reisegast,</span>&#160;v<span style="color:rgb(51, 51, 51);">ielen Dank, dass Sie sich an uns gewandt haben.</span></font><div><p style="margin-top:10px;margin-bottom:0px;padding:0px;color:rgb(51, 51, 51);"><font face=Tahoma size=2><br>Sie haben uns mitgeteilt&#160;:&#160;]]><xsl:choose><xsl:when test="incident/description"><xsl:value-of select="incident/description" /></xsl:when><xsl:otherwise></xsl:otherwise></xsl:choose><![CDATA[ <br><br>Wir haben Ihr Anliegen aufgenommen und kommen in Kürze wieder auf Sie zu.&#160;<br><br>Herzlichen Dank für Ihre Geduld.&#160;<br>Wir bitten um Ihre zeitnahe Antwort an den Absender der Nachricht, ob der Text so notiert wurde, wie Sie ihn uns geschildert haben.<br>Ergänzend möchten wir darauf hinweisen, dass die Richtigkeit oder Begründetheit der geschilderten Punkte hiermit nicht bestätigt wird. Die Kommunikation dient als Nachweis eines vorgebrachten Abhilfeverlangens gegenüber der Reiseleitung. Etwaige Fristen werden mit der Meldung nicht wahrgenommen.</font></p><p style="margin-top:10px;margin-bottom:0px;padding:0px;color:rgb(51, 51, 51);"><font face=Tahoma size=2><img style="" src="http://cdn.thomascook.com/images/uploads/icons/BUC%20BUCHER.jpg"><br></font></p><p style="margin-top:10px;margin-bottom:0px;padding:0px;color:rgb(51, 51, 51);"><font face=Tahoma size=2>Bankverbindung: Deutsche Bank AG Meerbusch – BLZ 300 700 10 – Konto 5 342 050<br>IBAN: DE84 3007 0010 0534 2050 00 – BIC: DEUTDEDDXXX<br>Geschäftsführer: Michael Gisbertz – Amtsgericht Neuss HRB 7534</font><font face=Tahoma size=2><br></font></p></div><font face="Tahoma, Verdana, Arial" size=2 style="display:inline;"></font>]]></xsl:template></xsl:stylesheet>