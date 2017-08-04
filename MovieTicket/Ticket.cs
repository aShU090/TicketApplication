using System.Collections.Generic;

namespace Apttus.Assignment.MovieTicket
{
    public class Ticket
    {
        public int Discount;
        public int GetCostOfTicket()
        {
            return 1000;
        }
        public int GetDiscount()
        {

            int ticketcost = GetCostOfTicket();
            Discount = ((ticketcost * 30) / 100);
            return Discount;
        }

        public int GetTotalCost(List<Person> per)
        {
            int cost;
            int cost1 = 0;
            int ticketcost = GetCostOfTicket();
            List<int> cos = new List<int>();

            foreach (var temp in per)
            {
                if (temp.Age > 60)
                {
                    var dis = GetDiscount();
                    cost = ticketcost - dis;
                }
                else

                {
                    cost = ticketcost;
                }

                cos.Add(cost);
            }

            for (int j = 0; j < cos.Count; j++)
            {
                cost1 += cos[j];
            }
            return cost1;
        }

    }
}


