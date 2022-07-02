using Car_Management_System1.Models;

namespace Car_Management_System1.Repository
{
    public class CarRepository : ICarRepository
    {
        CarContext context;
        public CarRepository(CarContext _context)
        {
            context = _context;
        }
        //CRUD
        public List<Car> GetAll()
        {
            return context.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return context.Cars.FirstOrDefault(c => c.Id == id);
        }

        public int Insert(Car car)
        {
            context.Cars.Add(car);
            int raws = context.SaveChanges();
            return raws;
        }

        public int Update(int id, Car car)
        {
            Car oldCar = context.Cars.FirstOrDefault(c => c.Id == id);
            if (oldCar != null)
            {
                oldCar.Id = car.Id;
                oldCar.Brand = car.Brand;
                oldCar.Model = car.Model;
                oldCar.PlateNumber = car.PlateNumber;
                oldCar.Employee_ID = car.Employee_ID;

                int raws = context.SaveChanges();
                return raws;

            }
            return 0;
        }

        public int Delete(int id)
        {
            context.Cars.Remove(GetById(id));
            int raws = context.SaveChanges();

            return raws;
        }
        public List<Car> GetByEmployeeID(int Employee_ID)
        {
            List<Car> students =
                context.Cars.Where(c => c.Employee_ID == Employee_ID).ToList();
            return students;
        }
    }
}
