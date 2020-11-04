using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFFurniture;

namespace OSSC_Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void LoginClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage2());

            //Application.Current.MainPage = new MainPage();
        }


        void SalirClick(System.Object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new HomePage());
        }

    }
}