using Car_Management_System1.Models;

namespace Car_Management_System1.Repository
{
    public interface ITransactionRepository
    {
        int Generate(Transaction transaction);
    }
}
