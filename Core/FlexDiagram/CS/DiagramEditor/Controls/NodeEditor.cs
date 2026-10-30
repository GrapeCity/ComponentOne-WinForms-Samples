using C1.Chart;
using C1.Diagram;
using C1.Win.Diagram;

namespace DiagramEditor.Controls;

public class NodeEditor : ElementEditor<Node>
{
    private TextBox? txtText;

    private NumericUpDown? numThickness;

    private (Panel Swatch, Label Hex) fillField;
    private (Panel Swatch, Label Hex) strokeField;
    private (Panel Swatch, Label Hex) textColorField;

    private ComboBox? comboBoxShape;

    private Button? buttonFont;

    private Panel? imagePanel;

    private ComboBox? comboBoxDirection;
    private Label? labelDirection;

    private ComboBox? comboBoxOrder;
    private Label? labelOrder;

    public NodeEditor()
    {
        BuildEmptyState("Node");

        Controls.Add(body);
        Controls.Add(lblEmpty);

        RefreshFromTarget();
    }

    // --------------------------------------------------------------- build

    protected override void BuildBody()
    {
        base.BuildBody();

        AddSectionHeader(body, "Text");

        txtText = AddTextField(body, () => Target?.Text, v => Target?.Text = v );

        textColorField = AddColorField(body, "Text Color", () => Target!.TitleStyle.StrokeColor, c => Target!.TitleStyle.StrokeColor = c);

        AddSectionHeader(body, "Font");
        buttonFont = AddFontButton(body, () => Target?.Style.Font, (font) => Target.Style.Font = font);

        AddSectionHeader(body, "Shape");
        comboBoxShape = AddComboBox<Shape>(body, () => Target!=null ? Target.Shape : Shape.None, d => Target.Shape = d);

        AddSectionHeader(body, "Fill");
        fillField = AddColorField(body, "Fill Color", () => Target!.Style.FillColor, c => Target!.Style.FillColor = c);

        AddSectionHeader(body, "Line");
        strokeField = AddColorField(body, "Stroke Color", () => Target!.Style.StrokeColor, c => Target!.Style.StrokeColor = c);

        AddFieldLabel(body, "Thickness");
        numThickness = AddNumField(body, v => Target?.Style.StrokeWidth = (float)v);

        AddSectionHeader(body, "Image");
        imagePanel = AddImageEditor(body, () => Target?.TitleImage, v => Target!.TitleImage = v );

        labelDirection = AddFieldLabel(body, "Direction");
        comboBoxDirection = AddComboBox<Direction>(body, () => Target != null ? Target.TitleDirection : Direction.Horizontal, d => Target.TitleDirection = d);
        labelOrder = AddFieldLabel(body, "Order");
        comboBoxOrder = AddComboBox<LabelOrder>(body, () => Target != null ? Target.TitleOrder : LabelOrder.ImageText, d => Target.TitleOrder = d);
    }

    public override void RefreshFromTarget()
    {
        bool hasTarget = HasTarget;
        body.Visible = hasTarget;
        lblEmpty.Visible = !hasTarget;

        var hasImage = hasTarget && Target.TitleImage != null;

        if (hasTarget)
        {
            var s = Target!;
            txtText.Text = Target.Text;

            fillField.Swatch.BackColor = s.Style.FillColor;
            fillField.Hex.Text = ToHex(s.Style.FillColor);

            strokeField.Swatch.BackColor = s.Style.StrokeColor;
            strokeField.Hex.Text = ToHex(s.Style.StrokeColor);

            textColorField.Swatch.BackColor = s.TitleStyle.StrokeColor;
            textColorField.Hex.Text = ToHex(s.TitleStyle.StrokeColor);

            numThickness.Value = (decimal)Math.Clamp(s.Style.StrokeWidth, (float)numThickness.Minimum, (float)numThickness.Maximum);

            comboBoxShape.SelectedIndex = (int)s.Shape;

            var font = Target.Style.Font == null ? ((FlexDiagram)(((INode)Target).Diagram)).Font : Target.Style.Font;
            buttonFont.Font = GetButtonFont(font);
            buttonFont.Text = FontToString(font);

            imagePanel.Invalidate();
        }

        labelDirection.Visible = comboBoxDirection.Visible = labelOrder.Visible = comboBoxOrder.Visible = hasImage;
    }
}