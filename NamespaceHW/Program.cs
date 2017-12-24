using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace NamespaceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary.Person person = new MyLibrary.Person("Nurkaiyr", 18);
            MyLibrary.StaticClass.ShowInfo(person);

            Console.WriteLine(MyLibrary.Constatns.str, MyLibrary.Constatns.number);
        }


    }
}
