using OSSC_Movil.Views;
using Xamarin.Forms;

namespace XFFurniture
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] { "Shapes_Experimental" });

            MainPage = new NavigationPage(new CarouselViewAd());


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
    }
}
