using static CoreFoundation.DispatchSource;

namespace MauiApp19
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAlertClicked(object? sender, EventArgs e)
        {
            if( Rodzaj_Lekarza || string.IsNullOrWhiteSpace(Rodzaj_Lekarza.SelectedItem.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać rodzaj lekarza.", "OK");
                return;
            }


            if (Data.Date == null || string.IsNullOrWhiteSpace(DataPicker.Date.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać datę wizyty.", "OK");
                return;
            }


            if (Godzina.Time == null || string.IsNullOrWhiteSpace(GodzinaPicker.Time.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać godzinę wizyty.", "OK");
                return;
            }

            string rodzajlekarza = Rodzaj_Lekarza.SelectedItem.ToString();
            string data = Data.DatePicker.ToString();
            string godzina = GodzinaPicker.Time.ToString();

            DisplayAlert("Alert", "Wizyta u: " + rodzajlekarza + ", dnia: " + data + ", o godzinie: " + godzina, "OK");
        }
    }
}