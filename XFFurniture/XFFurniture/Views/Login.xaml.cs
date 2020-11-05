using System;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFFurniture.Interfaces;
using XFFurniture.ViewModels;

namespace OSSC_Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        //private Timer timer;

        public Login()
        {
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);
            //BindingContext = new MainPageViewModel(Navigation);
        }

        void LoginClick(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage2());

            //Application.Current.MainPage = new MainPage();
        }

        async void ClickWebSite ( Object sender, EventArgs e)
        {
            await Xamarin.Essentials.Browser.OpenAsync("https://www.ossc.mx/", Xamarin.Essentials.BrowserLaunchMode.SystemPreferred);
        }

        //protected override void OnAppearing()
        //{
        //    DependencyService.Get<IStatusBarStyle>().ChangeTextColor();

        //    timer = new Timer(TimeSpan.FromSeconds(7).TotalMilliseconds) { AutoReset = true, Enabled = true };
        //    timer.Elapsed += Timer_Elapsed;
        //    base.OnAppearing();
        //}

        //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    Device.BeginInvokeOnMainThread(() =>
        //    {

        //        if (cvWalkthrough.Position == 5)
        //        {
        //            cvWalkthrough.Position = 0;
        //            return;
        //        }

        //        cvWalkthrough.Position += 1;
        //    });
        //}


        void SalirClick(Object sender, EventArgs e)
        {
            //Navigation.PushAsync(new HomePage());
        }

    }
}