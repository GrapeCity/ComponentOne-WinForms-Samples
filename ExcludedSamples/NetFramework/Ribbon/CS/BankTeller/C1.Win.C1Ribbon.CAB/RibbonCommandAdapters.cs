using System;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI.Utility;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.Commands;

using C1.Win.C1Ribbon;

namespace C1.Win.C1Ribbon.CAB
{
    #region RibbonItemCommandAdapter

    /// <summary>
    /// An <see cref="EventCommandAdapter{T}"/> that updates a <see cref="RibbonItem"/> based on the changes to 
    /// the <see cref="Command.Status"/> property value.
    /// </summary>
    public class RibbonItemCommandAdapter : EventCommandAdapter<RibbonItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonItemCommandAdapter"/> class
        /// </summary>
        public RibbonItemCommandAdapter()
            : base()
        {
        }

        /// <summary>
        /// Initializes the adapter with the given <see cref="RibbonItem"/>.
        /// </summary>
        public RibbonItemCommandAdapter(RibbonItem item, string eventName)
            : base(item, eventName)
        {
        }

        /// <summary>
        /// Handles the changes in the <see cref="Command"/> by refreshing 
        /// the <see cref="RibbonItem.Enabled"/> property.
        /// </summary>
        protected override void OnCommandChanged(Command command)
        {
            base.OnCommandChanged(command);

            foreach (KeyValuePair<RibbonItem, List<string>> pair in Invokers)
            {
                pair.Key.Enabled = (command.Status == CommandStatus.Enabled);
                pair.Key.Visible = (command.Status != CommandStatus.Unavailable);
            }
        }
    }

    #endregion

    #region RibbonGroupCommandAdapter

    /// <summary>
    /// An <see cref="EventCommandAdapter{T}"/> that updates a <see cref="RibbonGroup"/> based on the changes to 
    /// the <see cref="Command.Status"/> property value.
    /// </summary>
    public class RibbonGroupCommandAdapter : EventCommandAdapter<RibbonGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonGroupCommandAdapter"/> class
        /// </summary>
        public RibbonGroupCommandAdapter()
            : base()
        {
        }

        /// <summary>
        /// Initializes the adapter with the given <see cref="RibbonGroup"/>.
        /// </summary>
        public RibbonGroupCommandAdapter(RibbonGroup group, string eventName)
            : base(group, eventName)
        {
        }

        /// <summary>
        /// Handles the changes in the <see cref="Command"/> by refreshing 
        /// the <see cref="RibbonGroup.Enabled"/> property.
        /// </summary>
        protected override void OnCommandChanged(Command command)
        {
            base.OnCommandChanged(command);

            foreach (KeyValuePair<RibbonGroup, List<string>> pair in Invokers)
            {
                pair.Key.Enabled = (command.Status == CommandStatus.Enabled);
                pair.Key.Visible = (command.Status != CommandStatus.Unavailable);
            }
        }
    }

    #endregion

    #region RibbonTabCommandAdapter

    /// <summary>
    /// An <see cref="EventCommandAdapter{T}"/> that updates a <see cref="RibbonTab"/> based on the changes to 
    /// the <see cref="Command.Status"/> property value.
    /// </summary>
    public class RibbonTabCommandAdapter : EventCommandAdapter<RibbonTab>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonTabCommandAdapter"/> class
        /// </summary>
        public RibbonTabCommandAdapter()
            : base()
        {
        }

        /// <summary>
        /// Initializes the adapter with the given <see cref="RibbonTab"/>.
        /// </summary>
        public RibbonTabCommandAdapter(RibbonTab tab, string eventName)
            : base(tab, eventName)
        {
        }

        /// <summary>
        /// Handles the changes in the <see cref="Command"/> by refreshing 
        /// the <see cref="RibbonTab.Enabled"/> property.
        /// </summary>
        protected override void OnCommandChanged(Command command)
        {
            base.OnCommandChanged(command);

            foreach (KeyValuePair<RibbonTab, List<string>> pair in Invokers)
            {
                pair.Key.Enabled = (command.Status == CommandStatus.Enabled);
                pair.Key.Visible = (command.Status != CommandStatus.Unavailable);
            }
        }
    }

    #endregion

    #region RibbonTabGroupCommandAdapter

    /// <summary>
    /// An <see cref="EventCommandAdapter{T}"/> that updates a <see cref="RibbonContextualTabGroup"/> based on the changes to 
    /// the <see cref="Command.Status"/> property value.
    /// </summary>
    public class RibbonTabGroupCommandAdapter : EventCommandAdapter<RibbonContextualTabGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonTabGroupCommandAdapter"/> class
        /// </summary>
        public RibbonTabGroupCommandAdapter()
            : base()
        {
        }

        /// <summary>
        /// Initializes the adapter with the given <see cref="RibbonContextualTabGroup"/>.
        /// </summary>
        public RibbonTabGroupCommandAdapter(RibbonContextualTabGroup tabGroup, string eventName)
            : base(tabGroup, eventName)
        {
        }

        /// <summary>
        /// Handles the changes in the <see cref="Command"/> by refreshing 
        /// the <see cref="RibbonContextualTabGroup.Visible"/> property.
        /// </summary>
        protected override void OnCommandChanged(Command command)
        {
            base.OnCommandChanged(command);

            bool visible = command.Status != CommandStatus.Unavailable;
            bool enabled = command.Status == CommandStatus.Enabled;
            foreach (KeyValuePair<RibbonContextualTabGroup, List<string>> pair in Invokers)
            {
                RibbonContextualTabGroup tabGroup = pair.Key;
                tabGroup.Visible = visible;
                tabGroup.Clickable = enabled;
                foreach (RibbonTab tab in tabGroup.Tabs)
                {
                    tab.Clickable = enabled;
                    tab.Enabled = enabled;
                }
            }
        }
    }

    #endregion
}
