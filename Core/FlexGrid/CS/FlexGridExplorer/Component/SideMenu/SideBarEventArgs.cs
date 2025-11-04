// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace FlexGridExplorer.Component.SideMenu
{
    public class SideBarEventArgs : EventArgs
    {
        public ItemInfo SelectedSample
        { get; private set; }
        public SideBarEventArgs(ItemInfo sample)
        {
            this.SelectedSample = sample;
        }
    }
}
