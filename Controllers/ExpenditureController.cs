using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ExpenditureController : Controller
    {
        //public IList<Expenditure> Expenditure;
        private readonly ILogger<HomeController> _logger;

        public ExpenditureController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

     
      
        public IActionResult Index()
        {   Expenditure exp1 = new Expenditure(new DateOnly(2015, 10, 21), 62.00, "Sèche cheveux" );
            Expenditure exp2 = new Expenditure(new DateOnly(2019, 8, 03), 5408.50, "PC");
            Expenditure exp3 = new Expenditure(new DateOnly(2022, 05, 14), 54.00, "Chaussures");
            IList<Expenditure> expenditures = new List<Expenditure>();
            expenditures.Add(exp1);
            expenditures.Add(exp2);
            expenditures.Add(exp3);

            ViewBag.Expenditures = expenditures;

            return View(expenditures);

        }
      
    }
}
