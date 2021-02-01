using System;
using DinoTeam.Modules;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string thuan = "thuan";
            thuan = thuan.Hash();
            Console.WriteLine(thuan);
        }
    }
}
