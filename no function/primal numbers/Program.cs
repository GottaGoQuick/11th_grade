using System.Diagnostics.Metrics;

namespace primal_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* במתמטיקה מספר נקרא ראשוני אם הוא מתחלק רק בעצמו ובאחד. לדוגמה: 2,3,5,7 הם מספרים ראשוניים ואילו 4 אינו ראשוני, כי 2 מחלק אותו. 
כיתבו תכנית הקולטת המדפיסה את כל המספרים הראשוניים בין 1 ל 1000 
            */
            int counter2 = 0;
            int counter = 0;
            for (int num = 1; num <= 1000; num++)
            {
                counter = 0;
                for (int j = 1; j <= num; j++)
                {
                    if (num%j == 0)
                    {
                        counter++;
                    }
                }
                if (counter <= 2&&num!=1) 
                {
                    Console.WriteLine("{0} is a primal number", num);
                    counter2++;
                }
                
            }
            Console.WriteLine("there is {0} primal numbers between 1-1000",counter2);


        }
    }
}
