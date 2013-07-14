
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.FSharp.Gui
{
	public partial class RefactoringParametersDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Entry entry1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label2;
		private global::Gtk.Entry entry2;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Image imageValid;
		private global::Gtk.Image imageError;
		private global::Gtk.Label labelErrorMessage;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonPreview;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.FSharp.Gui.RefactoringParametersDialog
			this.Name = "MonoDevelop.FSharp.Gui.RefactoringParametersDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Rename");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.FSharp.Gui.RefactoringParametersDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.label1.UseUnderline = true;
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.hbox1.Add (this.entry1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entry1]));
			w3.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.label2.UseUnderline = true;
			this.hbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '•';
			this.hbox2.Add (this.entry2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entry2]));
			w6.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.imageValid = new global::Gtk.Image ();
			this.imageValid.Name = "imageValid";
			this.imageValid.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.hbox3.Add (this.imageValid);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.imageValid]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.imageError = new global::Gtk.Image ();
			this.imageError.Name = "imageError";
			this.imageError.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-error", global::Gtk.IconSize.Menu);
			this.hbox3.Add (this.imageError);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.imageError]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelErrorMessage = new global::Gtk.Label ();
			this.labelErrorMessage.Name = "labelErrorMessage";
			this.hbox3.Add (this.labelErrorMessage);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelErrorMessage]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Internal child MonoDevelop.FSharp.Gui.RefactoringParametersDialog.ActionArea
			global::Gtk.HButtonBox w13 = this.ActionArea;
			w13.Name = "dialog1_ActionArea";
			w13.Spacing = 10;
			w13.BorderWidth = ((uint)(5));
			w13.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w13 [this.buttonCancel]));
			w14.Expand = false;
			w14.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPreview = new global::Gtk.Button ();
			this.buttonPreview.CanFocus = true;
			this.buttonPreview.Name = "buttonPreview";
			this.buttonPreview.UseUnderline = true;
			this.buttonPreview.Label = global::Mono.Unix.Catalog.GetString ("_Preview");
			this.AddActionWidget (this.buttonPreview, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w13 [this.buttonPreview]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w13 [this.buttonOk]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 365;
			this.DefaultHeight = 153;
			this.label1.MnemonicWidget = this.entry1;
			this.hbox1.Hide ();
			this.label2.MnemonicWidget = this.entry2;
			this.hbox2.Hide ();
			this.imageError.Hide ();
			this.Show ();
			this.entry1.Changed += new global::System.EventHandler (this.OnEntryChanged);
			this.entry2.Changed += new global::System.EventHandler (this.OnEntryChanged);
			this.buttonPreview.Clicked += new global::System.EventHandler (this.OnPreviewClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnOkClicked);
		}
	}
}
