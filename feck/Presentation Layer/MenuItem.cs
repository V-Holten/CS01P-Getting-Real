using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenu
{
    class MenuItem : IMenuItem
    {
        private string Title;

        public MenuItem(string title)
        {
            Title = title;
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public string ToSmartMenu() => Title;
    }
}
