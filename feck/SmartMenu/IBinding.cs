using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenu
{
    public interface IBinding
    {
        bool Call(IMenuItem menuItem);

        List<IMenuItem> GetAllMenuItems();
    }
}
