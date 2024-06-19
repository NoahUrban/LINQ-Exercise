using System;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameList = new List<string>() { "Overwatch", "Rocket League", "Civ 6", "Driving Sim", "Guitar Hero"};

            IEnumerable<string> ascendingGameList =
                gameList.OrderBy(name => name.Length);

            foreach (var i in ascendingGameList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
