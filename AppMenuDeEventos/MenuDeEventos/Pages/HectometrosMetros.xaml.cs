namespace MenuDeEventos.Pages;

public partial class HectometrosMetros : ContentPage
{
    public HectometrosMetros()
    {
        InitializeComponent();
    }

    private void OnLimparHectometrosMetrosClicked(object sender, EventArgs e)
    {
        etrResultadoHectometrosMetros.Text = "";
        etrHectometrosParaMetros.Text = "";

        DisplayAlert("APP Sistema de Conversão", "Os Valores foram apagados!", "OK");
    }

    private void OnCalcularHectometrosMetrosClicked(object sender, EventArgs e)
    {

        int kilometrosMetros = 0;

        kilometrosMetros = int.Parse(etrHectometrosParaMetros.Text) * 100;

        etrResultadoHectometrosMetros.Text = kilometrosMetros.ToString() + " metros";

    }
}