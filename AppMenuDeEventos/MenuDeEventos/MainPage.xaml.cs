using System.Threading.Tasks;

namespace MenuDeEventos
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAbrirKilometrosMetrosClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///KilometrosMetros");
        }
        
        private async void OnAbrirMetrosCentimetrosClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MetrosCentimetros");
        }

        private async void OnAbrirHectometrosMetrosClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///HectometrosMetros");
        }

        private async void OnAbrirSobreClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Sobre");
        }

    }

}
