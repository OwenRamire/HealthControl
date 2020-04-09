using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealtControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
            //btnIniciaar.Clicked += btnIniciaar_Clicked;
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Login success", "Aceptar");
            await Navigation.PushAsync(new MainPage());
            

        }
    }
}