// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using CommandExplorer.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace CommandExplorer.Data
{
    public class MnemonicInfo
    {
        public string Text;
        public Image Image;
    }

    public static class MnemonicInfoDataSource
    {
        public static readonly List<MnemonicInfo> AllItems = [
            new MnemonicInfo { Text = "&Undo", Image = Resources.Undo },
            new MnemonicInfo { Text = "&Redo", Image = Resources.Redo },
            new MnemonicInfo { Text = "Cu&t", Image = Resources.Cut },
            new MnemonicInfo { Text = "&Copy", Image = Resources.Copy },
            new MnemonicInfo { Text = "&Paste", Image = Resources.Paste },
            new MnemonicInfo { Text = "&Address Book", Image = Resources.AddressBook },
            new MnemonicInfo { Text = "Spell Chec&k", Image = Resources.Spelling },
            new MnemonicInfo { Text = "Ne&w", Image = Resources.New },
            new MnemonicInfo { Text = "&Open", Image = Resources.Open },
            new MnemonicInfo { Text = "&Save", Image = Resources.Save },
            new MnemonicInfo { Text = "Sa&ve All", Image = Resources.SaveAll },
            new MnemonicInfo { Text = "Pri&nt", Image = Resources.Print },
            new MnemonicInfo { Text = "&Bold", Image = Resources.Bold },
            new MnemonicInfo { Text = "&Italic", Image = Resources.Italic },
            new MnemonicInfo { Text = "Un&derline", Image = Resources.Underline },
            new MnemonicInfo { Text = "Strikethrou&gh", Image = Resources.Strikethrough },
            new MnemonicInfo { Text = "Align Text &Left", Image = Resources.AlignTextLeft },
            new MnemonicInfo { Text = "Align Text C&enter", Image = Resources.AlignTextCenter },
            new MnemonicInfo { Text = "Align Text &Right", Image = Resources.AlignTextRight },
            new MnemonicInfo { Text = "&Justify", Image = Resources.AlignTextJustify },
        ];
    }
}
