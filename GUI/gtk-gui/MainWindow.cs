
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action addAction;

	private global::Gtk.Action editAction;

	private global::Gtk.Action deleteAction;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Toolbar toolbar1;

	private global::Gtk.HPaned hpaned2;

	private global::Gtk.VPaned vpaned1;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TreeView treeview4;

	private global::Gtk.Label GtkLabel1;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow2;

	private global::Gtk.TreeView treeview5;

	private global::Gtk.Label GtkLabel2;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.NodeView nodeview2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.addAction = new global::Gtk.Action("addAction", null, null, "gtk-add");
		w1.Add(this.addAction, null);
		this.editAction = new global::Gtk.Action("editAction", null, null, "gtk-edit");
		w1.Add(this.editAction, null);
		this.deleteAction = new global::Gtk.Action("deleteAction", null, null, "gtk-delete");
		w1.Add(this.deleteAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Home");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='addAction' action='addAction'/><toolitem name='editAction' action='editAction'/><toolitem name='deleteAction' action='deleteAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox2.Add(this.toolbar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.toolbar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hpaned2 = new global::Gtk.HPaned();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 204;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.vpaned1 = new global::Gtk.VPaned();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 207;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.treeview4 = new global::Gtk.TreeView();
		this.treeview4.CanFocus = true;
		this.treeview4.Name = "treeview4";
		this.GtkScrolledWindow1.Add(this.treeview4);
		this.GtkAlignment.Add(this.GtkScrolledWindow1);
		this.frame1.Add(this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Configured Drives</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel1;
		this.vpaned1.Add(this.frame1);
		global::Gtk.Paned.PanedChild w6 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.frame1]));
		w6.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.treeview5 = new global::Gtk.TreeView();
		this.treeview5.CanFocus = true;
		this.treeview5.Name = "treeview5";
		this.GtkScrolledWindow2.Add(this.treeview5);
		this.GtkAlignment1.Add(this.GtkScrolledWindow2);
		this.frame2.Add(this.GtkAlignment1);
		this.GtkLabel2 = new global::Gtk.Label();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Drive Properties</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel2;
		this.vpaned1.Add(this.frame2);
		this.hpaned2.Add(this.vpaned1);
		global::Gtk.Paned.PanedChild w11 = ((global::Gtk.Paned.PanedChild)(this.hpaned2[this.vpaned1]));
		w11.Resize = false;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.nodeview2 = new global::Gtk.NodeView();
		this.nodeview2.CanFocus = true;
		this.nodeview2.Name = "nodeview2";
		this.GtkScrolledWindow.Add(this.nodeview2);
		this.hpaned2.Add(this.GtkScrolledWindow);
		this.vbox2.Add(this.hpaned2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hpaned2]));
		w14.Position = 1;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 650;
		this.DefaultHeight = 443;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}