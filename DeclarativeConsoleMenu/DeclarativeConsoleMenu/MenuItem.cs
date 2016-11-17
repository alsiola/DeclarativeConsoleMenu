using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeConsoleMenu
{
    public class MenuItem
    {
        // displayed in the menu
        public virtual string Text { get; set; }

        // if there's a submenu, what's its id
        public virtual int? SubMenuId { get; set; }

        //if there isn't a sub menu, what should we do
        public virtual Action Action { get; set; }

        public static MenuItem CreateWithAction(string title, Action action)
        {
            return new MenuItem()
            {
                Text = title,
                Action = action
            };
        }

        public static MenuItem CreateWithSubMenu(string title, int subMenuId)
        {
            return new MenuItem()
            {
                Text = title,
                SubMenuId = subMenuId
            };
        }
    }
}
