using System;
using System.Windows.Forms;
using TouchToolkitDemo.C1ZoomPages.Help_Forms;
using System.Threading.Tasks;

namespace TouchToolkitDemo.C1ZoomPages
{
    public partial class ControlBarDemo : DemoBase
    {
        public ControlBarDemo()
        {
            InitializeComponent();

            this.Title = "ControlBar";
            this.Description = @"ControlBar can provide a floating, translucent window for form.
- ControlBar provides built-in actions, the map demo shows how to use the built-in actions.
- Of course, customize the action is simple, keyboard demo shows how to costomize the actions.";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var splash = new SplashForm();
            var splashTask = ShowDialogAsync(splash);

            var form = await CreateMapFormAsync();

            splash.Close();
            splash.Dispose();
            await splashTask;

            form.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new InputFormforControlBar();
            form.Show();
        }

        private async Task<Form> CreateMapFormAsync()
        {
            Form form = null;
            await Task.Run(() => form = new MapViewFormForControlBar());
            return form;
        }

        private async Task<DialogResult> ShowDialogAsync(Form form)
        {
            await Task.Yield();
            if (form.IsDisposed)
                return DialogResult.OK;
            return form.ShowDialog();
        }
    }
}
