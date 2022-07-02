using Car_Management_System1.Models;

namespace Car_Management_System1.Repository
{
    public interface ICarRepository
    {
        int Delete(int id);
        List<Car> GetAll();
        List<Car> GetByEmployeeID(int Employee_ID);
        Car GetById(int id);
        int Insert(Car car);
        int Update(int id, Car car);
    }
}
