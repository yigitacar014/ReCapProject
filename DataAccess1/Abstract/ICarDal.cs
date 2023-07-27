using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById( int Id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);


    }

    public class Car
    {
        internal int BrandId;

        public int Id { get; internal set; }
        public int ColorId { get; internal set; }
        public int DailyPrice { get; internal set; }
        public string Description { get; internal set; }
        public object ModelYear { get; internal set; }
    }
}

