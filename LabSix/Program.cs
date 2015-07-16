using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
           // runpersons();
            runproduct();

        }
        static void runpersons()
        {
            List<Person> nameList = new List<Person>();
            string firstName;
            string lastName;

            string[] lines = File.ReadAllLines(@"C:\Users\mahmood\Documents\myfile.txt");

            //storing all names in person type and adding to list
            //assuming each line has one name
            foreach (string line in lines)
            {
                string name = line;
                string[] words = name.Split(' ');
                firstName = words[0];
                lastName = words[1];

                Person p = new Person(firstName, lastName);
                nameList.Add(p);
            }

            foreach (Person p in nameList)
            {
                p.print();
            }

        }
        static void runproduct()
        {
            string name;
            string manf;
            decimal cost;
            Dictionary<string , Product> ProductCatalogue= new Dictionary<string , Product>();
            Console.WriteLine("Please enter the number of products you want to add");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter the Desc of products");
                 name= Console.ReadLine();
                
                Console.WriteLine("Please enter the Manufacturer of products");
                 manf = Console.ReadLine();

                 Console.WriteLine("Please enter the cost of products");
                 cost = int.Parse(Console.ReadLine());

                //adding to dictionary
                 Product myp = new Product(name,cost,manf);
                 ProductCatalogue.Add(name,myp);
            }
            foreach (KeyValuePair<string, Product> item in ProductCatalogue)
            {
                item.Value.printproduct();
            }


        }
    }
}

