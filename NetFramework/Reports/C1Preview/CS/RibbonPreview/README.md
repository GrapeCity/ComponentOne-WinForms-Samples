## C1RibbonPreview
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Preview\CS\RibbonPreview)
____
#### Implements a preview/item template with C1Ribbon and C1Command based UI
____
This sample implements a print preview control with a user interface based on two other ComponentOne products - C1Ribbon and C1Command. It also provides a Visual Studio project item template that can be used to add a pre-built fully customizable preview form to your application. 

Please note that in order to use this sample in a production environment, you need to have valid licenses for those two products (C1Ribbon and C1Command) in addition to a license for C1Preview (or C1Report). 

The main sample folder (where this readme.txt file is located), together with the "Properties" sub-folder, contains a complete Visual Studio Windows Application project/solution. If you simply build and run it, the main window with a C1PreviewPane and associated controls will show. You can use the "file open" button to load an existing C1D/C1DX file, or use the (existing) C1RibbonPrintPreviewForm_Load event handler to generate your own custom document and load it into the preview. For example, adding the following 2 lines of code at the top of the C1RibbonPrintPreviewForm_Load method will show the "Hello, World!" document: 

C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument(); doc.Body.Children.Add(new C1.C1Preview.RenderText("Hello, World!")); ppMain.Document = doc; 

But more usefully, this sample also provides a Visual Studio (2005 or 2008) project item template, which can be used to add new RibbonPreviewForm items to C# projects. The template files are located in the "Template", subfolder, together with the ZIP archive containing those files. While if you used the C1 products installer, you should have the template already added to the Visual Studio, it is also easy to install the template manually as described below. 

To add the template to your Visual Studio installation, follow these steps: 

1. Make sure you have C1Preview, C1Ribbon and C1Command products correctly installed. For production development, you must have valid licenses for those three products. 

2. Copy the included "Template\C1RibbonPrintPreviewForm.zip" file to the "Common7\IDE\ItemTemplates\CSharp\1033" sub-directory of your Visual Studio installation directory which is usually located in "c:\Program Files\Microsoft Visual Studio 8" or "c:\Program Files\Microsoft Visual Studio 9.0".  3. In Windows, run the command "devenv /setup" (where "devenv" is the Visual Studio development environment executable to which you are adding the template; you may have to provide the full path to the "devenv.ext" file). Note that this command will take some time to complete.  4. To test your newly added template, run Visual Studio, create a new Windows Forms Application C# project, right-click on the project in the solution explorer, and select "Add | New item..." in the context menu. The dialog that pops up should contain "C1Ribbon Print Preview Form" as one of the installed templates. Select it, and a form with the default name "RibbonPreviewForm1.cs" will be added to your application (you may of course rename it to something more appropriate).  5. Open the newly added form in the Visual Studio designer - this will add the required C1 product licenses to the licenses.licx file in your project.  6. Now you can customize and use the added preview form as any other form in your app. The names of the preview controls are: 

- ppMain (C1.Win.C1Preview.C1PreviewPane); - ptvMain (C1.Win.C1Preview.C1PreviewThumbnailView); - povMain (C1.Win.C1Preview.C1PreviewOutlineView); - ptspMain (1.Win.C1Preview.C1PreviewTextSearchPanel).  

Changing the template .-.-.-.-.-.-.-.-.-.-. 

You may want to update the provided template, e.g. to adapt it to your organization's specific requirements. To do that, follow these steps: 

1. Open the sample project (NOT the template) in Visual Studio, customize as needed. 

2. Copy the following files from the modified sample directory to a new directory, e.g. to "MyTemplate": 

C1RibbonPrintPreviewForm.cs C1RibbonPrintPreviewForm.Designer.cs C1RibbonPrintPreviewForm.resx C1RibbonPrintPreviewForm.vstemplate C1RibbonPrintPreviewForm.ico  3. In "MyTemplate" directory, in the two .cs files, replace all occurrences of: 

"namespace RibbonPreview" with "namespace $rootnamespace$" "C1RibbonPrintPreviewForm" with "$safeitemname$"  (you may use the Visual Studio editor, or the text editor of your choice, to do that.)  4. Zip up the content of the "MyTemplate" directory into the file C1RibbonPrintPreviewForm.zip (note that the files must be in the root of the archive, not in a subdirectory), and repeat steps 2 and 3 of adding the template to your Visual Studio installation described at the top of this readme.  That's it. 