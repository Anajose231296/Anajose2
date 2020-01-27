using System;
using CTabla;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        Panel panel = new Panel(vbox1);

      /*  Table table = new Table(3, 3, true);
        int index = 0;
        for (int row =0; row<3; row++)
            for(int colum = 0; colum <3; colum++)
            {
                index++;
                Button button = new Button();
                table.Attach(button, (uint)colum, (uint)colum + 1, (uint)row, (uint)row + 1);
                //button.Label = "Button";
                button.Label = "BUTTON " + index.ToString();
                button.Clicked += delegate
                {
                    button.ModifyBg(StateType.Normal, new Gdk.Color(150, 148, 250));
                };
            }
        vbox1.Add(table);
        table.ShowAll();
        */




    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
