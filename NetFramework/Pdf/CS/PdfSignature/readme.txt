PdfSignature
------------------------------------------------------------------------
Creates a Pdf document containing a digital signature.

To add a signature to a C1Pdf document, you need to create and configure a PdfSignature object, than add it to the document using the AddField method.

For example:

<code>
	// create and configure PdfSignature object
	PdfSignature signature = new PdfSignature();
	signature.Reason = "Demo";
	signature.Certificate = _certificate as X509Certificate2;
	signature.Handler = SignatureHandler.PPKLite;
	signature.Visibility = FieldVisibility.Visible;
	signature.BorderWidth = FieldBorderWidth.Medium;
	signature.BorderColor = Color.Blue;
	signature.BackColor = Color.White;
	signature.Text = "Signature Field";
	signature.Font = new Font("Tahoma", 14, FontStyle.Italic | FontStyle.Bold);

	// add the signature to the document
	_c1pdf.AddField(signature, new RectangleF(100, rc.Height - 100, 200, 50));
</code>

The code above assigns a Certificate to the signature. The Certificate is responsible for ensuring the identity of the sender.

The Certificate property is of type X509Certificate2, a class defined in the  .NET System.dll (System.Security.Cryptography.X509Certificates namespace) and documented here:

	http://msdn.microsoft.com/en-us/library/system.security.cryptography.x509certificates.x509certificate2.aspx

Instantiating the certificate can be done as follows:

<code>
	X509Certificate2 _certificate;
	_certificate = new X509Certificate2(
		certificateFileName, 
		certificateFilePassword, 
		X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.MachineKeySet);
</code>

The certificateFileName parameter identifies an X509 certificate file issued to the document author (for details, please see http://en.wikipedia.org/wiki/X.509).

The signature.Handler property in the first code block determines the signature mode. C1Pdf supports two modes:
 - The "PPKMS" mode authenticates using a hash code instead of the actual file data. This mode is faster but less secure.
 - The "PPKLite" mode authenticates using the actual file data. It is slower but more secure.