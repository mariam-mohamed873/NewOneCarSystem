using Car_Management_System1.Models;
using Car_Management_System1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Management_System1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        CarContext context;
        ICarRepository carRepository;
        ICardAccessRepository cardaccessRepository;
        ITransactionRepository transactionRepository;
        public CarController(ICarRepository carRepo,
            ICardAccessRepository cardaccessRepo,
            ITransactionRepository transactionRepo,
            CarContext _context)
        {
            carRepository = carRepo;
            cardaccessRepository = cardaccessRepo;
            transactionRepository = transactionRepo;
            context = _context;
        }
        [HttpGet]
        public ActionResult<List<Car>> GetCars()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            var car = carRepository.GetById(id);
            
            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutCar(int id, Car newcar)
        {
            if (id != newcar.Id)
            {
                return BadRequest();
            }

            carRepository.Update(id, newcar);

            return NoContent();
        }
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Car> PostCar(Car car)
        {
            carRepository.Insert(car);


            return CreatedAtAction("GetCars", new { id = car.Id }, car);
        }


        [HttpDelete("{id}")]
        public IActionResult Deletestudent(int id)
        {
            carRepository.Delete(id);

            return NoContent();
        }

        [HttpPost]
        public ActionResult<Card> PostAccessCard(Card card)
        {
            cardaccessRepository.Generate(card);
            return CreatedAtAction("GetCard", new { id = card.CardAccess }, card);
        }

        [HttpPost]
        public ActionResult<int>Access_Card_Process(int cardaccess)
        {
            var card = cardaccessRepository.GetCardById(cardaccess);
            
            int Credit_Balance = card.Credit;
            Transaction transaction = new Transaction();
            transaction.Date_of_entry = DateTime.Now;
            transaction.Employee_ID = card.Employee_ID;
            transaction.Car_ID = card.Employee_ID;     
            if (Credit_Balance >= 4 && 
                transaction.Date_of_entry!= DateTime.Now)
            {
                Credit_Balance -= 4;
                transactionRepository.Generate(transaction);
            }
            else
            {
                return NotFound("Balance is not enough");
            }
              return Credit_Balance;
        }
    }
}
