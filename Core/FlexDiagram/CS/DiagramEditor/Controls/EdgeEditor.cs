using C1.Chart;
using C1.Win.Diagram;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiagramEditor.Controls;

public class EdgeEditor : ElementEditor<Edge>
{
    private ComboBox? comboBoxSourceArrow;
    private ComboBox? comboBoxTargetArrow;

    private Label? label;

    private NumericUpDown? numThickness;

    private TextBox? textBox;

    private (Panel Swatch, Label Hex) strokeField;

    public EdgeEditor()
    {
        BuildEmptyState("Edge");

        Controls.Add(body);
        Controls.Add(lblEmpty);

        RefreshFromTarget();
    }

    protected override void BuildBody()
    {
        base.BuildBody();

        label = AddFieldLabel(body, "");

        AddSectionHeader(body, "Text");
        textBox = AddTextField(body, () => Target?.Text, v => Target?.Text = v);

        AddSectionHeader(body, "Source Arrow");
        comboBoxSourceArrow = AddComboBox<ArrowStyle>(body, () => Target != null ? Target.SourceArrow : ArrowStyle.None, d => Target.SourceArrow = d);

        AddSectionHeader(body, "Target Arrow");
        comboBoxTargetArrow = AddComboBox<ArrowStyle>(body, () => Target != null ? Target.TargetArrow : ArrowStyle.None, d => Target.TargetArrow = d);

        AddSectionHeader(body, "Line");
        strokeField = AddColorField(body, "Stroke Color", () => Target!.Style.StrokeColor, c => Target!.Style.StrokeColor = c);

        AddFieldLabel(body, "Thickness");
        numThickness = AddNumField(body, v => Target?.Style.StrokeWidth = (float)v);
    }

    public override void RefreshFromTarget()
    {
        bool hasTarget = HasTarget;
        body.Visible = hasTarget;
        lblEmpty.Visible = !hasTarget;

        if (hasTarget)
        {
            comboBoxSourceArrow.SelectedIndex = (int)Target!.SourceArrow;
            comboBoxTargetArrow.SelectedIndex = (int)Target!.TargetArrow;

            label.Text = Target.ToString();

            textBox.Text = Target.Text;
            numThickness.Value = (decimal)Target.Style.StrokeWidth;

            strokeField.Swatch.BackColor = Target.Style.StrokeColor;
            strokeField.Hex.Text = ToHex(Target.Style.StrokeColor);
        }

    }
}
