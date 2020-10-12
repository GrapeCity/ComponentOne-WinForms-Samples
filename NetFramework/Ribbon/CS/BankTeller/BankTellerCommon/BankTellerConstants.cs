using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerCommon
{
	public class UIExtensionConstants
	{
        public static readonly string
            SB_LEFT_PANE_ITEMS = "SBLeftPaneItems",
            SB_RIGHT_PANE_ITEMS = "SBRightPaneItems";
	}

	/// <summary>
	/// Used for creating and handling commands.
	/// These are constants because they are used in attributes.
	/// </summary>
	public class CommandConstants
	{
		public const string
            ACCEPT_CUSTOMER = "AcceptCustomer",
            SELECTION_TAB_GROUP = "SelectionTabGroup",
            SAVE_CHANGES = "SaveChanges",
            EDIT_CUSTOMER = "EditCustomer",
            ADD_COMMENTS = "AddComments",
		    CUSTOMER_MOUSEOVER = "CustomerMouseOver",
            HELP_ABOUT = "HelpAbout",
            FILE_EXIT = "FileExit";
	}

	/// <summary>
	/// Used for handling State.
	/// These are constants because they are used in attributes.
	/// </summary>
	public class StateConstants
	{
		public const string CUSTOMER = "Customer2";
	}

	public class WorkspaceConstants
	{
        public static readonly string
            SHELL_RIBBON = "ribbonWorkspace",
            SHELL_SIDEBAR = "sideBarWorkspace",
		    SHELL_CONTENT = "contentWorkspace",
		    CUSTOMER_TABS = "tabWorkspace";
	}
}
