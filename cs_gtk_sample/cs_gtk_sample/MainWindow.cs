using System;
using Gtk;
using System.Diagnostics;

public partial class MainWindow : Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OpenSchopinho(object sender, EventArgs e)
    {
      Process.Start("Image/mylittledog.jpg");
    }
}
