using System;
using Gtk;

namespace process_manager
{
    public partial class Kind : Gtk.Window
    {
        public Kind() : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
        {
            Application.Quit();
            args.RetVal = true;
        }

        protected void OnBtnRRClicked(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel('R');
            this.Hide();
            cp.Show();
        }

        protected void OnBtnFCFSClicked(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel('F');
            this.Hide();
            cp.Show();
        }
    }
}
