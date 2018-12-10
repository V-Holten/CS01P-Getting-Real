using SmartMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class Binding : IBinding
    {
        private List<IMenuItem> MenuItems = new List<IMenuItem>();

        public bool Call(IMenuItem menuItem)
        {
            return menuItem.Activate();
        }

        public List<IMenuItem> GetAllMenuItems()
        {
            return MenuItems;
        }

        public void Add(IMenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }
    }
}
