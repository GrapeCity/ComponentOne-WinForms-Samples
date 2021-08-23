setlocal
pushd

if not exist Template md Template
del /q /y Template\*.*

copy C1RibbonPrintPreviewForm.vstemplate Template\C1RibbonPrintPreviewForm.vstemplate
copy C1RibbonPrintPreviewForm.ico Template\C1RibbonPrintPreviewForm.ico
copy C1RibbonPrintPreviewForm.resx Template\C1RibbonPrintPreviewForm.resx
..\..\..\..\MasterBuild\Bin\sreplace C1RibbonPrintPreviewForm.cs Template\C1RibbonPrintPreviewForm.cs "namespace RibbonPreview" "namespace $rootnamespace$"
..\..\..\..\MasterBuild\Bin\sreplace Template\C1RibbonPrintPreviewForm.cs Template\C1RibbonPrintPreviewForm.cs "C1RibbonPrintPreviewForm" "$safeitemname$"
..\..\..\..\MasterBuild\Bin\sreplace C1RibbonPrintPreviewForm.Designer.cs Template\C1RibbonPrintPreviewForm.Designer.cs "namespace RibbonPreview" "namespace $rootnamespace$"
..\..\..\..\MasterBuild\Bin\sreplace Template\C1RibbonPrintPreviewForm.Designer.cs Template\C1RibbonPrintPreviewForm.Designer.cs "C1RibbonPrintPreviewForm" "$safeitemname$"

cd Template
..\..\..\..\..\MasterBuild\Bin\zip -D -9 C1RibbonPrintPreviewForm.zip *.*

popd
endlocal
