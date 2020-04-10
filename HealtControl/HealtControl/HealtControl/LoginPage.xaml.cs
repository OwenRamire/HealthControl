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
        }

        
        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
       
            home modalPage = new home();
            this.Navigation.PushModalAsync(modalPage);
            /*
            await DisplayAlert("Success", "Login success", "Aceptar");
            await Navigation.PushAsync(new home());
            */
        }
      
    }
}