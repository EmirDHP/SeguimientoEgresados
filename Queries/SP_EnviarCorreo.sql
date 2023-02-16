ALTER PROCEDURE SP_EviarCorreo
AS
BEGIN
	DECLARE @HTMLBody VARCHAR(max)
	SET @HTMLBody = '
<!DOCTYPE HTML PUBLIC "-//W3C//DTD XHTML 1.0 Transitional //EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xmlns:v="urn:schemas-microsoft-com:vml" xmlns:o="urn:schemas-microsoft-com:office:office">
<head>
<!--[if gte mso 9]>
<xml>
  <o:OfficeDocumentSettings>
    <o:AllowPNG/>
    <o:PixelsPerInch>96</o:PixelsPerInch>
  </o:OfficeDocumentSettings>
</xml>
<![endif]-->
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta name="x-apple-disable-message-reformatting">
  <!--[if !mso]><!--><meta http-equiv="X-UA-Compatible" content="IE=edge"><!--<![endif]-->
  <title></title>
  
    <style type="text/css">
      @media only screen and (min-width: 620px) {
  .u-row {
    width: 600px !important;
  }
  .u-row .u-col {
    vertical-align: top;
  }

  .u-row .u-col-100 {
    width: 600px !important;
  }

}

@media (max-width: 620px) {
  .u-row-container {
    max-width: 100% !important;
    padding-left: 0px !important;
    padding-right: 0px !important;
  }
  .u-row .u-col {
    min-width: 320px !important;
    max-width: 100% !important;
    display: block !important;
  }
  .u-row {
    width: calc(100% - 40px) !important;
  }
  .u-col {
    width: 100% !important;
  }
  .u-col > div {
    margin: 0 auto;
  }
}
body {
  margin: 0;
  padding: 0;
}

table,
tr,
td {
  vertical-align: top;
  border-collapse: collapse;
}

p {
  margin: 0;
}

.ie-container table,
.mso-container table {
  table-layout: fixed;
}

* {
  line-height: inherit;
}

a[x-apple-data-detectors=''true''] {
  color: inherit !important;
  text-decoration: none !important;
}

table, td { color: #000000; } @media (max-width: 480px) { #u_column_1 .v-col-padding { padding: 0px 0px 30px !important; } #u_content_heading_1 .v-font-size { font-size: 24px !important; } #u_content_heading_7 .v-font-size { font-size: 24px !important; } #u_column_2 .v-col-padding { padding: 30px 0px !important; } #u_content_heading_10 .v-font-size { font-size: 24px !important; } #u_content_heading_13 .v-font-size { font-size: 24px !important; } #u_column_4 .v-col-padding { padding: 30px 0px !important; } }
    </style>
  
  

<!--[if !mso]><!--><link href="https://fonts.googleapis.com/css?family=Cabin:400,700&display=swap" rel="stylesheet" type="text/css"><link href="https://fonts.googleapis.com/css?family=Playfair+Display:400,700&display=swap" rel="stylesheet" type="text/css"><!--<![endif]-->

</head>

<body class="clean-body u_body" style="margin: 0;padding: 0;-webkit-text-size-adjust: 100%;background-color: #ffffff;color: #000000">
  <!--[if IE]><div class="ie-container"><![endif]-->
  <!--[if mso]><div class="mso-container"><![endif]-->
  <table style="border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;min-width: 320px;Margin: 0 auto;background-color: #ffffff;width:100%" cellpadding="0" cellspacing="0">
  <tbody>
  <tr style="vertical-align: top">
    <td style="word-break: break-word;border-collapse: collapse !important;vertical-align: top">
    <!--[if (mso)|(IE)]><table width="100%" cellpadding="0" cellspacing="0" border="0"><tr><td align="center" style="background-color: #ffffff;"><![endif]-->
    

<div class="u-row-container" style="padding: 0px;background-color: #1ab192">
  <div class="u-row" style="Margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;">
    <div style="border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;">
      <!--[if (mso)|(IE)]><table width="100%" cellpadding="0" cellspacing="0" border="0"><tr><td style="padding: 0px;background-color: #1ab192;" align="center"><table cellpadding="0" cellspacing="0" border="0" style="width:600px;"><tr style="background-color: transparent;"><![endif]-->
      
<!--[if (mso)|(IE)]><td align="center" width="600" class="v-col-padding" style="width: 600px;padding: 0px 0px 40px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;" valign="top"><![endif]-->
<div id="u_column_1" class="u-col u-col-100" style="max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;">
  <div style="height: 100%;width: 100% !important;">
  <!--[if (!mso)&(!IE)]><!--><div class="v-col-padding" style="padding: 0px 0px 40px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;"><!--<![endif]-->
  
<table id="u_content_heading_1" style="font-family:arial,helvetica,sans-serif;" role="presentation" cellpadding="0" cellspacing="0" width="100%" border="0">
  <tbody>
    <tr>
      <td style="overflow-wrap:break-word;word-break:break-word;padding:10px 10px 4px;font-family:arial,helvetica,sans-serif;" align="left">
        
  <h1 class="v-font-size" style="margin: 0px; color: #ffffff; line-height: 140%; text-align: center; word-wrap: break-word; font-weight: normal; font-family: ''Cabin'',sans-serif; font-size: 32px;">
    <strong>Encuesta</strong>
  </h1>

      </td>
    </tr>
  </tbody>
</table>

<table id="u_content_heading_7" style="font-family:arial,helvetica,sans-serif;" role="presentation" cellpadding="0" cellspacing="0" width="100%" border="0">
  <tbody>
    <tr>
      <td style="overflow-wrap:break-word;word-break:break-word;padding:0px 10px 10px;font-family:arial,helvetica,sans-serif;" align="left">
        
  <h1 class="v-font-size" style="margin: 0px; color: #ffffff; line-height: 100%; text-align: center; word-wrap: break-word; font-weight: normal; font-family: ''Cabin'',sans-serif; font-size: 32px;">
    <strong>Seguimiento a Egresados</strong>
  </h1>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
</div>



<div class="u-row-container" style="padding: 0px;background-color: #ffffff">
  <div class="u-row" style="Margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: #ffffff;">
    <div style="border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;">
      <!--[if (mso)|(IE)]><table width="100%" cellpadding="0" cellspacing="0" border="0"><tr><td style="padding: 0px;background-color: #ffffff;" align="center"><table cellpadding="0" cellspacing="0" border="0" style="width:600px;"><tr style="background-color: #ffffff;"><![endif]-->
      
<!--[if (mso)|(IE)]><td align="center" width="600" class="v-col-padding" style="background-color: #ffffff;width: 600px;padding: 50px 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;" valign="top"><![endif]-->
<div id="u_column_2" class="u-col u-col-100" style="max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;">
  <div style="background-color: #ffffff;height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;">
  <!--[if (!mso)&(!IE)]><!--><div class="v-col-padding" style="padding: 50px 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"><!--<![endif]-->
  
<table id="u_content_heading_10" style="font-family:arial,helvetica,sans-serif;" role="presentation" cellpadding="0" cellspacing="0" width="100%" border="0">
  <tbody>
    <tr>
      <td style="overflow-wrap:break-word;word-break:break-word;padding:0px 10px 10px;font-family:arial,helvetica,sans-serif;" align="left">
        
  <h1 class="v-font-size" style="margin: 0px; line-height: 100%; text-align: center; word-wrap: break-word; font-weight: normal; font-family: ''Playfair Display'',serif; font-size: 32px;">
    <strong>¡Es momento de realizar la encuesta!</strong>
  </h1>

      </td>
    </tr>
  </tbody>
</table>

<table id="u_content_heading_13" style="font-family:arial,helvetica,sans-serif;" role="presentation" cellpadding="0" cellspacing="0" width="100%" border="0">
  <tbody>
    <tr>
      <td style="overflow-wrap:break-word;word-break:break-word;padding:0px 10px 10px;font-family:arial,helvetica,sans-serif;" align="left">
        
  <h1 class="v-font-size" style="margin: 0px; line-height: 100%; text-align: center; word-wrap: break-word; font-weight: normal; font-family: ''Playfair Display'',serif; font-size: 22px;">
    <strong><a href="https://stackoverflow.com/questions/71341483/bootstrap-5-tabs-with-next-prev-button">¡Da clic aquí para contestarlo!</a></strong>
  </h1>

      </td>
    </tr>
  </tbody>
</table>

<table style="font-family:arial,helvetica,sans-serif;" role="presentation" cellpadding="0" cellspacing="0" width="100%" border="0">
  <tbody>
    <tr>
      <td style="overflow-wrap:break-word;word-break:break-word;padding:15px 10px 10px;font-family:arial,helvetica,sans-serif;" align="left">
        
<table width="100%" cellpadding="0" cellspacing="0" border="0">
  <tr>
    <td style="padding-right: 0px;padding-left: 0px;" align="center">
      
      <img align="center" border="0" src="data:image/png;base64,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" alt="image" title="image" style="outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: inline-block !important;border: none;height: auto;float: none;width: 70%;max-width: 406px;" width="406"/>
      
    </td>
  </tr>
</table>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
</div>



<div class="u-row-container" style="padding: 0px;background-color: #353535">
  <div class="u-row" style="Margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;">
    <div style="border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;">
      <!--[if (mso)|(IE)]><table width="100%" cellpadding="0" cellspacing="0" border="0"><tr><td style="padding: 0px;background-color: #353535;" align="center"><table cellpadding="0" cellspacing="0" border="0" style="width:600px;"><tr style="background-color: transparent;"><![endif]-->
      
<!--[if (mso)|(IE)]><td align="center" width="600" class="v-col-padding" style="width: 600px;padding: 35px 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;" valign="top"><![endif]-->
<div id="u_column_4" class="u-col u-col-100" style="max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;">
  <div style="height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;">
  <!--[if (!mso)&(!IE)]><!--><div class="v-col-padding" style="padding: 35px 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"><!--<![endif]-->
  
<table style="font-family:arial,helvetica,sans-serif;" role="presentation" cellpadding="0" cellspacing="0" width="100%" border="0">
  <tbody>
    <tr>
      <td style="overflow-wrap:break-word;word-break:break-word;padding:10px 45px;font-family:arial,helvetica,sans-serif;" align="left">
        
  <div style="color: #ffffff; line-height: 140%; text-align: center; word-wrap: break-word;">
    <p style="font-size: 14px; line-height: 140%;">Universidad Tecnológica de Tamaulipas Norte</p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
</div>


    <!--[if (mso)|(IE)]></td></tr></table><![endif]-->
    </td>
  </tr>
  </tbody>
  </table>
  <!--[if mso]></div><![endif]-->
  <!--[if IE]></div><![endif]-->
</body>

</html>'
	DECLARE @email VARCHAR(4000)	
	------
	SET @email =''
	SELECT @email = RTRIM(@email) + RTRIM(CorreoElectronico) + ';'
	FROM USUARIOS
	WHERE IdPerfil = 2
	PRINT @email

	EXEC msdb.dbo.sp_send_dbmail
		@profile_name = 'SeguimientoEgresados'
	   ,@recipients = @email
	   ,@subject = 'Encuesta Seguimiento a Egresados'
	   ,@body = @HTMLBody
	   ,@body_format = 'HTML'
	   --,@body = 'Correo con JOB'
	   ,@importance ='HIGH'
END
GO

--exec SP_EviarCorreo