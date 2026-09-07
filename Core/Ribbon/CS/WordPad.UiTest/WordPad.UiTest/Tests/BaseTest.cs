// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using WordPad.UiTest.MainApplication;

namespace WordPad.UiTest.Tests
{
    public abstract class BaseTest
    {
        protected MainApp MainApp;
        protected Window Window;

        [SetUp]
        public void Setup()
        {
            MainApp = new MainApp();
            MainApp.Initialize();
            Window = MainApp.Window;
        }

        [TearDown]
        public void Cleanup()
        {
            MainApp.Dispose();
        }
    }
}
