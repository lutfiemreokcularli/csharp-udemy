using System;
using System.Collections.Generic;

namespace UdemyCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Age = 22;
            ogr.Name = "Name";
            ogr.Surname = "Surname";

            Console.WriteLine(ogr.Name);
            Console.WriteLine(ogr.Surname);
            Console.WriteLine(ogr.Age);
        }
    }
    class Ogrenci
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { 
            
                if(value > 30)
                {
                    throw new System.Exception("Öğrenci yaşı 30dan büyük olamaz");
                }
                _age = value;
            } }
    }
}
