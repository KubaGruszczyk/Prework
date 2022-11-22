using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class Car
    {

        public int CarID { get; set; }
        [DisplayName("Marka Pojazdu")]
        public string CarModel { get; set; }
        [DisplayName("Model Pojazdu")]
        public string CarName { get; set; }

        [DisplayName("Rok Produkcji")]
        [Range(1900,2022,ErrorMessage ="Podaj liczbę z zakresu 1900 - 2022")]
        public int YearOfProduction { get; set; }

    }
}
