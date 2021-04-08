using System;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.WinForms;

using C1.Win.C1Ribbon;

namespace C1.Win.C1Ribbon.CAB
{
    /// <summary>
    /// Defines an abstract CAB application which shows a shell based on a Form that uses C1Ribbon components.
    /// </summary>
    /// <typeparam name="TWorkItem">The type of the root application work item.</typeparam>
    /// <typeparam name="TShell">The type of the form for the shell to use. Should be a C1RibbonForm.</typeparam>
    public class C1RibbonFormApplication<TWorkItem, TShell> : WindowsFormsApplication<TWorkItem, TShell>
        where TWorkItem : WorkItem, new()
        where TShell : C1RibbonForm
    {
        /// <summary>
        /// Used to start a message pump using the specified shell form.
        /// </summary>
        protected override void Start()
        {
            Application.Run(Shell);
        }

        /// <summary>
        /// May be overridden in derived classes to perform activities just after the shell
        /// has been created.
        /// </summary>
        protected override void AfterShellCreated()
        {
            base.AfterShellCreated();
            RegisterCommandAdapters();
            RegisterUIElementAdapterFactories();
        }

        private void RegisterCommandAdapters()
        {
            ICommandAdapterMapService mapService = RootWorkItem.Services.Get<ICommandAdapterMapService>();
            mapService.Register(typeof(RibbonItem), typeof(RibbonItemCommandAdapter));
            mapService.Register(typeof(RibbonGroup), typeof(RibbonGroupCommandAdapter));
            mapService.Register(typeof(RibbonTab), typeof(RibbonTabCommandAdapter));
            mapService.Register(typeof(RibbonContextualTabGroup), typeof(RibbonTabGroupCommandAdapter));
        }

        private void RegisterUIElementAdapterFactories()
        {
            IUIElementAdapterFactoryCatalog catalog = RootWorkItem.Services.Get<IUIElementAdapterFactoryCatalog>();
            catalog.RegisterFactory(new RibbonUIAdapterFactory());
        }
    }
}
