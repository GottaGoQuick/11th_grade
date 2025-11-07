namespace yes_or_no_do_you_know
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* כיתבו תוכנית אשר קולטת שלם ומדפיסה כן(באנגלית) אם ספרת האחדות שווה לספרה השמאלית , 
             * אחרת תדפיס לא(באנגלית).
             */
            int digit1 = 0;
            int digit2 = 0;
            int checker = 0;
            int coolchecker = 0;
            while (checker==0)
            {
                coolchecker = 0;
                Console.WriteLine("give me a three or above digit number:");
                int num = int.Parse(Console.ReadLine());
                if (num > 99)
                {
                    digit1 = num % 10;
                    while (num > 0)
                    {
                        digit2 = num % 10;
                        num = num / 10;
                    }
                    if(digit1 == digit2)
                    {
                        checker++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("the number doesnt have three digits or its a negative try again!");
                    coolchecker++;
                }
                if (checker == 0&&coolchecker==0)
                {
                    Console.WriteLine("No");
                    checker++;
                }
                else if (coolchecker==0)
                {
                    Console.WriteLine("Yes");
                }
            }
            

        }
    }
}
