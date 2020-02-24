using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Double resultado;
    String signo;

    int cont_punto = 0;
    int cont_igual = 0;

    double valor_a;
    double valor_b;
    operaciones opera = new operaciones();


    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnSieteClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }

        cont_igual = 0;
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "7");

    }

    protected void OnOchoClicked(object sender, EventArgs e)
    {
        if (cont_igual==1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }

        cont_igual = 0;
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "8");
    }

    protected void OnNueveClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "9");
    }

    protected void OnBarraClicked(object sender, EventArgs e)
    {
        valor_a = Convert.ToDouble(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        signo = "/";
       
    }

    protected void OnBorrarClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(Pantalla.Text.Length - 1, Pantalla.Text.Length);
        string display = Pantalla.Text;
        if (display.Contains("."))

        {

        }
    }

    protected void OnVaciarClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        cont_punto = 0;
    }

    protected void OnCuatroClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;

        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "4");
    }

    protected void OnCincoClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;

        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "5");
    }

    protected void OnSeisClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;

        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "6");
    }

    protected void OnMultiplicarClicked(object sender, EventArgs e)
    {
        cont_punto = 0;
        valor_a = Convert.ToDouble(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        signo = "*";
    }

    protected void OnUnoClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;

        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "1");
    }

    protected void OnDosClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;

        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "2");
    }

    protected void OnTresClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            cont_punto = 0;
        }
        cont_igual = 0;

        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "3");
    }

    protected void OnRestaClicked(object sender, EventArgs e)
    {
        valor_a = Convert.ToDouble(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        signo = "-";
    }

    protected void OnPuntoClicked(object sender, EventArgs e)
    {
        if(cont_punto == 0)
        {
            String display = Pantalla.Text.ToString();
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            Pantalla.InsertText(display + ".");
            cont_punto++;
        }
    }

    protected void OnCeroClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display + "0");
    }

    protected void OnIgualClicked(object sender, EventArgs e)
    {
        if(cont_igual == 0)
        {
            valor_b = Convert.ToDouble(Pantalla.Text);
            switch (signo)
            {
                case "+":
                    resultado = opera.suma(valor_a, valor_b);
                    this.Pantalla.Text = (Convert.ToString(resultado));
                    cont_igual++;
                    break;

                case "-":
                    resultado = opera.resta(valor_a, valor_b);
                    this.Pantalla.Text = (Convert.ToString(resultado));
                    cont_igual++;
                    break;

                case "*":
                    resultado = opera.multiplicar(valor_a, valor_b);
                    this.Pantalla.Text = (Convert.ToString(resultado));
                    cont_igual++;
                    break;

                case "/":
                    resultado = opera.dividir(valor_a, valor_b);
                    this.Pantalla.Text = (Convert.ToString(resultado));
                    cont_igual++;
                    break;


            }
        }

    }
     

    protected void OnSumaClicked(object sender, EventArgs e)
{
        valor_a = Convert.ToDouble(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        signo = "+";

   
}
}


