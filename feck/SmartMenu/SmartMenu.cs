using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenu
{
    public class SmartMenu
    {
        public static void Activate(string Title, IBinding binding)
        {
            List<IMenuItem> menuItems = binding.GetAllMenuItems();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("################");
                Console.WriteLine(Title);
                Console.WriteLine("################");

                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine((i + 1) + " -> " + menuItems[i].ToSmartMenu());
                }

                string input = Console.ReadLine();

                if (int.TryParse(input, out int inputInt))
                {
                    if (inputInt == 0)
                    {
                        exit = true;
                    }
                    else if (inputInt > 0 && inputInt <= menuItems.Count)
                    {
                        binding.Call(menuItems[inputInt - 1]);
                    }
                }
            }
        }
    }
}
