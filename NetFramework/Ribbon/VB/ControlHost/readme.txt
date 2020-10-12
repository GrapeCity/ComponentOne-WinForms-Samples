ControlHost
-----------------------------
This sample shows how to embed an arbitrary control into C1Ribbon using the RibbonControlHost component.

In this sample you can find the following elements on the C1Ribbon control:

AxWebBrowserHost - contains the WebBrowser ActiveX element
CheckedListBoxHost - contains the CheckedListBox control
ColorEditorHost - uses the Color UITypeEditor to show a dropdown where users can pick colors
FontEditorHost - uses the font UITypeEditor to show a form where users can choose fonts
NumericUpDownHost - contains the NumericUpDown control
PictureBoxHost - contains the PictureBox element

All RibbonControlHost-based components are in a separate ControlHostLib dll project
to avoid the well-known issue in VS designer: no property of the form or the C1Ribbon
containing a RibbonControlHost can be changed when the application is debugged once.
