using C1.Diagram;
using C1.Win.Diagram;

namespace DiagramEditor.Controls;

public class DiagramEditor : ElementEditor<FlexDiagram>
{
    private ComboBox? comboBoxDirection;
    private ComboBox? comboBoxEdgeRouting;

    private (Panel Swatch, Label Hex) foregroundColorField;
    private (Panel Swatch, Label Hex) backgroundColorField;


    private Button? buttonFont;

    public DiagramEditor()
    {
        Controls.Add(body);
    }

    protected override void BuildBody()
    {
        base.BuildBody();

        AddSectionHeader(body, "Direction");
        comboBoxDirection = AddComboBox<DiagramDirection>(body, () => Target != null? Target.Direction : DiagramDirection.TopBottom, d => Target.Direction = d);

        AddSectionHeader(body, "Edge Routing");
        comboBoxEdgeRouting = AddComboBox<EdgeRouting>(body, () => Target != null ? Target.EdgeRouting : EdgeRouting.Rectilinear, d => Target.EdgeRouting = d);

        foregroundColorField = AddColorField(body, "Foreground Color", () => Target!.ForeColor, c => Target!.ForeColor = c);
        backgroundColorField = AddColorField(body, "Background Color", () => Target!.BackColor, c => Target!.BackColor = c);

        AddSectionHeader(body, "Font");
        buttonFont = AddFontButton(body, () => Target?.Font, (font) => Target.Font = font);

        var checkBox = new CheckBox() { Text = "Sketch Mode" };
        checkBox.CheckStateChanged += (_, _) => Target?.SketchMode = checkBox.Checked;
        body.Controls.Add(checkBox);

    }


    public override void RefreshFromTarget()
    {
        if (Target != null)
        {
            if(comboBoxDirection.Items.Count > 0)
                comboBoxDirection.SelectedIndex = (int)Target.Direction;

            if (comboBoxEdgeRouting.Items.Count > 0)
                comboBoxEdgeRouting.SelectedIndex = (int)Target.EdgeRouting;

            foregroundColorField.Swatch.BackColor = Target.ForeColor;
            foregroundColorField.Hex.Text = ToHex(Target.ForeColor);

            backgroundColorField.Swatch.BackColor = Target.BackColor;
            backgroundColorField.Hex.Text = ToHex(Target.BackColor);

            var font = Target.Font;
            buttonFont.Font = GetButtonFont(font);
            buttonFont.Text = FontToString(font);
        }
    }
}
