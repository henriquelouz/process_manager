
// This file has been generated by the GUI designer. Do not modify.
namespace process_manager
{
	public partial class ControlPanel
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button btnP2;

		private global::Gtk.Button btnP4;

		private global::Gtk.Button btnP5;

		private global::Gtk.Button btnP6;

		private global::Gtk.Button btnP8;

		private global::Gtk.Button btnP7;

		private global::Gtk.Button btnP1;

		private global::Gtk.Button btnP3;

		private global::Gtk.ProgressBar CPU;

		private global::Gtk.Frame frmQuantum;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.SpinButton quantum;

		private global::Gtk.Label GtkLabel8;

		private global::Gtk.Frame frmRAM;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView RAM;

		private global::Gtk.Label lblRAM;

		private global::Gtk.ProgressBar RAMSpace;

		private global::Gtk.Frame frmSwap;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.TreeView Swap;

		private global::Gtk.Label GtkLabel9;

		private global::Gtk.Button cnclP2;

		private global::Gtk.Button cnclP3;

		private global::Gtk.Button cnclP4;

		private global::Gtk.Button cnclP1;

		private global::Gtk.Button cnclP5;

		private global::Gtk.Button cnclP6;

		private global::Gtk.Button cnclP7;

		private global::Gtk.Button cnclP8;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget process_manager.ControlPanel
			this.WidthRequest = 450;
			this.HeightRequest = 430;
			this.Name = "process_manager.ControlPanel";
			this.Title = global::Mono.Unix.Catalog.GetString("Process Manager");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			// Container child process_manager.ControlPanel.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.WidthRequest = 500;
			this.fixed1.HeightRequest = 500;
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP2 = new global::Gtk.Button();
			global::Gtk.Tooltips w1 = new Gtk.Tooltips();
			w1.SetTip(this.btnP2, "P2\nExecution time: 20s\nSize: 100MB", "P2\nExecution time: 20s\nSize: 100MB");
			this.btnP2.CanFocus = true;
			this.btnP2.Name = "btnP2";
			this.btnP2.UseStock = true;
			this.btnP2.UseUnderline = true;
			this.btnP2.Label = "P2";
			this.fixed1.Add(this.btnP2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP2]));
			w2.X = 36;
			w2.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP4 = new global::Gtk.Button();
			w1.SetTip(this.btnP4, "P4\nExecution time: 22s\nSize: 110MB", "P4\nExecution time: 22s\nSize: 110MB");
			this.btnP4.CanFocus = true;
			this.btnP4.Name = "btnP4";
			this.btnP4.UseStock = true;
			this.btnP4.UseUnderline = true;
			this.btnP4.Label = "P4";
			this.fixed1.Add(this.btnP4);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP4]));
			w3.X = 102;
			w3.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP5 = new global::Gtk.Button();
			w1.SetTip(this.btnP5, "P5\nExecution time: 19s\nSize: 98MB", "P5\nExecution time: 19s\nSize: 98MB");
			this.btnP5.CanFocus = true;
			this.btnP5.Name = "btnP5";
			this.btnP5.UseStock = true;
			this.btnP5.UseUnderline = true;
			this.btnP5.Label = "P5";
			this.fixed1.Add(this.btnP5);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP5]));
			w4.X = 136;
			w4.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP6 = new global::Gtk.Button();
			w1.SetTip(this.btnP6, "P6\nExecution time: 18s\nSize: 93MB", "P6\nExecution time: 18s\nSize: 93MB");
			this.btnP6.CanFocus = true;
			this.btnP6.Name = "btnP6";
			this.btnP6.UseStock = true;
			this.btnP6.UseUnderline = true;
			this.btnP6.Label = "P6";
			this.fixed1.Add(this.btnP6);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP6]));
			w5.X = 169;
			w5.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP8 = new global::Gtk.Button();
			w1.SetTip(this.btnP8, "P8\nExecution time: 26s\nSize: 128MB", "P8\nExecution time: 26s\nSize: 128MB");
			this.btnP8.CanFocus = true;
			this.btnP8.Name = "btnP8";
			this.btnP8.UseStock = true;
			this.btnP8.UseUnderline = true;
			this.btnP8.Label = "P8";
			this.fixed1.Add(this.btnP8);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP8]));
			w6.X = 234;
			w6.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP7 = new global::Gtk.Button();
			w1.SetTip(this.btnP7, "P7\nExecution time: 25s\nSize: 125MB", "P7\nExecution time: 25s\nSize: 125MB");
			this.btnP7.CanFocus = true;
			this.btnP7.Name = "btnP7";
			this.btnP7.UseStock = true;
			this.btnP7.UseUnderline = true;
			this.btnP7.Label = "P7";
			this.fixed1.Add(this.btnP7);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP7]));
			w7.X = 201;
			w7.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP1 = new global::Gtk.Button();
			w1.SetTip(this.btnP1, "P1\nExecution time: 23s\nSize: 118MB", "P1\nExecution time: 23s\nSize: 118MB");
			this.btnP1.CanFocus = true;
			this.btnP1.Name = "btnP1";
			this.btnP1.UseStock = true;
			this.btnP1.UseUnderline = true;
			this.btnP1.Label = "P1";
			this.fixed1.Add(this.btnP1);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP1]));
			w8.X = 3;
			w8.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnP3 = new global::Gtk.Button();
			w1.SetTip(this.btnP3, "P3\nExecution time: 21s\nSize: 105MB", "P3\nExecution time: 21s\nSize: 105MB");
			this.btnP3.CanFocus = true;
			this.btnP3.Name = "btnP3";
			this.btnP3.UseStock = true;
			this.btnP3.UseUnderline = true;
			this.btnP3.Label = "P3";
			this.fixed1.Add(this.btnP3);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnP3]));
			w9.X = 69;
			w9.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.CPU = new global::Gtk.ProgressBar();
			this.CPU.WidthRequest = 100;
			this.CPU.HeightRequest = 100;
			this.CPU.Name = "CPU";
			this.CPU.Orientation = ((global::Gtk.ProgressBarOrientation)(2));
			this.CPU.Text = global::Mono.Unix.Catalog.GetString("CPU");
			this.fixed1.Add(this.CPU);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.CPU]));
			w10.X = 317;
			w10.Y = 137;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frmQuantum = new global::Gtk.Frame();
			this.frmQuantum.Name = "frmQuantum";
			this.frmQuantum.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frmQuantum.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.quantum = new global::Gtk.SpinButton(0D, 100D, 1D);
			this.quantum.CanFocus = true;
			this.quantum.Name = "quantum";
			this.quantum.Adjustment.PageIncrement = 10D;
			this.quantum.ClimbRate = 1D;
			this.quantum.Numeric = true;
			this.quantum.Value = 10D;
			this.GtkAlignment.Add(this.quantum);
			this.frmQuantum.Add(this.GtkAlignment);
			this.GtkLabel8 = new global::Gtk.Label();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Quantum</b>");
			this.GtkLabel8.UseMarkup = true;
			this.frmQuantum.LabelWidget = this.GtkLabel8;
			this.fixed1.Add(this.frmQuantum);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frmQuantum]));
			w13.X = 342;
			w13.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frmRAM = new global::Gtk.Frame();
			this.frmRAM.Name = "frmRAM";
			this.frmRAM.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frmRAM.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.RAM = new global::Gtk.TreeView();
			this.RAM.WidthRequest = 200;
			this.RAM.HeightRequest = 209;
			this.RAM.CanFocus = true;
			this.RAM.Name = "RAM";
			this.RAM.EnableSearch = false;
			this.RAM.RulesHint = true;
			this.GtkScrolledWindow.Add(this.RAM);
			this.GtkAlignment1.Add(this.GtkScrolledWindow);
			this.frmRAM.Add(this.GtkAlignment1);
			this.lblRAM = new global::Gtk.Label();
			this.lblRAM.Name = "lblRAM";
			this.lblRAM.LabelProp = global::Mono.Unix.Catalog.GetString("<b>RAM</b>");
			this.lblRAM.UseMarkup = true;
			this.frmRAM.LabelWidget = this.lblRAM;
			this.fixed1.Add(this.frmRAM);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frmRAM]));
			w17.X = 26;
			w17.Y = 57;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.RAMSpace = new global::Gtk.ProgressBar();
			w1.SetTip(this.RAMSpace, "Used Memory", "Used Memory");
			this.RAMSpace.WidthRequest = 202;
			this.RAMSpace.HeightRequest = 15;
			this.RAMSpace.Name = "RAMSpace";
			this.RAMSpace.Text = global::Mono.Unix.Catalog.GetString("0/820 (1024) MB");
			this.RAMSpace.Fraction = 0.2D;
			this.fixed1.Add(this.RAMSpace);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.RAMSpace]));
			w18.X = 40;
			w18.Y = 285;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frmSwap = new global::Gtk.Frame();
			this.frmSwap.Name = "frmSwap";
			this.frmSwap.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frmSwap.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.Swap = new global::Gtk.TreeView();
			this.Swap.WidthRequest = 200;
			this.Swap.HeightRequest = 50;
			this.Swap.CanFocus = true;
			this.Swap.Name = "Swap";
			this.GtkScrolledWindow1.Add(this.Swap);
			this.GtkAlignment2.Add(this.GtkScrolledWindow1);
			this.frmSwap.Add(this.GtkAlignment2);
			this.GtkLabel9 = new global::Gtk.Label();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Swap Area</b>");
			this.GtkLabel9.UseMarkup = true;
			this.frmSwap.LabelWidget = this.GtkLabel9;
			this.fixed1.Add(this.frmSwap);
			global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.frmSwap]));
			w22.X = 26;
			w22.Y = 317;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP2 = new global::Gtk.Button();
			w1.SetTip(this.cnclP2, "P2\nExecution time: 20s\nSize: 100MB", "P2\nExecution time: 20s\nSize: 100MB");
			this.cnclP2.CanFocus = true;
			this.cnclP2.Name = "cnclP2";
			this.cnclP2.UseUnderline = true;
			global::Gtk.Image w23 = new global::Gtk.Image();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP2.Image = w23;
			this.fixed1.Add(this.cnclP2);
			global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP2]));
			w24.X = 36;
			w24.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP3 = new global::Gtk.Button();
			w1.SetTip(this.cnclP3, "P3\nExecution time: 21s\nSize: 105MB", "P3\nExecution time: 21s\nSize: 105MB");
			this.cnclP3.CanFocus = true;
			this.cnclP3.Name = "cnclP3";
			this.cnclP3.UseUnderline = true;
			global::Gtk.Image w25 = new global::Gtk.Image();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP3.Image = w25;
			this.fixed1.Add(this.cnclP3);
			global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP3]));
			w26.X = 69;
			w26.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP4 = new global::Gtk.Button();
			w1.SetTip(this.cnclP4, "P4\nExecution time: 22s\nSize: 110MB", "P4\nExecution time: 22s\nSize: 110MB");
			this.cnclP4.CanFocus = true;
			this.cnclP4.Name = "cnclP4";
			global::Gtk.Image w27 = new global::Gtk.Image();
			w27.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP4.Image = w27;
			this.fixed1.Add(this.cnclP4);
			global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP4]));
			w28.X = 102;
			w28.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP1 = new global::Gtk.Button();
			w1.SetTip(this.cnclP1, "P1\nExecution time: 23s\nSize: 118MB", "P1\nExecution time: 23s\nSize: 118MB");
			this.cnclP1.CanFocus = true;
			this.cnclP1.Name = "cnclP1";
			global::Gtk.Image w29 = new global::Gtk.Image();
			w29.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP1.Image = w29;
			this.fixed1.Add(this.cnclP1);
			global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP1]));
			w30.X = 3;
			w30.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP5 = new global::Gtk.Button();
			w1.SetTip(this.cnclP5, "P5\nExecution time: 19s\nSize: 98MB", "P5\nExecution time: 19s\nSize: 98MB");
			this.cnclP5.CanFocus = true;
			this.cnclP5.Name = "cnclP5";
			global::Gtk.Image w31 = new global::Gtk.Image();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP5.Image = w31;
			this.fixed1.Add(this.cnclP5);
			global::Gtk.Fixed.FixedChild w32 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP5]));
			w32.X = 136;
			w32.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP6 = new global::Gtk.Button();
			w1.SetTip(this.cnclP6, "P6\nExecution time: 18s\nSize: 93MB", "P6\nExecution time: 18s\nSize: 93MB");
			this.cnclP6.CanFocus = true;
			this.cnclP6.Name = "cnclP6";
			global::Gtk.Image w33 = new global::Gtk.Image();
			w33.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP6.Image = w33;
			this.fixed1.Add(this.cnclP6);
			global::Gtk.Fixed.FixedChild w34 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP6]));
			w34.X = 169;
			w34.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP7 = new global::Gtk.Button();
			w1.SetTip(this.cnclP7, "P7\nExecution time: 25s\nSize: 125MB", "P7\nExecution time: 25s\nSize: 125MB");
			this.cnclP7.CanFocus = true;
			this.cnclP7.Name = "cnclP7";
			global::Gtk.Image w35 = new global::Gtk.Image();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP7.Image = w35;
			this.fixed1.Add(this.cnclP7);
			global::Gtk.Fixed.FixedChild w36 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP7]));
			w36.X = 201;
			w36.Y = 3;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cnclP8 = new global::Gtk.Button();
			w1.SetTip(this.cnclP8, "P8\nExecution time: 26s\nSize: 128MB", "P8\nExecution time: 26s\nSize: 128MB");
			this.cnclP8.CanFocus = true;
			this.cnclP8.Name = "cnclP8";
			global::Gtk.Image w37 = new global::Gtk.Image();
			w37.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.cnclP8.Image = w37;
			this.fixed1.Add(this.cnclP8);
			global::Gtk.Fixed.FixedChild w38 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cnclP8]));
			w38.X = 234;
			w38.Y = 3;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 500;
			this.DefaultHeight = 500;
			this.frmQuantum.Hide();
			this.cnclP2.Hide();
			this.cnclP3.Hide();
			this.cnclP4.Hide();
			this.cnclP1.Hide();
			this.cnclP5.Hide();
			this.cnclP6.Hide();
			this.cnclP7.Hide();
			this.cnclP8.Hide();
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.btnP2.Clicked += new global::System.EventHandler(this.OnBtnP2Clicked);
			this.btnP4.Clicked += new global::System.EventHandler(this.OnBtnP4Clicked);
			this.btnP5.Clicked += new global::System.EventHandler(this.OnBtnP5Clicked);
			this.btnP6.Clicked += new global::System.EventHandler(this.OnBtnP6Clicked);
			this.btnP8.Clicked += new global::System.EventHandler(this.OnBtnP8Clicked);
			this.btnP7.Clicked += new global::System.EventHandler(this.OnBtnP7Clicked);
			this.btnP1.Clicked += new global::System.EventHandler(this.OnBtnP1Clicked);
			this.btnP3.Clicked += new global::System.EventHandler(this.OnBtnP3Clicked);
			this.cnclP2.Clicked += new global::System.EventHandler(this.OnCnclP2Clicked);
			this.cnclP3.Clicked += new global::System.EventHandler(this.OnCnclP3Clicked);
			this.cnclP4.Clicked += new global::System.EventHandler(this.OnCnclP4Clicked);
			this.cnclP1.Clicked += new global::System.EventHandler(this.OnCnclP1Clicked);
			this.cnclP5.Clicked += new global::System.EventHandler(this.OnCnclP5Clicked);
			this.cnclP6.Clicked += new global::System.EventHandler(this.OnCnclP6Clicked);
			this.cnclP7.Clicked += new global::System.EventHandler(this.OnCnclP7Clicked);
			this.cnclP8.Clicked += new global::System.EventHandler(this.OnCnclP8Clicked);
		}
	}
}
