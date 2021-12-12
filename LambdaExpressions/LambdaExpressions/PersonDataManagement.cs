using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressions
{
    class PersonDataManagement
    {
        public static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("283456876", "John", "12 Main street,Newyork,NY", 15));
            listPersonInCity.Add(new Person("283456877", "SAM", "13 Main street,Newyork,NY", 25));
            listPersonInCity.Add(new Person("283456878", "Elen", "14 Main street,Newyork,NY", 35));
            listPersonInCity.Add(new Person("283456879", "Albert", "15 Main street,Newyork,NY", 45));
            listPersonInCity.Add(new Person("283456880", "Peter", "16 Main street,Newyork,NY", 55));
            listPersonInCity.Add(new Person("283456881", "Jack", "17 Main street,Newyork,NY", 65));

            foreach (var item in listPersonInCity)
            {
                Console.WriteLine("Name : " + item.SSN + "\t\tName: " + item.Name + "\t\tAddress" + item.Address + "\t\tAge" + item.Age + "\n");
            }
        }

        public static void Retreiving_TopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.Write("Name : " + person.Name + "\t\tAge: " + person.Age + "\n");
            }

        }
        public static void Retreiving_Records_ForAgeBetween_thirteenToEighteen(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)).ToList())
            {
                Console.Write("Name : " + person.Name + "\t\tAge: " + person.Age + "\n");
            }
        }
        public static void Average_Age(List<Person> listPersonInCity)
        {
            double average = listPersonInCity.Average(e => (e.Age));
            Console.Write(average);

        }
        public static void FindSpecificName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter the Name Of the Person you want to search for");
            string name = Console.ReadLine();

            if (listPersonInCity.Any(e => (e.Name == name)))
            {
                Console.WriteLine("Name found");

            }
            else
            {
                Console.WriteLine("Name not found");
            }

        }
        public static void SkipRecord(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.Where(e => (e.Age > 60)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge" + person.Age + "\n");
            }

        }
        public static void RemoveSpecificName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter the Name Of the Person you want to search for");
            string name = Console.ReadLine();
            var found = listPersonInCity.Find(e => (e.Name == name));

            if (found == null)
            {
                Console.Write("Nothing found");
            }
            else
            {
                listPersonInCity.Remove(found);
                Console.WriteLine("name removed from the list");
            }
        }
    }
}


        


    
        

    

