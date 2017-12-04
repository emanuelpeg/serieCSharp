using System;
using Gtk;
using SecuenciaCSharep;

public partial class MainWindow: Gtk.Window
{	
	private Juego juego;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		juego = new Juego ();
		this.regenerate ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int n = (int)this.spinbutton2.Value;
		MessageDialog msd; 
		if (juego.isOK (n)) {
			msd = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.None, "Ganaste!! Puntaje : " + juego.getPuntaje());
		} else {
			msd = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.None, "Perdiste  Puntaje : " + juego.getPuntaje());		
		}
		msd.Show ();
		this.regenerate ();
	}

	private void regenerate() {
		this.label1.Text = juego.getValue0 ().ToString();
		this.label2.Text = juego.getValue1 ().ToString();
		this.label3.Text = juego.getValue3 ().ToString();
		this.spinbutton2.Value = 0;
	}
}
