namespace MenuDeEventos.Pages;

public partial class MetrosCentimetros : ContentPage
{
    public MetrosCentimetros()
    {
        InitializeComponent();
    }

    private void OnLimparKilometrosMetrosClicked(object sender, EventArgs e)
    {
        etrResultadoMetrosCentimetros.Text = "";
        etrMetrosParaCentimetros.Text = "";

        DisplayAlert("APP Sistema de Conversão", "Os Valores foram apagados!", "OK");
    }

    private void OnCalcularKilometrosMetrosClicked(object sender, EventArgs e)
    {

        int kilometrosMetros = 0;

        kilometrosMetros = int.Parse(etrMetrosParaCentimetros.Text) * 100;

        etrResultadoMetrosCentimetros.Text = kilometrosMetros.ToString() + " centímetros ";

    }
}