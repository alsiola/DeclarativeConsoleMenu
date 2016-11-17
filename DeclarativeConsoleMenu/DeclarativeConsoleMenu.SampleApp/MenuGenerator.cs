using DeclarativeConsoleMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeConsoleMenu.SampleApp
{
    class MenuGenerator
    {
        public static MenuCollection CreateMenuCollection()
        {
            MenuCollection collection = new MenuCollection();

            //Declarative way of building a menu, there are also generator methods you can use.
            return new MenuCollection()
            {
                Menus = {
                    new Menu()
                    {
                        MenuId = 1,
                        MenuItems =
                        {
                            new MenuItem()
                            {
                                Text = "Open Sub Menu",
                                SubMenuId = 2
                            },
                            new MenuItem()
                            {
                                Text = "Print hello world!",
                                Action = () => Console.WriteLine("Hello World!")
                            }
                        }
                    },
                    new Menu()
                    {
                        MenuId = 2,
                        MenuItems =
                        {
                            new MenuItem()
                            {
                                Text = "Print Hello",
                                Action = () => Console.WriteLine("Hello")
                            },
                            new MenuItem()
                            {
                                Text = "Print Goodbye",
                                Action = () => Console.WriteLine("Goodbye")
                            },
                            new MenuItem()
                            {
                                Text = "Back to the top menu",
                                SubMenuId = 1
                            }
                        }
                    }
                }
            };
        }
    }
}
