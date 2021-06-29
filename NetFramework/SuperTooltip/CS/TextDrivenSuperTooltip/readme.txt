TextDrivenSuperTooltip
------------------------------------------------------------
Shows how you can load SuperTooltips from an XML file at run time.

The sample loads an XML resource containing component names and tooltips, then assigns the tooltips to controls on the form.

This technique is useful when the tooltips are authored by someone other than the programmer.
The developer would create the initial XML file, send it to the documentation team, and plug the revised version back into the project later.

This is similar to setting the Form's Localizable property to true and asking the help authors to use a resource editor to modify the tooltip strings.
The advantage of the approach illustrated in the sample is that the help author only edits the tooltip strings and nothing else on the form.