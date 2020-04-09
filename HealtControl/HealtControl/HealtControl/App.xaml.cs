using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealtControl
{
    public partial class App : Application
    {
        public static MainPage MasterD { get; internal set; }

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        internal static Task NavigatiPageAsync(object p)
        {
            throw new NotImplementedException();
        }
    }
}
