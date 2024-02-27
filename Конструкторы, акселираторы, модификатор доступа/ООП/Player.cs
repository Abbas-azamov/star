using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class Player : Person
    {
        private string magicPower;
        public string MagicPower
        {
            get => MagicPower;
            set
            {
                if (value == "heal")
                    this.magicPower = value;
                else
                    Console.WriteLine("Такого нет");
            }
        }
        public Player(string name, string type, int age, Dictionary<string, bool> places, string MP) : base(name, type, age, places)
        {
            this.MagicPower = MP; 
        }

        public Player()
        { }
            public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Magic Power: {MagicPower}");
        }
    
    }
}
