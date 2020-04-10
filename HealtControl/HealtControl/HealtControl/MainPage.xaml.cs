using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealtControl
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnModalIniciarSesion_Clicked(object sender, EventArgs e)
        {
            LoginPage modalPage = new LoginPage(); //Creamos una variable para la modal 
            this.Navigation.PushModalAsync(modalPage); //Hacemos la navegacion de la modal 
        }

        private void btnModalRegistrar_Clicked(object sender, EventArgs e)
        {
            PaginaRegisto modalPage = new PaginaRegisto();
            this.Navigation.PushModalAsync(modalPage);  //Hacemos la navegacion de la modal 
        }
    }
}
