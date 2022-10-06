using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)WeekDays.Sunday);
            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine((int)WeekDays.Thursday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Saturday);
   
            Console.ReadKey();  
        }
    }
}
