using LambdaExpressions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Add Records\n2.Retreiving Records For age less than Sixty\n3.Age Between 13 to 18\n4. Average Age\n5.Find Specific Name\n6.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PersonDataManagement.AddRecords(listPersonInCity);
                        break;
                    case 2:
                        PersonDataManagement.Retreiving_TopTwoRecords_ForAgeIs_LessThanSixty(listPersonInCity);
                        break;
                    case 3:
                        PersonDataManagement.Retreiving_Records_ForAgeBetween_thirteenToEighteen(listPersonInCity);
                        break;
                    case 4:
                        PersonDataManagement.Average_Age(listPersonInCity);
                        break;
                    case 5:
                        PersonDataManagement.FindSpecificName(listPersonInCity);
                        break;
                    case 6:
                        flag = false;
                        break;

                }
            }
        }
    }
}
