using CatFact.Models;

namespace CatFact.Data
{
    public interface ICatFactReader
    {
        FactCat GetFact();
    }
}
