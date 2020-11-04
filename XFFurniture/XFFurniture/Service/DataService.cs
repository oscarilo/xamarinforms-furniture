using OSSC_Movil.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XFFurniture.Models;

namespace XFFurniture.Service
{
    public class DataService
    {
        public static ObservableCollection<Modulo> GetCategories()
        {
            return new ObservableCollection<Modulo>()
            {
                new Modulo()
                {
                    description = "Digitalizador",
                    //numberItems = 4512,
                    image = "icondigital.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Modulo()
                {
                    description = "Kiosko",
                    //numberItems = 512,
                    image = "iconkiosko.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Modulo()
                {
                    description = "Nomina",
                    //numberItems = 1815,
                    image = "tvstand.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },

                new Modulo()
                {
                    description = "Reloj checador",
                    //numberItems = 1815,
                    image = "tvstand.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },

                new Modulo()
                {
                    description = "Timbrado",
                    //numberItems = 1815,
                    image = "tvstand.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                }
            };
        }


        public static ObservableCollection<CustomSlide> GetSlides()
        {
            return new ObservableCollection<CustomSlide>()
            {
                new CustomSlide()
                {
                    Heading =" Kiosko de empleados ",
                    Caption = "Práctico canal informativo para tus trabajadores. Mayor eficiencia para tu Capital Humano.",
                    Image = "https://lirp-cdn.multiscreensite.com/50b520dc/dms3rep/multi/opt/ImgGiro-1920w.jpg"
                },
                new CustomSlide()
                {
                    Heading =" Reloj checador ",
                    Caption = "Control preciso de tiempos y formas de acceso, configurable a cualquier horario o turno.",
                    Image = "https://lirp-cdn.multiscreensite.com/50b520dc/dms3rep/multi/opt/reloj+checador-db6b002d-1920w.jpg"
                },
                new CustomSlide()
                {
                    Heading =" Comedor electrónico ",
                    Caption = "Visualización clara de consumos de alimentos de tus colaboradores. ",
                    Image = "https://lirp-cdn.multiscreensite.com/50b520dc/dms3rep/multi/opt/AdobeStock_111453587-1920w.jpeg"
                }
            };
        }

        //Creación de accesos rápidos

        public static ObservableCollection<AccesoRapido> GetProducts()
        {
            return new ObservableCollection<AccesoRapido>()
            {
                new AccesoRapido()
                {
                    ID = 1,
                    description = "Digitalizador",
                    rating = 4.5,
                    review = 463,
                    oldPrice = 8152,
                    newPrice = 6114,
                    image = "digitalizador.png",
                    favorite = true,
                    discount = 25,
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0", selected = true },
                        new Color(){ color = "#54889A" },
                        new Color(){ color = "#3B3B3B" }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new AccesoRapido()
                {
                    ID = 2,
                    description = "Timbrado",
                    rating = 4.5,
                    review = 263,

                    oldPrice = 0,
                    newPrice = 2515,
                    favorite = false,
                    discount = 0,
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A", selected = true },
                        new Color(){ color = "#3B3B3B" }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new AccesoRapido()
                {
                    ID = 3,
                    description = "Nómina",
                    rating = 3.8,
                    review = 158,
                    oldPrice = 0,
                    newPrice = 1580,
                    favorite = false,
                    discount = 0,
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A" },
                        new Color(){ color = "#3B3B3B", selected = true }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                //},
                //new AccesoRapido()
                //{
                //    description = "Op 2",
                //    rating = 4.8,
                //    review = 525,
                //    image = "digitalizador.png",
                //    oldPrice = 0,
                //    newPrice = 2199,
                //    favorite = true,
                //    discount = 0,
                //    colors = new List<Color>()
                //    {
                //        new Color(){ color = "#9AADB0" },
                //        new Color(){ color = "#54889A", selected = true },
                //        new Color(){ color = "#3B3B3B" }
                //    },
                //    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //    createdBy = "Xamarin Forms"
                //},
                //new AccesoRapido()
                //{
                //    description = "Timbrado",
                //    rating = 4,
                //    review = 718,
                //    oldPrice = 1589,
                //    newPrice = 3650,
                //    favorite = true,
                //    discount = 15,
                //    colors = new List<Color>()
                //    {
                //        new Color(){ color = "#9AADB0" },
                //        new Color(){ color = "#54889A" },
                //        new Color(){ color = "#3B3B3B", selected = true }
                //    },
                //    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                //    createdBy = "Xamarin Forms"
                //},
                //new AccesoRapido()
                //{
                //    description = "Timbrado",
                //    rating = 5,
                //    review = 890,
                //    oldPrice = 0,
                //    newPrice = 6599,
                //    favorite = true,
                //    discount = 0,
                //    colors = new List<Color>()
                //    {
                //        new Color(){ color = "#9AADB0" },
                //        new Color(){ color = "#54889A", selected = true },
                //        new Color(){ color = "#C5BAA4" },
                //        new Color(){ color = "#EFCBAF" },
                //        new Color(){ color = "#3B3B3B" }
                //    },
                //    overview = "Homez offers Furniture at affordable prices with the best quality and durability with modern designs. Our aim is to meet the necessity of home decor and for the ones who are looking for premium and trending seating solutions.\n\nBucket Style Sofas have rounded or contoured back. The earliest bucket sofas had high sides and were named for their resemblance to buckets.\n\nFurniture bought on Homez.com is shipped for free. So go ahead and buy with confidence.",
                //    createdBy = "Xamarin Forms"
                },
            };
        }
    }
}
