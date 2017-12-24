using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class StaticClass
    {
        static public void ShowInfo(Person person)
        {
            Console.WriteLine("Имя:{0}\n Возраст:{1}\n", person.getName(), person.getAge());
        }
    }
}
