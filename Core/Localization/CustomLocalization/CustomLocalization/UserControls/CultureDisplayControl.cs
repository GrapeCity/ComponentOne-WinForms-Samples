using C1.Win.Input;
using Custom_Localization.UserControls.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Custom_Localization.CustomControls
{
    public partial class CultureDisplayControl : UserControl
    {

        #region Variables
        Color defaultColor = Color.WhiteSmoke;
        Color selectedColor = Color.LightGray;
        C1Button selectedButton = null;
        bool _isOverrideCultureVisible = false; 

        List<CultureInfo> _preDefinedCultures;
        List<CultureInfo> _customAddedCultures;
        List<CultureInfo> _overrideCultures;

        #endregion Variables

        /// <summary>
        /// Event is Raised when the Selected Items Changes
        /// </summary>
        public event EventHandler<CultureChangedEventArgs>? SelectedCultureChanged;

        /// <summary>
        /// Represents a customizable list of cultures used for localization or UI behavior.
        /// This property is visible in design-time tools and serialized by the designer.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<CultureInfo> CustomAddedCulture
        {
            get => _customAddedCultures;
            set
            {
                _customAddedCultures = value ?? new List<CultureInfo>();
                PopulateCustomCultures();
            }
        }

        /// <summary>
        /// Represents a predefined list of cultures available for selection or fallback.
        /// This property is visible in design-time tools and serialized by the designer.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<CultureInfo> PreDefinedCulture
        {
            get => _preDefinedCultures;
            set
            {
                _preDefinedCultures = value ?? new List<CultureInfo>();
                PopulatePredefinedCultures();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]  
        public List<CultureInfo> OverrideCultures
        {
            get => _overrideCultures;
            set
            {
                _overrideCultures = value ?? new List<CultureInfo>();
                PopulateOverrideCultures();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsOverrideCultureVisible
        {
            get => _isOverrideCultureVisible;
            set
            {
                _isOverrideCultureVisible = value;
                ToggleOverridePanelVisibility();

            }
        }

        // for the three string 
        [Browsable(true)]   
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PreDefinedCultureHeaderText
        {
            get => preDefinedCultureLabel.Text;
            set
            {
                preDefinedCultureLabel.Text = value;
            }
        }

        // for the three string
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CustomAddedCultureHeaderText
        {
            get => customAddedCultureLabel.Text;
            set
            {
                customAddedCultureLabel.Text = value;
            }
        }

        // for the three string
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string OverrideCultureHeaderText
        {
            get => overrideCultureLabel.Text;
            set
            {
                overrideCultureLabel.Text = value;
            }
        }

        public CultureDisplayControl()
        {
            InitializeComponent();
            panel2.Visible = _isOverrideCultureVisible;

        }

        private void ToggleOverridePanelVisibility()
        {
            panel2.Visible = _isOverrideCultureVisible;
        }

        // style for the buttons
        private C1Button GenerateButton(CultureInfo cultureName)
        {
            var cultureButton = new C1Button
            {
                AutoSize = true,
                Text = cultureName.NativeName,
                BackColor = defaultColor,
                ForeColor = Color.Black,
                Tag = cultureName,
                Margin = new Padding(10),
                Styles = {
                    Hot =
                    {
                        BackColor = Color.LightGray,
                        BorderColor = Color.DarkGray
                    },
                    HotPressed =
                    {
                        BackColor = Color.LightGray,
                        BorderColor = Color.DarkGray
                    }
                }

            };
            cultureButton.Click += CultureButton_Click;
            return cultureButton;
        }

        private void CultureButton_Click(object? sender, EventArgs e)
        {
            var clickedButton = sender as C1Button;

            if (selectedButton != null)
            {
                selectedButton.BackColor = defaultColor;
            }
            clickedButton.BackColor = selectedColor;
            selectedButton = clickedButton;

            var selectedCulture = clickedButton?.Tag as CultureInfo;


            if (selectedCulture != null) {
                SelectedCultureChanged?.Invoke(
                    this, 
                    new CultureChangedEventArgs(selectedCulture)
                );
            }
        }

        private void PopulateCustomCultures()
        {
            customAddedCulturePanel.Controls.Clear();

            if (_customAddedCultures == null)
                return;

            foreach (var culture in _customAddedCultures)
            {
                var btn = GenerateButton(culture);
                customAddedCulturePanel.Controls.Add(btn);
            }
        }

        private void PopulatePredefinedCultures()
        {
            preSupportedCulturePanel.Controls.Clear();

            if (_preDefinedCultures == null)
                return;

            foreach (var culture in _preDefinedCultures)
            {
                var btn = GenerateButton(culture);
                preSupportedCulturePanel.Controls.Add(btn);
            }
        }

        private void PopulateOverrideCultures()
        {
            overrideCulturePanel.Controls.Clear();
            if(_overrideCultures == null)
                return; 
            foreach(var culture in _overrideCultures)
            {
                var btn = GenerateButton(culture);
                overrideCulturePanel.Controls.Add(btn); 
            }
        }

    }
}
