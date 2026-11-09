using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MenuRunner();

            int o = Convert.ToInt32(Console.ReadLine());
            Task1 npog = new Task1();
            npog.BbIbor(o);
            Task2 prog = new Task2();
            prog.Swith(o);
        }
    }
}
