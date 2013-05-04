using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnsumarClicked (object sender, EventArgs e)
	{
		int nume1 = int.Parse (this.num1.Text);
		int nume2 = int.Parse (this.num2.Text);
	
		int resu =nume1+nume2;
		this.resu.Text=resu.ToString ();

	}

	protected void OnBtnrestarClicked (object sender, EventArgs e)
	{
		int nume1 = int.Parse (this.num1.Text);
		int nume2 = int.Parse (this.num2.Text);
		
		int resu =nume1-nume2;
		this.resu.Text=resu.ToString ();
	}

	protected void OnBtnmultClicked (object sender, EventArgs e)
	{
		int nume1 = int.Parse (this.num1.Text);
		int nume2 = int.Parse (this.num2.Text);
		
		int resu =nume1*nume2;
		this.resu.Text=resu.ToString ();
	}

	protected void OnBtndivClicked (object sender, EventArgs e)
	{
		int nume1 = int.Parse (this.num1.Text);
		int nume2 = int.Parse (this.num2.Text);
		
		int resu =nume1/nume2;
		this.resu.Text=resu.ToString ();
	}
}
