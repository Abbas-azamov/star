using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player alex = new Player("Alex", "player", 23, null, "heat");
            //alex.Age = 233;
            alex.GetInfo();
            Dictionary<string, bool> places = new Dictionary<string, bool>();
            places.Add("USA", true);
            places.Add("Germany", false);
            Enemy bob = new Enemy("Bob","enemy",35, null);
            //bob.Age = 56;
            bob.GetInfo();
        }
    }
}
