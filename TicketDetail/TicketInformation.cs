using Apttus.Assignment.MovieTicket;
using System;
using System.Collections.Generic;
using Apttus.Assignment.MovieTicket.Enum;

namespace Apttus.MovieTicket.TicketDetail
{
    public class TicketInformation
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            List<Person> value = new List<Person>();
            List<Person> personList = new List<Person>();
            int ticketprice;
            string y= "y";
          
            // list of member in family
            Dictionary<string, Person> person = new Dictionary<string, Person>();
            personList.Add(new Person { Name = "Sushma", Age = 20, gender = Gender.Female });
            personList.Add(new Person { Name = "amar", Age = 67, gender = Gender.Male });
            personList.Add(new Person { Name = "rani", Age = 26, gender = Gender.Female });
            personList.Add(new Person { Name = "lalita", Age = 69, gender = Gender.Female });
            personList.Add(new Person { Name = "Ali", Age = 23 });
            Console.WriteLine("Member in the family ");
            foreach (var temp in personList)
            {
                  Console.WriteLine("NAME: " + temp.Name + "      "+ "AGE: " + temp.Age + "      " + "GENDER: " + temp.gender);
            }

            for (int j = 0; j < personList.Count; j++)
            {
                person.Add(personList[j].Name, personList[j]);
            }

            Console.WriteLine("How many ticket you want:");
            var member = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < member; i++)
            {
               Console.WriteLine("Enter the member name");
                var fetch = Console.ReadLine();
                value.Add(person[fetch]);
            }
             
            // check for discount
            Console.WriteLine("do you want discount y or n");
            if (Console.ReadLine()==y)
            {
                ticketprice = ticket.GetTotalCost(value);
            }
            else
            {
                ticketprice = ticket.GetTotalCost(value);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total cost of ticket is: "+ticketprice);
            Console.ReadLine();
        }
    }
}

