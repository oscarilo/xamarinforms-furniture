using System;
using System.ComponentModel;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFFurniture.ViewModels;

namespace OSSC_Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
           

            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new MainPageViewModel(Navigation);

            //this.BindingContext = this;

        }// MainPage

        //private Timer timer;

        //public ObservableCollection<Walkthrough> WalkthroughItems { get => Load(); }

        protected override void OnAppearing()
        {


            //DependencyService.Get<IStatusBarStyle>().ChangeTextColor();

            //timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            //timer.Elapsed += Timer_Elapsed;
            //base.OnAppearing();
        }

        //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    Device.BeginInvokeOnMainThread(() =>
        //    {

        //        if (cvWalkthrough.Position == 2)
        //        {
        //            cvWalkthrough.Position = 0;
        //            return;
        //        }

        //        cvWalkthrough.Position += 1;
        //    });
        //}

        protected override void OnDisappearing()
        {
            //timer?.Dispose();
            //base.OnDisappearing();
        }


        //private ObservableCollection<Walkthrough> Load()
        //{
        //    return new ObservableCollection<Walkthrough>(new[]
        //    {
        //        new Walkthrough
        //        {
        //            Heading =" Kiosko de empleados ",
        //            Caption = "Práctico canal informativo para tus trabajadores. Mayor eficiencia para tu Capital Humano.",
        //            Image = "https://lirp-cdn.multiscreensite.com/50b520dc/dms3rep/multi/opt/ImgGiro-1920w.jpg"
        //        },

        //        new Walkthrough
        //        {
        //            Heading =" Reloj checador ",
        //            Caption = "Control preciso de tiempos y formas de acceso, configurable a cualquier horario o turno.",
        //            Image = "https://lirp-cdn.multiscreensite.com/50b520dc/dms3rep/multi/opt/reloj+checador-db6b002d-1920w.jpg"
        //        },

        //        new Walkthrough
        //        {
        //            Heading =" Comedor electrónico ",
        //            Caption = "Visualización clara de consumos de alimentos de tus colaboradores. ",
        //            Image = "https://lirp-cdn.multiscreensite.com/50b520dc/dms3rep/multi/opt/AdobeStock_111453587-1920w.jpeg"
        //        }
        //    });

        //}// Load


        private void MenuTapped(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void OverlayTapped(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void CloseMenu()
        {
            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, 0, -260, 16, 300, Easing.CubicInOut);

            MenuGrid.IsVisible = false;
        }



        private void OpenMenu()
        {
            MenuGrid.IsVisible = true;

            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, -260, 0, 16, 300, Easing.CubicInOut);
        }
    }

    //public class Walkthrough
    //{
    //    public string Heading { get; set; }
    //    public string Caption { get; set; }
    //    public string Image { get; set; }
    //}
}