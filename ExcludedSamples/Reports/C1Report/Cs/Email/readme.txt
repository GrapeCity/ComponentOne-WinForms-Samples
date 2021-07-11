EMail
------------------------------------------------------------------------
Send reports by email.

The .NET Framework has built-in support for sending e-mail. The relevant
classes are in the System.Web.Mail namespace. You can use the MailMessage
class to create email messages and add reports as attachments (Pdf, Html,
Rtf, etc) or even include the full report in the message body.

The attached project shows how this works.

Note that in order to use the sample, you will have to change the line
below to include your email smtp server:

  SmtpMail.SmtpServer = "YOUR.SMTP.SERVER.HERE";

