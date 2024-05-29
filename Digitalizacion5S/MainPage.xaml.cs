using Digitalizacion5S.View;

namespace Digitalizacion5S
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent(); 
            nombreAuditor.Text = AppGlobals.nombreAudi;
        }

        private async void btn_5s_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccesoAuditorias());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            NavigationPage.SetHasBackButton(this, false);
        }
    }

}
