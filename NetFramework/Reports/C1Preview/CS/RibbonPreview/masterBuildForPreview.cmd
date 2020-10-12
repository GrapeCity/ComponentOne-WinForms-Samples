setlocal

if not exist Template md Template
if exist Template\*.* del /q /y Template\*.*

copy C1RibbonPrintPreviewForm.vstemplate Template\C1RibbonPrintPreviewForm.vstemplate
copy C1RibbonPrintPreviewForm.ico Template\C1RibbonPrintPreviewForm.ico
copy C1RibbonPrintPreviewForm.resx Template\C1RibbonPrintPreviewForm.resx

sreplace -rt C1RibbonPrintPreviewForm.cs Template\C1RibbonPrintPreviewForm.cs "namespace RibbonPreview" "namespace $rootnamespace$"
sreplace -rt Template\C1RibbonPrintPreviewForm.cs Template\C1RibbonPrintPreviewForm.cs "C1RibbonPrintPreviewForm" "$safeitemname$"
sreplace -rt C1RibbonPrintPreviewForm.Designer.cs Template\C1RibbonPrintPreviewForm.Designer.cs "namespace RibbonPreview" "namespace $rootnamespace$"
sreplace -rt Template\C1RibbonPrintPreviewForm.Designer.cs Template\C1RibbonPrintPreviewForm.Designer.cs "C1RibbonPrintPreviewForm" "$safeitemname$"

pushd Template
zip -o -D -9 C1RibbonPrintPreviewForm.zip *.*
popd

endlocal
