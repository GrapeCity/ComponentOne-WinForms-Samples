// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace FlexGridExplorer.Component.SideMenu
{
    public class StackNodeEventArgs : EventArgs
    {
        public StackNodeControl Node { get; private set; }

        public StackNodeEventArgs(StackNodeControl node)
        {
            this.Node = node;
        }
    }
}
