using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04_StudentClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, List<string>> classes = new Dictionary<string, List<string>>();
            while (!line.Equals("End"))
            {
                string[] command = line.Split();

                switch (command[0])
                {
                    //Add {име на ученика} {име на учебна паралелка}  
                    case "Add":
                        string studentName = command[1];
                        string className = command[2];
                        if (!classes.ContainsKey(className))
                        {
                            classes.Add(className, new List<string>());
                        }
                        classes[className].Add(studentName);
                        break;
                    //Transfer {име на ученика} From {име на паралелка1} To {име паралелка2} 
                    case "Transfer":
                        string student = command[1];
                        string classNameFrom = command[3];
                        string classNameTo = command[5];
                        if (!classes.ContainsKey(classNameTo))
                        {
                            classes.Add(classNameTo, new List<string>());
                        }

                        classes[classNameTo].Add(student);
                        classes[classNameFrom].Remove(student);
                        if(classes[classNameFrom].Count == 0)
                        {
                            classes.Remove(classNameFrom);
                        }
                        break;
                    //Merge {име на паралелка1}  {име на паралелка2} 
                    case "Merge":
                        string class1 = command[1];
                        string class2 = command[2];
                        classes[class2].AddRange(classes[class1]);
                        classes.Remove(class1);
                        break;
                   
                }
                line = Console.ReadLine();
            }

            Dictionary<string, List<string>> orderedClasses = classes
                .OrderByDescending(v => v.Value.Count)
                .ThenBy(k => k.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var item in orderedClasses)
            {
                Console.Write("Class name - {0}", item.Key);
                Console.WriteLine();
                foreach (var name in item.Value)
                {
                    Console.WriteLine("###{0}", name);
                }
            }
            Console.WriteLine();
        }
    }
}
