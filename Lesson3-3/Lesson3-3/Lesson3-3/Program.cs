using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что нибудь");
            string a = Console.ReadLine();
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            a = new string(b);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
