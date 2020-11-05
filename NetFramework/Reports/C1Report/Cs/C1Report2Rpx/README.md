## C1Report2Rpx
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\Reports\C1Report\Cs\C1Report2Rpx)
____
#### C1Report to ActiveReport converter (C1Report2Rpx)
____
This sample converts C1Report report definitions in .xml files to ActiveReports section based .rpx report definition files. 

Note that because of different object models and feature sets, not all reports can be converted without loss of functionality. For instance data sorting and grouping, and C1Report scripts are not converted. Warnings are issued for such issues (see Strings.Warnings class for the list). 

Requirements: 

- .NET 4.0 or later; 

- C1.C1Report.4 build 4.6.20131.54625 or later; 

- GrapeCity.ActiveReports.Design.Win.v7 - GrapeCity.ActiveReports.Viewer.Win.v7 

The project also references the following C1 products in order to be able to load report definitions referencing the standard CustomFields assembly: 

- C1.Win.C1Chart.4 - C1.Win.C1SuperTooltip.4 - C1.Win.C1BarCode.4 - C1.WPF.Maps.4 - C1.WPF.4 

If the C1Report definition .xml files being converted do not use custom fields requiring those assemblies, references to them can be removed. (Note that custom fields are NOT converted - the references are only needed to be able to load the report definitions.) 