using Car_Management_System1.Models;

namespace Car_Management_System1.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        CarContext context;
        public TransactionRepository(CarContext _context)
        {
            context = _context;
        }
        public int Generate(Transaction transaction)
        {
            context.Transactions.Add(transaction);
            int raws = context.SaveChanges();
            return raws;
        }
    }
}
