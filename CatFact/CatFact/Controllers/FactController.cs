using CatFact.Data;
using CatFact.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatFact.Controllers
{
    public class FactController : Controller
    {
        protected ICatFactReader _dataReader; 
        public FactController(ICatFactReader dataReader)
        {
            _dataReader = dataReader;
        }
        public IActionResult Index()
        {
            FactCat fact = _dataReader.GetFact();
            return View(fact);
        }

        public IActionResult NewFact()
        {
            FactCat fact = _dataReader.GetFact();
            return View("Index", fact);
        }
    }
}
