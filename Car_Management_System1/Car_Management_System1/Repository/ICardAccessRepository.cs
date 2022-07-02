using Car_Management_System1.Models;

namespace Car_Management_System1.Repository
{
    public interface ICardAccessRepository
    {
        int Generate(Card card);
        Car GetCardById(int id);
    }
}
