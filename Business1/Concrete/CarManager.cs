using Business1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business1.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }
        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }
    }

    public interface ICarDal
    {
        List<Car> GetAll();
    }
}
