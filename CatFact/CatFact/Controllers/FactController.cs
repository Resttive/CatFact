using CatFact.Data;
using CatFact.Models;
using CatFact.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatFact.Controllers
{
    public class FactController : Controller
    {
        protected ICatFactReader _dataReader;
        protected IFactWriter _datatWriter;
        public FactController(ICatFactReader dataReader, IFactWriter dataWriter)
        {
            _dataReader = dataReader;
            _datatWriter = dataWriter;
        }
        public IActionResult Index()
        {
            FactCat fact = _dataReader.GetFact();
            _datatWriter.WriteFact(fact);
            return View(fact);
        }

        public IActionResult NewFact()
        {
            FactCat fact = _dataReader.GetFact();
            _datatWriter.WriteFact(fact);
            return View("Index", fact);
        }
    }
}
