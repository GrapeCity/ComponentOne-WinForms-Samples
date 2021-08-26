SsrsQuickStart
----------------------------------------
Very simple sample showing how to use C1SSRSDocumentSource component to preview a SSRS report

This very basic sample shows how C1SSRSDocumentSource component can be used by 
C1PrintPreviewControl to preview a report from an SSRS server.

The code connects to an example SSRS server provided by ComponentOne.
Adjust the C1SSRSDocumentSource's properties to connect to a different
report server (such as one provided by your company for example).

The steps listed below are enough to create this sample from scratch.

o Prerequisites: before you start following this quick start, you must have 
  access to a SSRS report server with some reports. The info you will need 
  includes the address of the server, the path to a report on it, and valid
  credentials (user id and password) which allow to access the report. If you do 
  not have this information, contact your system administrator.
  
  An easy way to make sure that the server address and other info is valid is to 
  try opening the server using a web browser. Entering the server address in the 
  URL box of the web browser should, after asking for your credentials, open the
  list of available reports. Clicking on a report should show it within the
  browser. Please make sure that it works before continuing. Again, if you need
  help with this contact your system administrator.

o Create a new WinForms application, targeting .NET 4.0 or later (note that 
  C1SSRSDocumentSource is only available in the .NET 4.0 version of the C1 
  Studio for WinForms).

o Open the application's form in the VS forms designer. From the toolbox, pick 
  and drop a C1PrintPreviewControl on the form, position and size it as desired. 
  Then also from the toolbox pick and drop on the form a C1SSRSDocumentSource. 
  It is a component (not a control), so it will appear in the form's component 
  tray, with the default name c1SSRSDocumentSource1.
  
o Click the c1SSRSDocumentSource1 component, then click the smart task arrow at 
  the upper-right corner of the component. The popup menu should contain an entry
  for the C1PrintPreviewControl, with a checkbox to its left. Check it, this will
  assign the c1SSRSDocumentSource1 to the preview control's Document property.
  
o Go to c1SSRSDocumentSource1's properties in the properties window, and in it to
  the DocumentLocation property. Click the dropdown arrow in the value field, this
  will open a small window with two fields where you should specify the address of
  your SSRS server, and the full path to the report on that server which you want
  to preview. Fill in the two fields with the address of your server and a report
  on it.
  
o Credentials: there are two ways to provide credentials that will be used to 
  access the SSRS server, you may use either depending on your needs:
  
  - C1SSRSDocumentSource allows to specify credentials directly as the 
    component's properties. To do that, expand the ConnectionOptions property,
    click the dropdown arrow in the Credential field, type a valid user name and
    password in the provided fields, and click OK to save the changes. Then, when
    C1SSRSDocumentSource accesses the SSRS server, it will use those credentials.
    But please note the following: the specified credentials are saved in your
    form's InitializeComponent() code as a Base64-encoded string. While this does
    avoid showing the credentials in plain text, it is NOT AN ENCRYPTION, and does
    NOT provide any level of security at all.
    
  - Alternatively, you can subscribe to the C1SSRSDocumentSource's SecurityError
    event, which will fire when acces to the SSRS server fails due to lack of
    credentials, and allows you to provide the required credentials and retry the
    operation again. To do that, switch to the C1SSRSDocumentSource's events 
    tab, and double click the SecurityError event. This will create an empty 
    handler for that event in your code. Go to the newly created handler method, 
    and change it as follows:
  
    private void c1SSRSDocumentSource1_SecurityError(object sender, C1.Win.C1Document.SecurityErrorEventArgs e)
    {
      var ds = (C1.Win.C1Document.C1SSRSDocumentSource)sender;
      ds.Credential = new System.Net.NetworkCredential("myUserId", "myPassword");
      e.Retry = true;
    }

    In the code above, replace "myUserId" and "myPassword" with the valid 
    credentials for your SSRS server. When your form loads, the 
    c1SSRSDocumentSource1 component will try to access the specified report. 
    Normally doing this without proper credentials will fail, causing a security 
    error. When such an error occurs, and you have specified a handler for it, 
    that handler will get called, which allows to provide valid credentials and 
    retry the operation. Of course, in a real application you would probably ask 
    the user to enter credentials, or provide some other secure method of 
    providing them.
  
o You're done, now build and run your application. If all goes well, after a short
  delay you should see the specified SSRS report in the preview control. You can now
  browse the pages of the report, export it to a number of supported external formats
  such as PDF, or print it.
