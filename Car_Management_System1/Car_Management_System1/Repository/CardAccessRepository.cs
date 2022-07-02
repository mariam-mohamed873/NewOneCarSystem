using Car_Management_System1.Models;

namespace Car_Management_System1.Repository
{
    public class CardAccessRepository : ICardAccessRepository
    {
        CarContext context;
        public CardAccessRepository(CarContext _context)
        {
            context = _context;
        }
        public int Generate(Card card)
        {
            context.Cards.Add(card);
            int raws = context.SaveChanges();
            return raws;
        }
        public Card GetCardById(int id)
        {
            return context.Cards.FirstOrDefault(c => c.CardAccess == id);
        }
    }
}
