// See https://aka.ms/new-console-template for more information

CarManager carManager = new CarManager(new IMemoryCarDal());

foreach (var cars in carManager.GetAll())
{
    Console.WriteLine(cars.Id);
}


foreach (var Cars in carsManager.GetAll())
{
    Console.WriteLine(Cars.Id + ":" + " " + Cars.Description + " " + "-" + Cars.ModelYear + "-" + " " + "==>" + " " + Cars.DailyPrice + "TL");
}

internal class carsManager
{
    internal static IEnumerable<object> GetAll()
    {
        throw new NotImplementedException();
    }
}



internal class IMemoryCarDal
{
    public IMemoryCarDal()
    {
    }
}

internal class CarManager
{
    private IMemoryCarDal memoryCarDal;

    public CarManager(IMemoryCarDal memoryCarDal)
    {
        this.memoryCarDal = memoryCarDal;
    }

    internal IEnumerable<object> GetAll()
    {
        throw new NotImplementedException();
    }
}