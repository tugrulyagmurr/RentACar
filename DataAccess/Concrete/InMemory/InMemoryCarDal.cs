using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;


        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = 1999,DailyPrice = 500,Description = "Opel"},
                new Car{CarId = 2,BrandId = 2,ColorId = 3,ModelYear = 2005,DailyPrice = 650,Description = "Fiat"},
                new Car{CarId = 3,BrandId = 2,ColorId = 1,ModelYear = 2013,DailyPrice = 700,Description = "Toyota"},
                new Car{CarId = 4,BrandId = 3,ColorId = 2,ModelYear = 2017,DailyPrice = 750,Description = "Renault"},
                new Car{CarId = 5,BrandId = 3,ColorId = 2,ModelYear = 1994,DailyPrice = 400,Description = "hyundai"}

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            //Her c için tek tek bak. c'nin CarId si gönderilen CarId ye eşit mi?
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        //Veritabanındaki datayı businessa ver - return ile veritabanını döndür
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }
    }
}
