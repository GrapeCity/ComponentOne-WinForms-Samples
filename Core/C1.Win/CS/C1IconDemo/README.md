## C1IconDemo
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/Core\C1.Win\CS\C1IconDemo)
____
#### This sample demonstrates how to use C1Icon to display bitmap, symbolic or vector images.
____
C1Icon is a series of classes which allow specifying monochromatic icons that can be tinted and resized. These icons are thought to be used internally in the controls as well as allowing customers to specify different icons through the api of the controls. The possible sources are Fonts, Vectors (Path or SVG) and Images. 

This sample displays Vector, Font and Bitmap icons in a separate views. Each view is implemented using C1.Framework XView control and elements inherited from the IconElement element. You can switch between views and change icon or application properties to see how it all works. Change icon size to compare how resizing works for vector and bitmap icons. 

The new C1Ribbon control uses the set of C1Icon objects to define icons which should be shown in individual Ribbon elements in different element states or different element size. For example, you can specify small symbolic icon for 16x16 element size, bigger png image for 32x32 element size, and optional vector icon to use in HighDPI modes which might require big images of different sizes. 