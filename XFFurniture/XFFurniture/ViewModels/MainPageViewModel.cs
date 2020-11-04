using OSSC_Movil.Models;
using OSSC_Movil.Views;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XFFurniture.Models;
using XFFurniture.Service;
using XFFurniture.ViewModel;
using XFFurniture.Views;

namespace XFFurniture.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SelectCategoryCommand = new Command<Modulo>((param) => ExecuteSelectCategoryCommand(param));
            NavigateToDetailPageCommand = new Command<AccesoRapido>(async (param) => await ExeccuteNavigateToDetailPageCommand(param));

            //NavigateToCategoryPageCommand = new Command(() =>  ExeccuteNavigateToCategoryPageCommand());


            GetCategories();
            GetProducts();
            GetSlides();


            MenuList = GetMenus();

        }// MainPageViewModel


        private ObservableCollection<Menu> menuList;
        public ObservableCollection<Menu> MenuList
        {
            get { return menuList; }
            set { menuList = value; }
        }

        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Icon = "config.png", Name = "Configuración"},
                new Menu { Icon = "acercade.png", Name = "Acerca de"},
                new Menu { Icon = "cerrarsesion.png", Name = "Cerrar sesión"},
                new Menu { Icon = "salir.png", Name = "Salir"}
            };
        }

        public Command NavigateToCategoryPageCommand { get; }

        public Command NavigateToDetailPageCommand { get; }
        public Command SelectCategoryCommand { get; }
        public ObservableCollection<Modulo> Categories { get; set; }
        public ObservableCollection<AccesoRapido> Products { get; set; }

        public ObservableCollection<CustomSlide> CustomSlides { get; set; }

        void GetCategories()
        {
            Categories = new ObservableCollection<Modulo>(DataService.GetCategories());
        }

        void GetSlides()
        {
            CustomSlides = new ObservableCollection<CustomSlide>(DataService.GetSlides());
        }

        void GetProducts()
        {
            Products = new ObservableCollection<AccesoRapido>(DataService.GetProducts());
        }

        private void ExecuteSelectCategoryCommand(Modulo model)
        {
            var index = Categories
               .ToList()
               .FindIndex(p => p.description == model.description);

            if (index > -1)
            {
                UnselectGroupItems();

                Categories[index].selected = true;
                Categories[index].textColor = "#FFFFFF";
                Categories[index].backgroundColor = "#3E9CD9";
            }

            Navigation.PushAsync(new Categoria());
        }

        void UnselectGroupItems()
        {
            Categories.ForEach((item) =>
            {
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }

        private async Task ExeccuteNavigateToDetailPageCommand(AccesoRapido param)
        {

            //await Navigation.PushAsync(new DetailPage(param));
            if (param.description.Equals(""))
            {

            }

        }


        private async Task ExeccuteNavigateToCategoryPageCommand()
        {

            await Navigation.PushAsync(new Categoria());

        }


    }

    public class Menu
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
