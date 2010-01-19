
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Core.Gui.Dialogs
{
	public partial class InstrumentationViewerDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label labelProfile;

		private global::Gtk.ComboBox comboProfiles;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonSaveAs;

		private global::Gtk.Button buttonDelete;

		private global::Gtk.HPaned hpaned1;

		private global::Gtk.VBox boxSelector;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeCounters;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Button buttonHideSelector;

		private global::Gtk.HPaned hpaned2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.TreeView listSeries;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button buttonSelect;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VBox boxCharts;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonFlush;

		private global::Gtk.Button buttonZoomOut;

		private global::Gtk.Button buttonZoomIn;

		private global::Gtk.VBox frameCharts;

		private global::Gtk.HScrollbar chartScroller;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Core.Gui.Dialogs.InstrumentationViewerDialog
			this.Name = "MonoDevelop.Core.Gui.Dialogs.InstrumentationViewerDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Core.Gui.Dialogs.InstrumentationViewerDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(9));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelProfile = new global::Gtk.Label ();
			this.labelProfile.Name = "labelProfile";
			this.labelProfile.LabelProp = global::Mono.Unix.Catalog.GetString ("Profile:");
			this.hbox2.Add (this.labelProfile);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelProfile]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboProfiles = global::Gtk.ComboBox.NewText ();
			this.comboProfiles.Name = "comboProfiles";
			this.hbox2.Add (this.comboProfiles);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboProfiles]));
			w3.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			// Container child buttonSave.Gtk.Container+ContainerChild
			global::Gtk.Alignment w4 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w5 = new global::Gtk.HBox ();
			w5.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Button);
			w5.Add (w6);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w8 = new global::Gtk.Label ();
			w5.Add (w8);
			w4.Add (w5);
			this.buttonSave.Add (w4);
			this.hbox2.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSave]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSaveAs = new global::Gtk.Button ();
			this.buttonSaveAs.CanFocus = true;
			this.buttonSaveAs.Name = "buttonSaveAs";
			this.buttonSaveAs.UseUnderline = true;
			// Container child buttonSaveAs.Gtk.Container+ContainerChild
			global::Gtk.Alignment w13 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w14 = new global::Gtk.HBox ();
			w14.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w15 = new global::Gtk.Image ();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save-as", global::Gtk.IconSize.Button);
			w14.Add (w15);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w17 = new global::Gtk.Label ();
			w14.Add (w17);
			w13.Add (w14);
			this.buttonSaveAs.Add (w13);
			this.hbox2.Add (this.buttonSaveAs);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSaveAs]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button ();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			// Container child buttonDelete.Gtk.Container+ContainerChild
			global::Gtk.Alignment w22 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w23 = new global::Gtk.HBox ();
			w23.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w24 = new global::Gtk.Image ();
			w24.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Button);
			w23.Add (w24);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w26 = new global::Gtk.Label ();
			w23.Add (w26);
			w22.Add (w23);
			this.buttonDelete.Add (w22);
			this.hbox2.Add (this.buttonDelete);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonDelete]));
			w30.Position = 4;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 247;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.boxSelector = new global::Gtk.VBox ();
			this.boxSelector.Name = "boxSelector";
			this.boxSelector.Spacing = 6;
			// Container child boxSelector.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeCounters = new global::Gtk.TreeView ();
			this.treeCounters.CanFocus = true;
			this.treeCounters.Name = "treeCounters";
			this.treeCounters.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.treeCounters);
			this.boxSelector.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.boxSelector[this.GtkScrolledWindow]));
			w33.Position = 0;
			// Container child boxSelector.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonHideSelector = new global::Gtk.Button ();
			this.buttonHideSelector.CanFocus = true;
			this.buttonHideSelector.Name = "buttonHideSelector";
			this.buttonHideSelector.UseUnderline = true;
			this.buttonHideSelector.Label = global::Mono.Unix.Catalog.GetString ("Hide Selector");
			this.hbox5.Add (this.buttonHideSelector);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonHideSelector]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			this.boxSelector.Add (this.hbox5);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.boxSelector[this.hbox5]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			this.hpaned1.Add (this.boxSelector);
			global::Gtk.Paned.PanedChild w36 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.boxSelector]));
			w36.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.hpaned2 = new global::Gtk.HPaned ();
			this.hpaned2.CanFocus = true;
			this.hpaned2.Name = "hpaned2";
			this.hpaned2.Position = 129;
			// Container child hpaned2.Gtk.Paned+PanedChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.listSeries = new global::Gtk.TreeView ();
			this.listSeries.CanFocus = true;
			this.listSeries.Name = "listSeries";
			this.GtkScrolledWindow1.Add (this.listSeries);
			this.vbox5.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.GtkScrolledWindow1]));
			w38.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonSelect = new global::Gtk.Button ();
			this.buttonSelect.CanFocus = true;
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.UseUnderline = true;
			this.buttonSelect.Label = global::Mono.Unix.Catalog.GetString ("Select Counters");
			this.hbox6.Add (this.buttonSelect);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonSelect]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			this.vbox5.Add (this.hbox6);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			this.hpaned2.Add (this.vbox5);
			global::Gtk.Paned.PanedChild w41 = ((global::Gtk.Paned.PanedChild)(this.hpaned2[this.vbox5]));
			w41.Resize = false;
			w41.Shrink = false;
			// Container child hpaned2.Gtk.Paned+PanedChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.boxCharts = new global::Gtk.VBox ();
			this.boxCharts.Name = "boxCharts";
			this.boxCharts.Spacing = 6;
			// Container child boxCharts.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonFlush = new global::Gtk.Button ();
			this.buttonFlush.CanFocus = true;
			this.buttonFlush.Name = "buttonFlush";
			this.buttonFlush.UseUnderline = true;
			this.buttonFlush.Label = global::Mono.Unix.Catalog.GetString ("Flush Memory");
			this.hbox3.Add (this.buttonFlush);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonFlush]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonZoomOut = new global::Gtk.Button ();
			this.buttonZoomOut.CanFocus = true;
			this.buttonZoomOut.Name = "buttonZoomOut";
			this.buttonZoomOut.UseUnderline = true;
			// Container child buttonZoomOut.Gtk.Container+ContainerChild
			global::Gtk.Alignment w43 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w44 = new global::Gtk.HBox ();
			w44.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-zoom-out", global::Gtk.IconSize.Menu);
			w44.Add (w45);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w47 = new global::Gtk.Label ();
			w44.Add (w47);
			w43.Add (w44);
			this.buttonZoomOut.Add (w43);
			this.hbox3.Add (this.buttonZoomOut);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonZoomOut]));
			w51.PackType = ((global::Gtk.PackType)(1));
			w51.Position = 1;
			w51.Expand = false;
			w51.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonZoomIn = new global::Gtk.Button ();
			this.buttonZoomIn.CanFocus = true;
			this.buttonZoomIn.Name = "buttonZoomIn";
			this.buttonZoomIn.UseUnderline = true;
			// Container child buttonZoomIn.Gtk.Container+ContainerChild
			global::Gtk.Alignment w52 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w53 = new global::Gtk.HBox ();
			w53.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w54 = new global::Gtk.Image ();
			w54.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-zoom-in", global::Gtk.IconSize.Menu);
			w53.Add (w54);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w56 = new global::Gtk.Label ();
			w53.Add (w56);
			w52.Add (w53);
			this.buttonZoomIn.Add (w52);
			this.hbox3.Add (this.buttonZoomIn);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonZoomIn]));
			w60.PackType = ((global::Gtk.PackType)(1));
			w60.Position = 2;
			w60.Expand = false;
			w60.Fill = false;
			this.boxCharts.Add (this.hbox3);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.boxCharts[this.hbox3]));
			w61.Position = 0;
			w61.Expand = false;
			w61.Fill = false;
			// Container child boxCharts.Gtk.Box+BoxChild
			this.frameCharts = new global::Gtk.VBox ();
			this.frameCharts.Name = "frameCharts";
			this.frameCharts.Spacing = 6;
			this.boxCharts.Add (this.frameCharts);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.boxCharts[this.frameCharts]));
			w62.Position = 1;
			// Container child boxCharts.Gtk.Box+BoxChild
			this.chartScroller = new global::Gtk.HScrollbar (null);
			this.chartScroller.Name = "chartScroller";
			this.chartScroller.Adjustment.Upper = 100;
			this.chartScroller.Adjustment.PageIncrement = 10;
			this.chartScroller.Adjustment.PageSize = 10;
			this.chartScroller.Adjustment.StepIncrement = 1;
			this.boxCharts.Add (this.chartScroller);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.boxCharts[this.chartScroller]));
			w63.Position = 2;
			w63.Expand = false;
			w63.Fill = false;
			this.hbox4.Add (this.boxCharts);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.boxCharts]));
			w64.Position = 0;
			this.hpaned2.Add (this.hbox4);
			this.hpaned1.Add (this.hpaned2);
			this.vbox2.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hpaned1]));
			w67.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w68.Position = 0;
			// Internal child MonoDevelop.Core.Gui.Dialogs.InstrumentationViewerDialog.ActionArea
			global::Gtk.HButtonBox w69 = this.ActionArea;
			w69.Name = "dialog1_ActionArea";
			w69.Spacing = 10;
			w69.BorderWidth = ((uint)(5));
			w69.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-close";
			w69.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w70 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w69[this.buttonOk]));
			w70.Expand = false;
			w70.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 756;
			this.DefaultHeight = 494;
			this.boxSelector.Hide ();
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.comboProfiles.Changed += new global::System.EventHandler (this.OnComboProfilesChanged);
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonSaveAs.Clicked += new global::System.EventHandler (this.OnButtonSaveAsClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
			this.buttonHideSelector.Clicked += new global::System.EventHandler (this.OnButtonHideSelectorClicked);
			this.buttonSelect.Clicked += new global::System.EventHandler (this.OnButtonSelectClicked);
			this.buttonFlush.Clicked += new global::System.EventHandler (this.OnButtonFlushClicked);
			this.buttonZoomIn.Clicked += new global::System.EventHandler (this.OnButtonZoomInClicked);
			this.buttonZoomOut.Clicked += new global::System.EventHandler (this.OnButtonZoomOutClicked);
			this.chartScroller.ValueChanged += new global::System.EventHandler (this.OnChartScrollerValueChanged);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
