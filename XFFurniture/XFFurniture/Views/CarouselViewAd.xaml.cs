using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OSSC_Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewAd : ContentPage
    {

        public CarouselViewAd()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.BindingContext = this;
        }

        private Timer timer;

        public ObservableCollection<Walkthrough> WalkthroughItems { get => Load(); }


        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(6).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        void ClickLogin(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvWalkthrough.Position == 5)
                {
                    cvWalkthrough.Position = 0;
                    return;
                }

                cvWalkthrough.Position += 1;
            });
        }

        private async Task ExeccuteNavigateToLoginPageCommand()
        {

            await Navigation.PushAsync(new Login());
            //if (param.ID == 1)
            //{
            //    Console.WriteLine("ENTRO 1");
            //}
            //else if (param.ID == 2)
            //{
            //    Console.WriteLine("ENTRO 2");
            //}

        }

        private ObservableCollection<Walkthrough> Load()
        {
            return new ObservableCollection<Walkthrough>(new[]
            {
                new Walkthrough()
                {
                    Heading =" Digitalizador de documentos ",
                    Caption = "Respaldo y fácil manejo de toda la documentación para los expedientes de tus trabajadores.",
                    Image = "fondocarrusel5.jpg"
                },
                new Walkthrough()
                {
                    Heading =" Nómina y Capital Humano",
                    Caption = "Te damos la confianza y seguridad de un sistema de nómina y capital humano.",
                    Image = "fondocarrusel.jpg"
                },
                new Walkthrough()
                {
                    Heading =" Kiosko de empleados ",
                    Caption = "Práctico canal informativo para tus trabajadores. Mayor eficiencia para tu Capital Humano.",
                    Image = "fondocarrusel2.jpg"
                },
                new Walkthrough()
                {
                    Heading =" Reloj checador ",
                    Caption = "Control preciso de tiempos y formas de acceso, configurable a cualquier horario o turno.",
                    Image = "fondocarrusel3.jpg"
                },
                new Walkthrough()
                {
                    Heading =" Comedor electrónico ",
                    Caption = "Visualización clara de consumos de alimentos de tus colaboradores. ",
                    Image = "fondocarrusel4.jpg"
                }
            });
        }
    
    }

    public class Walkthrough
    {
        public string Heading { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }

}