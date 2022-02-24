using CatFact.Models;
using System.IO;
using System.Threading.Tasks;

namespace CatFact.Services
{
    public class FactWriter : IFactWriter
    {
        public async Task WriteFact(FactCat fact)
        {
            StreamWriter file = new("WriteFact.txt", append: true);
            await file.WriteLineAsync(fact.Fact + " " + fact.Length.ToString());
            file.Close();
        }

    }
}
