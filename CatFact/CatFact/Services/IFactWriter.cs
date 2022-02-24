using CatFact.Models;
using System.Threading.Tasks;

namespace CatFact.Services
{
    public interface IFactWriter
    {
        public Task WriteFact(FactCat fact);
    }
}
