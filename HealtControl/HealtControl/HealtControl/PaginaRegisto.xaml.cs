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
    public partial class PaginaRegisto : ContentPage
    {
        public PaginaRegisto()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            //validaciones locales para que esten los campos llenos 
            if(string.IsNullOrEmpty(txtNombre.Text)) //Si el campo de nombre se encuentra vacio
            {
                await DisplayAlert("Error", "Algun campo esta vacio", "Aceptar");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text)) //Si el campo de correo se encuentra vacio
            {
                await DisplayAlert("Error", "Algun campo esta vacio", "Aceptar");
                txtCorreo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text)) //Si el campo de contraseña se encuentra vacio
            {
                await DisplayAlert("Error", "Algun campo esta vacio", "Aceptar");
                txtContraseña.Focus();
                return;
            }
            
            
        }
    }
}