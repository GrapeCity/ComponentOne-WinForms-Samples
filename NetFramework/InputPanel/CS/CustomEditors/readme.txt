CustomEditors
-----------------------------
This sample shows how to embed an arbitrary control into C1InputPanel using the InputControlHost component.

There are two components based on InputControlHost: ColorEditorHost and FontEditorHost.
They can be saved to XML and loaded from XML at runtime. ColorEditorHost is based on the standard Color UITypeEditor.
It shows a form where the users can pick the color. FontEditorHost hosts the standard Font UITypeEditor and shows a form where the user can select the font.