using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenu
{
    public class SmartMenu
    {
        public static void Activate(string Title, IBinding binding, string Description = "")
        {
            List<IMenuItem> menuItems = binding.GetAllMenuItems();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                if (Title != null && Title != string.Empty)
                {
                    ConsoleSpace();
                    Console.WriteLine(Title);
                }

                ConsoleSpace();

                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine((i + 1) + " -> " + menuItems[i].ToSmartMenu());
                }

                if (Description != null && Description != string.Empty)
                {
                    ConsoleSpace();
                    Console.WriteLine(Description);
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

        private static void ConsoleSpace()
        {
            Console.WriteLine("----------------");
        }

        public static string RequestString(string request)
        {
            string requested = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine(request);
                requested = Console.ReadLine();
            } while (requested == "");

            return requested;
        }
    }
}
