using System;
using Bingo;
using Gtk;


public partial class MainWindow : Gtk.Window
{
    Bombo bombo = new Bombo();
    Panel panel;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        panel = new Panel(vbox1);
        /*Bombo bombo = new Bombo();
        /*BJugar.Clicked += delegate
        {
            int numero = Bombo.sacarBola();
        };*/
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void OnBJugarClicked(object sender, EventArgs e)
    {
        int numero = bombo.sacarBola();
        panel.Marcar(numero);       
    }

}

