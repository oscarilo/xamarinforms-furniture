using OSSC_Movil.Models;
using OSSC_Movil.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XFFurniture.Service;
using XFFurniture.ViewModel;
using XFFurniture.Views;
using XFFurniture.Models;

namespace XFFurniture.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        // Colecciones
        public ObservableCollection<Modulo> Modulo { get; set; }
        public ObservableCollection<AccesoRapido> Acceso { get; set; }
        public ObservableCollection<ElementoMenu> Menu { get; set; }
        public ObservableCollection<CustomSlide> CustomSlides { get; set; }

        //public ObservableCollection<CustomSlide> WalkthroughItems { get; }

        // Commands
        public Command NavigateToCategoryPageCommand { get; }
        public Command NavigateToDetailPageCommand { get; }
        public Command SelectCategoryCommand { get; }
        public Command SelectItemMenu { get; }

        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SelectCategoryCommand = new Command<Modulo>((param) => ExecuteSelectCategoryCommand(param));
            NavigateToDetailPageCommand = new Command<AccesoRapido>(async (param) => await ExeccuteNavigateToDetailPageCommand(param));
            //SelectItemMenu = new Command<ElementoMenu>((param) => ExecuteSelectCategoryCommand(param));

            //NavigateToCategoryPageCommand = new Command(() =>  ExeccuteNavigateToCategoryPageCommand());

            GetModulos();
            GetAccesoRapido();
            GetSlides();
            GetMenus();
        }// MainPageViewModel


        // Methods
        void GetModulos()
        {
            Modulo = new ObservableCollection<Modulo>(DataService.GetModulos());
        }

        void GetMenus()
        {
            Menu = new ObservableCollection<ElementoMenu>(DataService.GetMenus());
        }

        void GetSlides()
        {
            CustomSlides = new ObservableCollection<CustomSlide>(DataService.GetSlides());
        }

        void GetAccesoRapido()
        {
            Acceso = new ObservableCollection<AccesoRapido>(DataService.GetAccesos());
        }


        private void ExecuteSelectCategoryCommand(Modulo model)
        {
            var index = Modulo
               .ToList()
               .FindIndex(p => p.description == model.description);

            if (index > -1)
            {
                UnselectGroupItems();

                Modulo[index].selected = true;
                Modulo[index].textColor = "#FFFFFF";
                Modulo[index].backgroundColor = "#3E9CD9";
            }

            Navigation.PushAsync(new Categoria());
        }

        void UnselectGroupItems()
        {
            Modulo.ForEach((item) =>
            {
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }

        private async Task ExeccuteNavigateToDetailPageCommand(AccesoRapido param)
        {

            await Navigation.PushAsync(new DetailPage(param));
            if (param.ID == 1)
            {
                Console.WriteLine("ENTRO 1");
            }
            else if (param.ID == 2)
            {
                Console.WriteLine("ENTRO 2");
            }

        }

        private async Task ExeccuteNavigateToCategoryPageCommand()
        {

            await Navigation.PushAsync(new Categoria());

        }


    }// class

}// namespace
