using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* קילטו שלישיות מספרים עד אשר שנקלטת שלישייה שסכומה גבוה מ 100
יש להדפיס את סכום של כל השלישיות וכמה שלישיות נקלטו
(אין להחשיב את הסכום הגדול מ 100 בחישוב)
            */
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int numfinal = 0;
            int counter = 0;
            while (num1 + num2 + num3 <= 100)
            {
                Console.WriteLine("give me a first number");
                 num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("give me a second number");
                 num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("give me a third number");
                 num3 = int.Parse(Console.ReadLine());
                numfinal = (num1 + num2 + num3); 
                if (numfinal <= 100)
                {
                    Console.WriteLine("the sum is not greater then 100 try again");
                    Console.WriteLine(" ");
                    counter++;
                }
            }
           
            Console.WriteLine("Great Job!");
            Console.WriteLine("your numbers together add up to more then 100 this is your numbers:");
            Console.WriteLine("your first number is = {0}",num1);
            Console.WriteLine("your second number is = {0}", num2);
            Console.WriteLine("your third number is = {0}", num3);
            Console.WriteLine("the amount of all of the numbers together is = {0}",numfinal);
            Console.WriteLine("the count of all the three numbers your put in prier to getting a sum of 100 or above is = {0}",counter);
            if (counter == 0)
            {
                Console.WriteLine("you got it on first attempt! maybe try again with more attempts to get diffrent information");
            }
        }
    }
}
