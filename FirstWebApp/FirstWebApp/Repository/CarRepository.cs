using FirstWebApp.Models;

namespace FirstWebApp.Repository
{
    public class CarRepository
    {
        public static List<Car> cars = new List<Car>()
            {
                new Car() {CarModel = "Ford", CarName = "Focus", YearOfProduction = 1998, CarID = 1 },
                new Car() {CarModel = "BMW", CarName = "M3", YearOfProduction = 2015, CarID = 2 },
                new Car() {CarModel = "Honda", CarName = "Civic", YearOfProduction = 2010, CarID = 3 }
            };
    }
}
