using FirstWebApp.Models;
using FirstWebApp.Repository;

namespace FirstWebApp.Services
{
    public class CarsService
    {
        public static int iDCounter = 3;
        public List<Car> GetAll()
        {
            return CarRepository.cars;
        }
        public Car GetCarById(int id)
        {
            return CarRepository.cars.FirstOrDefault(c => c.CarID == id);
        }
        public void AddCar(Car carToAdd)
        {
            iDCounter++;
            carToAdd.CarID = iDCounter;
            CarRepository.cars.Add(carToAdd);
        }
        public void EditCar(Car carToEdit)
        {
            var model = GetCarById(carToEdit.CarID);
            model.CarName = carToEdit.CarName;
            model.CarModel = carToEdit.CarModel;
            model.YearOfProduction = carToEdit.YearOfProduction;
        }
        public void RemoveCar(Car carToRemove)
        {
            var model = GetCarById(carToRemove.CarID);
            CarRepository.cars.Remove(model);
        }
    }
}
