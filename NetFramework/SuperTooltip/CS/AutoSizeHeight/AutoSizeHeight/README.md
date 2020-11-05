## AutoSizeHeight
#### [Download as zip](https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\SuperTooltip\CS\AutoSizeHeight\AutoSizeHeight)
____
#### Shows how you can create a C1SuperLabel that automatically adjusts its height to fit the content.
____
The AutoSize property on the C1SuperLabel works just like AutoSize on a regular label. It adjusts the Width and Height of the control to fit the content. Unless the control Text has line breaks, this cause the control to render as a single line. 

If you would like the control to adjust its height and wrap automatically and based on its width, you can use the Measure method to determine the required height, then set the control height to that value. This sample does that using this code: 

```
    public Form1()
    {
        InitializeComponent();
        _superLabel.Paint += _superLabel_UpdateHeight;
    }

    void _superLabel_UpdateHeight(object sender, EventArgs e)
    {
        var lbl = sender as C1.Win.C1SuperTooltip.C1SuperLabel;
        var sz = lbl.Measure(lbl.Width - lbl.Padding.Left - lbl.Padding.Right);
        lbl.Height = sz.Height + lbl.Padding.Top + lbl.Padding.Bottom;
    }
```
