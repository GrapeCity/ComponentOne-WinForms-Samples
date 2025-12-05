// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Input;
using MultiSelectExplorer.Properties;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Event
{
    public partial class EventControl : UserControl
    {
        private readonly Dictionary<string, EventCounter> _eventCounters;
        private readonly FlowPanelEventLogger _eventLogger;

        public EventControl()
        {
            InitializeComponent();
            InitializeLocalizedText();
         
            // Initialize services
            _eventLogger = new FlowPanelEventLogger(flowLayoutPanel1);
            _eventCounters = new Dictionary<string, EventCounter>();

            // Bind events
            _multiSelect.DropDownButtonClick += (_, __) => HandleEvent(Resources.DropDownButtonClickEvent, lblDropDownBtnClickEventCount, Resources.DropDownButtonClickDesc);
            _multiSelect.DropDownOpening += (_, __) => HandleEvent(Resources.DropDownOpeningEvent, lblDropDownOpeningEventCount, Resources.DropDownOpeningDesc);
            _multiSelect.DropDownOpened += (_, __) => HandleEvent(Resources.DropDownOpenedEvent, lblDropDownOpenedEventCount, Resources.DropDownOpenedDesc);
            _multiSelect.DropDownClosed += (_, __) => HandleEvent(Resources.DropDownClosedEvent, lblDropdownClosedEventCount, Resources.DropDownClosedDesc);
            _multiSelect.SelectionChanged += (_, __) => HandleEvent(Resources.SelectionChangedEvent, lblSelectionMadeEventCount, Resources.SelectionChangedDesc);
            _multiSelect.TextChanged += (_, __) => HandleEvent(Resources.TextChangedEvent, lblTextChangedEventCount, Resources.TextChangedDesc);

            btnClearEventLog.Click += (_, __) => flowLayoutPanel1.Controls.Clear();
        }
        private void InitializeLocalizedText()
        {
            // Initialize MultiSelect
            _multiSelect.Items.AddRange(Resources.ProgrammingLanguages.Split(','));
            lblEventLogTitle.Text = Resources.EventLogTitle;
            btnClearEventLog.Text = Resources.ClearEventLog;
            _multiSelect.Placeholder = Resources.SelectTeamMemberValue;
            lblDropDownBtnClickEventName.Text = Resources.DropDownButtonClickEvent;
            lblDropDownOpeningEventName.Text = Resources.DropDownOpeningEvent;
            lblDropDownOpenedEventName.Text = Resources.DropDownOpenedEvent;
            lblDropdownClosedEventName.Text = Resources.DropDownClosedEvent;
            lblSelectionMadeEventName.Text = Resources.SelectionChangedEvent;
            lblTextChangedEventName.Text = Resources.TextChangedEvent;
        }

        private void HandleEvent(string eventName, C1Label counterLabel, string description)
        {
            if (!_eventCounters.TryGetValue(eventName, out EventCounter counter))
            {
                counter = new EventCounter(eventName);
                _eventCounters[eventName] = counter;
            }

            counter.Increment();
            counterLabel.Text = counter.Count.ToString();

            _eventLogger.Log(eventName, description, counter.Count);
        }
    }
}
