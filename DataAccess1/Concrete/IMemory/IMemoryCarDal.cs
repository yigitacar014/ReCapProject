﻿using DataAccess1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Concrete.IMemory
{
    public class IMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public IMemoryCarDal() => _cars = new List<Car>
        {
          new Car{Id=1, BrandId=5,ColorId=12,DailyPrice=250,Description="Mercedes" },
          new Car{Id=2, BrandId=6,ColorId=14,DailyPrice=500,Description="Toyota"},
          new Car{Id=3, BrandId=8,ColorId=10,DailyPrice=750,Description="Mitsubishi"},
          new Car{Id=4, BrandId=1,ColorId=6,DailyPrice=5000,Description="Bugatti"},
          new Car{Id=5, BrandId=9,ColorId=12,DailyPrice=500,Description="Fiat"}

        };


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();  
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c=>c.Id==car.Id);
             carToUpdate.BrandId=car.BrandId;
            carToUpdate.Description=car.Description;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;


        }
    }
}
