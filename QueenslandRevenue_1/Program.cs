using System;
using System.Linq;

namespace QueenslandRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contestentlastyear;

            Console.WriteLine("please enter the number of contestants last year");
            Contestentlastyear = Convert.ToInt32(Console.ReadLine());

            while (Contestentlastyear < 0 || Contestentlastyear > 30)
            {
                Console.WriteLine("Please enter valid number. Valid number is 0~30.");
                int y = Convert.ToInt32(Console.ReadLine());
                Contestentlastyear = y;

            }

            int Contestentthisyear;

            Console.WriteLine("please enter the number of contestants this year");
            Contestentthisyear = Convert.ToInt32(Console.ReadLine());

            while (Contestentthisyear < 0 || Contestentthisyear > 30)
            {
                Console.WriteLine("Please enter valid number. Valid number is 0~30.");
                int v = Convert.ToInt32(Console.ReadLine());
                Contestentlastyear = v;
            }

            Console.WriteLine("The number of contestent this year is {0}.", Contestentthisyear.ToString());
            Console.WriteLine("The number of contestent last year is {0}.", Contestentlastyear.ToString());
            //Step 3
            //Case 1
            if (Contestentthisyear > Contestentlastyear * 2)
                Console.WriteLine("The competition is more than twice as big this year!");
            //Case 2
            else if (Contestentlastyear * 2 >= Contestentthisyear || Contestentthisyear >= Contestentlastyear)
                Console.WriteLine("The competition is bigger than ever!");
            //Case 3
            if (Contestentthisyear < Contestentlastyear)
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");

            //Step 4

            int x;
            x = Contestentthisyear;
            string[] ContestentName = new string[x];
            string[] TalentCode = new string[x];

            for (x = 0; x < ContestentName.Length; x++)
            {
                Console.WriteLine("Please enter the contestent name.");
                ContestentName[x] = Console.ReadLine();
                Console.WriteLine("Please enter the talent code for the contestent.");
                TalentCode[x] = Console.ReadLine();

                //Validation of Talent Code input?
                string[] ValidCode = { "M", "S", "D", "O" };

                if (TalentCode[x] != ValidCode[x])
                {
                    Console.WriteLine("Please enter valid code. Valid Code are M for Music, S for Singing, D for Dancing, O for Other.");
                    TalentCode[x] = Console.ReadLine();
                }
                //display a count of each type of talent
                
    var TotalMusic = TalentCode.Count(s => s == "M");
    Console.WriteLine("We have {0} contestents with music talent", TotalMusic);
    var TotalDance = TalentCode.Count(m => m == "D");
    Console.WriteLine("We have {0} contestents with dancing talent", TotalDance);
    var TotalSing = TalentCode.Count(n => n == "S");
    Console.WriteLine("We have {0} contestents with singing talent", TotalSing);
    var TotalOther = TalentCode.Count(b => b == "O");
    Console.WriteLine("We have {0} contestents with other talent", TotalMusic);
                
                //display a list of the contestants with that code
                //I tried several steps, however, I just cannot execute the following code correctly. :(
               
                
                //string Talent;
                //string Name;
                //int a = TalentCode.Length - 1;
                //Console.WriteLine("Please enter talent code.");
                //Talent = Console.ReadLine();
               
                //while (a < TalentCode.Length && Talent != TalentCode[a])
                //  --a;
                //Name = TalentCode[a];
                //Console.WriteLine("The talent code represent {0}", Name);







            }
        }
    }
}
