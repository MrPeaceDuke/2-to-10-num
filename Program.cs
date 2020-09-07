using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string s = Convert.ToString(a, 2);
            int count1 = s.ToCharArray().Where(c => c == '1').Count();
            int count0 = s.ToCharArray().Where(c => c == '0').Count();
            string ss = "";
            for (int i = 0; i < count1; i++) ss += "1";
            for (int i = 0; i < count0; i++) ss += "0";
            Console.WriteLine(Convert.ToInt32(ss, 2));
            Console.ReadLine();
        }
    }
}