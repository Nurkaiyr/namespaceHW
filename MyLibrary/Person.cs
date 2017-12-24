using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public void Show()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = int.Parse(Console.ReadLine());
        }
    }
}
