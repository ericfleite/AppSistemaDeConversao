namespace MenuDeEventos.Pages;

public partial class KilometrosMetros : ContentPage
{
	public KilometrosMetros()
	{
		InitializeComponent();
	}

	private void OnLimparKilometrosMetrosClicked(object sender, EventArgs e)
	{
		etrResultadoKilometrosMetros.Text = "";
		etrKilometrosParaMetros.Text = "";

		DisplayAlert("APP Sistema de Conversão", "Os Valores foram apagados!", "OK");
	}

	private void OnCalcularKilometrosMetrosClicked(object sender, EventArgs e)
	{

		int kilometrosMetros = 0;

		kilometrosMetros = int.Parse(etrKilometrosParaMetros.Text) * 1000;

		etrResultadoKilometrosMetros.Text = kilometrosMetros.ToString() + " metros";

	}

}