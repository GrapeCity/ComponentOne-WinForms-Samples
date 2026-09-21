using DiagramEditor.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;
using System.Xml.Linq;

namespace DiagramEditor.Controls;

public class ElementEditor<T> : UserControl
{
    T? _target;
    protected const int FieldWidth = 188;
    protected Padding FieldMargin = new Padding(0, 2, 0, 12);

    protected readonly FlowLayoutPanel body = new();
    protected readonly Label lblEmpty = new();

    public ElementEditor()
    {
        BackColor = AppStyles.PanelBackColor;
        Dock = DockStyle.Fill;
        Padding = new Padding(12);
        AutoScroll = true;

        BuildBody();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public T? Target
    {
        get => _target;
        set
        {
            if (ReferenceEquals(_target, value)) 
                return;
            _target = value;
            RefreshFromTarget();
        }
    }

    virtual protected void BuildBody()
    {
        body.Dock = DockStyle.Top;
        body.FlowDirection = FlowDirection.TopDown;
        body.WrapContents = false;
        body.AutoSize = true;
    }

    virtual protected void BuildEmptyState(string name)
    {
        lblEmpty.Dock = DockStyle.Top;
        lblEmpty.Height = 60;
        lblEmpty.Text = $"Select a {name} to edit its properties.";
        lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
        lblEmpty.ForeColor = AppStyles.LabelLightColor;
        lblEmpty.Font = AppStyles.ItalicFont;
    }

    virtual public void RefreshFromTarget()
    { 
    }

    protected static Label AddFieldLabel(FlowLayoutPanel flow, string text)
    {
        var label = new Label 
        {
            Text = text,
            AutoSize = true,
            Margin = new Padding(0, 4, 0, 2),
            Font = AppStyles.Font,
            ForeColor = AppStyles.LabelColor
        };

        flow.Controls.Add(label);

        return label;
    }

    protected static void AddSectionHeader(FlowLayoutPanel flow, string title)
    {
        flow.Controls.Add(new Label
        {
            Text = title,
            AutoSize = true,
            Margin = new Padding(0, flow.Controls.Count == 0 ? 0 : 10, 0, 4),
            Font = AppStyles.BoldFont,
            ForeColor = AppStyles.HeaderColor
        });
    }

    protected (Panel Swatch, Label Hex) AddColorField(FlowLayoutPanel flow, string label, Func<Color> getColor, Action<Color> setColor)
    {
        AddFieldLabel(flow, label);

        var swatch = new Panel
        {
            Size = new Size(26, 26),
            BorderStyle = BorderStyle.FixedSingle,
            Margin = new Padding(0),
            Cursor = Cursors.Hand
        };

        var hex = new Label
        {
            AutoSize = true,
            Margin = new Padding(8, 6, 0, 0),
            Font = new Font("Consolas", 8.5f),
            ForeColor = Color.FromArgb(0x70, 0x70, 0x70),
            Cursor = Cursors.Hand
        };

        void OpenPicker()
        {
            if ( !HasTarget || !swatch.Enabled) return;
            IWin32Window owner = (IWin32Window?)FindForm() ?? this;
            var popup = new ColorPickerPopup(getColor(), owner);
            popup.ColorPicked += (_, color) =>
            {
                setColor(color);
                swatch.BackColor = color;
                hex.Text = ToHex(color);
            };
            popup.Show(swatch, new Point(0, swatch.Height + 2));
        }

        swatch.Click += (_, _) => OpenPicker();
        hex.Click += (_, _) => OpenPicker();

        var row = new FlowLayoutPanel
        {
            AutoSize = true,
            WrapContents = false,
            FlowDirection = FlowDirection.LeftToRight,
            Margin = FieldMargin
        };
        row.Controls.Add(swatch);
        row.Controls.Add(hex);
        flow.Controls.Add(row);

        return (swatch, hex);
    }

    protected static string ToHex(Color c) => c.IsEmpty ? "Auto" : $"#{c.R:X2}{c.G:X2}{c.B:X2}";

    protected ComboBox AddComboBox<TEnum>(Panel panel, Func<TEnum> getValue, Action<TEnum> setValue) where TEnum : struct, Enum
    {
        var comboBox = new ComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Width = FieldWidth,
            Margin = FieldMargin
        };

        var values = Enum.GetValues<TEnum>();
        comboBox.Items.AddRange(values.Cast<object>().ToArray());
        comboBox.SelectedIndex = values.IndexOf(getValue());

        comboBox.SelectedValueChanged += (_, _) => setValue(values[comboBox.SelectedIndex]);
        panel.Controls.Add(comboBox);
        return comboBox;
    }

    protected TextBox AddTextField(Panel panel, Func<string> getValue, Action<string> setValue)
    {
        var textBox = new TextBox()
        {
            Multiline = true,
            Height = 44,
            Width = FieldWidth,
            Margin = FieldMargin
        };
        textBox.TextChanged += (_, _) => setValue(textBox.Text);
        body.Controls.Add(textBox);

        return textBox;
    }

    protected NumericUpDown AddNumField(Panel panel, Action<double> setValue)
    {
        var num = new NumericUpDown()
        {
            Minimum = 0.5m,
            Maximum = 12m,
            Increment = 0.5m,
            DecimalPlaces = 1,
            Width = 70,
            Margin = FieldMargin
        };
        num.ValueChanged += (_, _) => setValue((double)num.Value);
        body.Controls.Add(num);
        return num;
    }

    protected Button AddFontButton(Panel panel, Func<Font> getValue, Action<Font> setValue)
    {
        var button = new Button() 
        { 
            Width = 180, 
            Height = 40, 
            Margin = FieldMargin, 
            TextAlign = ContentAlignment.MiddleCenter,
            Text = getValue()?.ToString()
        };

        button.Click += (_, _) =>
        {
            using var dlg = new FontDialog
            {
                Font = getValue(),
                ShowColor = true,
                FontMustExist = true
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var font = (Font)dlg.Font.Clone();
                button.Font = GetButtonFont(font);
                button.Text = FontToString(font);
                setValue(font);
            }
        };

        panel.Controls.Add(button);
        return button;
    }

    protected Panel AddImageEditor(Panel panel, Func<Image> getValue, Action<Image> setValue)
    {
        var imagePanel = new Panel()
        {
            Size = new Size(FieldWidth, 60),
            Margin = new Padding(0, 2, 0, 6),
            BorderStyle = BorderStyle.FixedSingle,
            Cursor = Cursors.Hand,
        };
        var clearButton = new Button() { Text = "✕", Dock = DockStyle.Right, Width = 32, Height = 32, Visible = getValue() != null };

        imagePanel.Paint += (s,e) => {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.White, imagePanel.ClientRectangle);

            var img = getValue();
            if ( img != null)
            {
                var bounds = RectangleF.Inflate(imagePanel.ClientRectangle, -4, -4);
                ShapeRenderer.DrawImageFit(g, img, bounds);
            }
            else
            {
                using var textBrush = new SolidBrush(Color.FromArgb(0xA0, 0xA0, 0xA0));
                using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Click to choose an image", AppStyles.ItalicFont, textBrush, imagePanel.ClientRectangle, format);
            }

            clearButton.Visible = img != null;
        };
        imagePanel.Click += (_, _) =>
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Choose Node Image",
                Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files|*.*"
            };

            IWin32Window owner = (IWin32Window?)FindForm() ?? this;
            if (dlg.ShowDialog(owner) != DialogResult.OK) return;

            try
            {
                var bytes = File.ReadAllBytes(dlg.FileName);
                setValue( Image.FromStream(new MemoryStream(bytes)));
                imagePanel.Invalidate();
                clearButton.Visible = true;
                RefreshFromTarget();
            }
            catch (Exception ex) when (ex is ArgumentException or IOException or OutOfMemoryException)
            {
                MessageBox.Show(owner, $"Couldn't load that image:\n{ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        };

        clearButton.Click += (_, _) =>
        {
            setValue(null);
            clearButton.Visible = false;
            RefreshFromTarget();
            imagePanel.Invalidate();
        };
        imagePanel.Controls.Add(clearButton);

        panel.Controls.Add(imagePanel);
        return imagePanel;
    }
   

    protected string FontToString(Font font) => $"{font.Name}, {font.SizeInPoints}pt";
    protected Font GetButtonFont(Font font) => new Font(font.FontFamily, 9, font.Style);

    virtual protected bool HasTarget => _target != null;
}