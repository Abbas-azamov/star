using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class Enemy : Person
    {
        public Enemy(string _name, string _type, int _age, Dictionary<string, bool> _places = null) : base(_name, _type, _age, _places)
        {
        }

        public Enemy(string name, string type, int age, Dictionary<string, bool> places, string MP) : base(name, type, age, places)
        {
            
        }
    }
}
