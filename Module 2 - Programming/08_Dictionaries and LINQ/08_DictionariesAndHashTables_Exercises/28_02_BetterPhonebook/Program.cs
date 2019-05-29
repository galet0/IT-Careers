using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_02_BetterPhonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string line = Console.ReadLine();

            while (!line.Equals("END"))
            {
                string[] input = line.Split();

                switch (input[0])
                {
                    case "A":
                        string name = input[1];
                        string number = input[2];
                        AddContact(phonebook, name, number);
                        break;
                    case "S":
                        string searchedName = input[1];
                        bool isFound = SearchContact(phonebook, searchedName);
                        if (isFound)
                        {
                            Console.WriteLine("{0} -> {1}", searchedName, phonebook[searchedName]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", searchedName);
                        }
                        break;
                    case "ListAll":
                        ListAll(phonebook);
                        break;

                }

                line = Console.ReadLine();
            }
            
        }

        static void ListAll(SortedDictionary<string, string> phonebook)
        {
            foreach (var contact in phonebook)
            {
                Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
            }
        }

        static bool SearchContact(SortedDictionary<string, string> phonebook, string searchedName)
        {
            bool isFound = false;

            if (phonebook.ContainsKey(searchedName))
            {
                isFound = true;
            }

            return isFound;
        }

        static void AddContact(SortedDictionary<string, string> phonebook, string name, string number)
        {
            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, number);
            }

            phonebook[name] = number;
        }
    }
}
