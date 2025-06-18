using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            double age = 23;
            age /= 10;
            Console.WriteLine(age);

            string name = "Abir";
            name += " is learning C#";
            Console.WriteLine(name);
            
            char c = 'a';
            c += 'b';
            Console.WriteLine(c);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            
            Console.ReadLine();
        }
    }
}