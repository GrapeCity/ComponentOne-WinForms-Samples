// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Input;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Event
{
    /// <summary>
    /// Logs events as visual cards inside a FlowLayoutPanel.
    /// </summary>
    public class FlowPanelEventLogger
    {
        private readonly FlowLayoutPanel _panel;

        public FlowPanelEventLogger(FlowLayoutPanel panel)
        {
            _panel = panel ?? throw new ArgumentNullException(nameof(panel));
            _panel.Resize += OnPanelResize;
        }

        public void Log(string eventName, string description, int count)
        {
            var card = CreateCard(eventName, description, count);
            _panel.Controls.Add(card);
            _panel.Controls.SetChildIndex(card, 0); // newest on top
        }

        /// <summary>
        /// Adjusts all event cards' widths when the panel is resized.
        /// </summary>
        private void OnPanelResize(object sender, EventArgs e)
        {
            foreach (Control ctrl in _panel.Controls)
            {
                if (ctrl is Panel card)
                {
                    card.Width = _panel.ClientSize.Width - 25;
                }

            }
        }

        /// <summary>
        /// Creates a styled card panel that visually represents a logged event.
        /// </summary>
        /// <param name="eventName">Event name to display.</param>
        /// <param name="description">Event description to display.</param>
        /// <param name="count">Event occurrence number.</param>
        /// <returns>A <see cref="Panel"/> control representing the event card.</returns>
        private Panel CreateCard(string eventName, string description, int count)
        {
            var card = new Panel
            {
                Width = _panel.ClientSize.Width - 25,
                Height = 110,
                BackColor = SystemColors.ButtonFace,
                Margin = new Padding(5),
                Padding = new Padding(10),
            };

            var title = new C1Label
            {
                Text = $"{eventName} (#{count})",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = SystemColors.ControlDarkDark,
                Dock = DockStyle.Top,
                AutoSize = true
            };

            var desc = new C1Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9),
                ForeColor = SystemColors.ControlDarkDark,
                Dock = DockStyle.Top,
                AutoSize = true
            };

            var timestamp = new C1Label
            {
                Text = DateTime.Now.ToString("HH:mm:ss.fff"),
                Font = new Font("Consolas", 8),
                ForeColor = SystemColors.ControlDarkDark,
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleRight,
                AutoSize = true
            };

            card.Controls.Add(title);
            card.Controls.Add(desc);
            card.Controls.Add(timestamp);

            return card;
        }
    }
}
