using MauiAppFakeStoreApi.Pages;

namespace MauiAppFakeStoreApi
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAgregarProductoClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarProductoPage());

        }
    }

}
