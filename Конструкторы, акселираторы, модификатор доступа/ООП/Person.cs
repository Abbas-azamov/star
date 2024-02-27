using System;
using System.Collections.Generic;

namespace ООП
{
    class Person
    {

        //private readonly int score;

        private string name, type;
        private int age;

        private Dictionary<string, bool> places = new Dictionary<string, bool>();

       

        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    Console.WriteLine("Возраст должен быть больше чем ноль");
            }
        }

        public float PosY { 
            get => PosY;
            set => PosY = value;
        }

        public Person(string _name, string _type, int _age, Dictionary<string, bool> _places = null)
        {
            Console.WriteLine("Person is created");
            SetData(_name, _type, _age, _places);
        }

        public Person(string name, string type, int age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }

        public Person()
        {
            Console.WriteLine("Object is created");
        }

        public void SetData(string name, string type, int age, Dictionary<string, bool> places = null)
        {
            this.name = name;
            this.type = type;
            this.places = places;
            this.Age = age;

            
        }
        

        
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        

        public string GetName() => this.name;

        public string GetPersonType() => this.type;

        internal void SetData(int v)
        {
            throw new NotImplementedException();
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Игрок: {this.GetName()}. Тип: {GetPersonType()}. Возраст: {Age}.");
            if (places == null || places.Count == 0)
                return;
            foreach(var el in places.Keys)
            {
                Console.WriteLine(el);
            }
        }
    }
}
