
// This file has been generated by the GUI designer. Do not modify.
namespace process_manager
{
	public partial class Kind
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button btnRR;

		private global::Gtk.Button btnFCFS;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget process_manager.Kind
			this.Name = "process_manager.Kind";
			this.Title = global::Mono.Unix.Catalog.GetString("Process Manager");
			this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-execute", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			// Container child process_manager.Kind.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnRR = new global::Gtk.Button();
			this.btnRR.WidthRequest = 120;
			this.btnRR.HeightRequest = 120;
			this.btnRR.CanFocus = true;
			this.btnRR.Name = "btnRR";
			this.btnRR.UseUnderline = true;
			this.btnRR.Label = global::Mono.Unix.Catalog.GetString("Round Robin");
			this.fixed1.Add(this.btnRR);
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnFCFS = new global::Gtk.Button();
			this.btnFCFS.WidthRequest = 120;
			this.btnFCFS.HeightRequest = 120;
			this.btnFCFS.CanFocus = true;
			this.btnFCFS.Name = "btnFCFS";
			this.btnFCFS.UseUnderline = true;
			this.btnFCFS.Label = global::Mono.Unix.Catalog.GetString("FCFS");
			this.fixed1.Add(this.btnFCFS);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnFCFS]));
			w2.X = 130;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 250;
			this.DefaultHeight = 120;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.btnRR.Clicked += new global::System.EventHandler(this.OnBtnRRClicked);
			this.btnFCFS.Clicked += new global::System.EventHandler(this.OnBtnFCFSClicked);
		}
	}
}
