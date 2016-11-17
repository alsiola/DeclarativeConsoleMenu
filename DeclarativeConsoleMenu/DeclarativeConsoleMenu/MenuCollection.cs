using System;
using System.Collections.Generic;
using System.Linq;

namespace DeclarativeConsoleMenu
{
    public class MenuCollection
    {
        public MenuCollection()
        {
            Menus = new List<Menu>();
        }

        public virtual List<Menu> Menus { get; set; }

        public virtual void AddMenu(Menu menu)
        {
            Menus.Add(menu);
        }

        public virtual void ShowMenu(int id)
        {
            //get the menu we want to display and call its PrintToConsole method
            var currentMenu = Menus.Where(m => m.MenuId == id).Single();
            currentMenu.PrintToConsole();

            //wait for user input
            string choice = Console.ReadLine();
            int choiceIndex;

            // once we have the users selection make sure its an integer and in range of our menu options
            if (!int.TryParse(  choice, out choiceIndex) || choiceIndex < 0 || choiceIndex >= currentMenu.MenuItems.Count )
            {
                Console.Clear();

                // Redisplay menu with error message.
                Console.WriteLine("Invalid selection - try again");
                ShowMenu(id);
            }
            else
            {
                // Retrieve the corresponding menu item
                var menuItemSelected = currentMenu.MenuItems[choiceIndex];

                // if there's a sub menu then display it
                if (menuItemSelected.SubMenuId.HasValue)
                {
                    Console.Clear();
                    ShowMenu(menuItemSelected.SubMenuId.Value);
                }
                // otherwise perform whatever action we need
                else
                {
                    menuItemSelected.Action();
                }
            }
        }
    }
}
