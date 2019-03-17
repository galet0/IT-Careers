using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_04_EmailRepairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            var name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                if (email.EndsWith(".us") || email.EndsWith(".uk"))
                {
                    phoneBook.Remove(name);
                }
                else
                {
                    phoneBook[name] = email;
                }

                name = Console.ReadLine();
            }
            foreach (var item in phoneBook)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            //Dictionary<string, string> emailbook = new Dictionary<string, string>();

            //while (true)
            //{
            //    string name = Console.ReadLine();
            //    if (name.Equals("stop"))
            //    {
            //        break;
            //    }
            //    string email = Console.ReadLine();

            //    if (!emailbook.ContainsKey(name))
            //    {
            //        emailbook.Add(name, "");
            //    }
            //    emailbook[name] = email;
            //}

            
            //foreach (var kvp in emailbook.Copy())
            //{
            //    if(kvp.Value.EndsWith(".us") || kvp.Value.EndsWith(".uk"))
            //    {
            //        emailbook.Remove(kvp.Key);
            //    }
            //    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            //}
            
            
        }
    }
}
