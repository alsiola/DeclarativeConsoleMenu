using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeConsoleMenu.SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCollection menus = MenuGenerator.CreateMenuCollection();
            menus.ShowMenu(1);
            Console.ReadKey();
        }
    }
}
