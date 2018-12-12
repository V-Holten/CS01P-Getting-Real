using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        private string Title;
        private string ExitDescription;
        private string Description;
        private List<IMenuItem> MenuItems = new List<IMenuItem>();

        public SmartMenu(string title, string exitDescription, string description = "")
        {
            Title = title;
            ExitDescription = exitDescription;
            Description = description;
        }

        public bool Call(IMenuItem menuItem)
        {
            return menuItem.Activate(this);
        }

        public List<IMenuItem> GetAllMenuItems()
        {
            return MenuItems;
        }

        public void Add(IMenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public void Remove(IMenuItem menuItem)
        {
            MenuItems.Remove(menuItem);
        }

        public void Activate()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                if (Title != null && Title != string.Empty)
                {
                    ConsoleSpace();
                    Console.WriteLine(Title);
                }

                if (Description != null && Description != string.Empty)
                {
                    ConsoleSpace();
                    Console.WriteLine(Description);
                }

                ConsoleSpace();

                for (int i = 0; i < MenuItems.Count; i++)
                {
                    Console.WriteLine(i + 1 + " -> " + MenuItems[i]);
                }
                Console.WriteLine("0 -> " + ExitDescription);

                ConsoleSpace();
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int inputInt))
                {
                    if (inputInt == 0)
                    {
                        exit = true;
                    }
                    else if (inputInt > 0 && inputInt <= MenuItems.Count)
                    {
                        exit = Call(MenuItems[inputInt - 1]);
                    }
                }
                Console.Clear();
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

        public static int RequestInt(string request)
        {
            string requested = string.Empty;
            int output;
            do
            {
                Console.Clear();
                Console.WriteLine(request);
                requested = Console.ReadLine();
            } while (!int.TryParse(requested, out output));

            return output;
        }

        public static DateTime RequestDateTime(string request)
        {
            string requested = string.Empty;
            DateTime output;
            do
            {
                Console.Clear();
                Console.WriteLine(request);
                requested = Console.ReadLine();
            } while (!DateTime.TryParse(requested, out output));

            return output;
        }
    }
}
