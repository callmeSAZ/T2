using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دریافت ورودی و چاپ عدد اسکی
            char ch = char.Parse(Console.ReadLine());
            int x = (int)ch;   
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
