using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的整數數字字串");
            String stringnum = Console.ReadLine();
            List<int> list = stringnum.Split(',').Select(x => int.Parse(x)).ToList();
            var even = list.Where(x => x % 2 == 0);
            var odd = list.Where(x => x % 2 == 1);
            Console.WriteLine($"奇數:{string.Join(",",odd)}");
            Console.WriteLine($"偶數:{string.Join(",",even)}");
            Console.ReadLine();
        }
    }
}
