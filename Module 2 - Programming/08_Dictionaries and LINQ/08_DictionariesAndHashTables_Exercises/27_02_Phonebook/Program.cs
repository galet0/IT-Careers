using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        string name = input[1];
                        string phoneNumber = input[2];
                        AddContact(phonebook, name, phoneNumber);
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
                }

                input = Console.ReadLine().Split();
            }
        }

        static bool SearchContact(Dictionary<string, string> phonebook, string searchedName)
        {
            bool isFound = false;
            foreach (var contact in phonebook)
            {
                if (contact.Key.Equals(searchedName))
                {
                    //Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                    isFound = true;
                }
                
            }
            return isFound;
        }

        static void AddContact(Dictionary<string, string> phonebook, string name, string phoneNumber)
        {
            if (phonebook.ContainsKey(name) == false)
            {
                phonebook.Add(name, phoneNumber);
            }

            phonebook[name] = phoneNumber;
        }
    }
}
