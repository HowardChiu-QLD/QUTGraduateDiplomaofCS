using System;

namespace QueenslandCompetietionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#");
            Console.WriteLine("*The Star Shine in Queensland*");
            Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#");
            Console.WriteLine("------------------------------------");
            int adult;
            int child;
            int senior;
            int SUMofAll;
            Console.WriteLine("How many adult tickets have been sold?");
            adult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many senior tickets have been sold?");
            senior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many children tickets have been sold?");
            child = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0} adult ticket have been sold.", adult);
            Console.WriteLine("{0} senior ticket have been sold.", senior);
            Console.WriteLine("{0} children ticket have been sold.", child);
            Console.WriteLine("---------------------------------");
            double price;
            double adultprofit;
            double seniorprofit;
            double childprofit;
            double Totalprofit;
            Console.WriteLine("How much do you want to sell for an adult ticket?");
            Console.WriteLine("---------------------------------");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            adultprofit = adult * price;
            seniorprofit = senior * price * 0.7;
            childprofit = child * price * 0.5;
            Totalprofit = adultprofit + seniorprofit + childprofit;
            Console.WriteLine("You have made ${0} profit out of adult tickets' sale.", adultprofit);
            Console.WriteLine("You have made ${0} profit out of senior tickets' sale.", seniorprofit);
            Console.WriteLine("You have made ${0} profit out of children tickets' sale.", childprofit);
            Console.WriteLine("You have made ${0} profit in total.", Totalprofit);
            Console.WriteLine("---------------------------------");
            SUMofAll = adult + child + senior;
            Console.WriteLine("There are {0} adult tickets sold.", adult);
            Console.WriteLine("There are {0} children tickets sold.", child);
            Console.WriteLine("There are {0} senior tickets sold.", senior);
            Console.WriteLine("There are {0} visitores attending.", SUMofAll);
            Console.WriteLine("------------------------------------");
            if (adult <= child + senior)
            {
                Console.WriteLine("The competition is becoming a festival for everyone!");
            }
            if (child >= senior)
            {
                Console.WriteLine("The competition is attracting more and more young people!");
            }
            else
            {
                Console.WriteLine("The competition should have more space for kids!");
            }
        }
    }
}
