## Thumbnail Tips
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\SuperTooltip\VB\ThumbnailTips)
____
#### Shows how to build tooltips with dynamically generated thumbnail images.
____
The sample monitors the mouse as it moves over a TabControl. When the user moves the mouse over a tab that is not selected, the sample uses the Control.DrawImageToBitmap method to get an image of the tab. 

It then stores the image in the C1SuperTooltip.Images collection and displays it in the tip using an HTML tag that looks like this: 

<img src='res://tabPage'>  