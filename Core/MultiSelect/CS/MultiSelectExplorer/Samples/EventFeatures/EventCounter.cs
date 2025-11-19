// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace MultiSelectExplorer.Samples.Event
{
    internal class EventCounter
    {
        public string Name { get; }
        public int Count { get; private set; }

        public EventCounter(string name)
        {
            Name = name;
            Count = 0;
        }

        public void Increment() => Count++;
    }
}
