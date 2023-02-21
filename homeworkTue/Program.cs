using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkTue
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("輸入一串以逗號分隔的字串");
            string stringnum = Console.ReadLine();
            List<int> liststring = stringnum.Split(',').Select(x => int.Parse(x)).ToList();
            liststring.Reverse();
            
            Console.WriteLine($"輸出:{string.Join(",",liststring)}");
            Console.ReadLine();
        }
    }
}
