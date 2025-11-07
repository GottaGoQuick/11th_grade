using System.Runtime.CompilerServices;

namespace triangle_without_an_inside
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a program that takes a number and makes a triangle without an inside
            string beforestar = "";
            string coolstar = "*";
            string star = "*";
            string air = "";
            string coolair = "";
            string stargoingup = "*";
            int numberwhichisimportant = 4;
            int reversej = 0;
            Console.WriteLine("give me a number");
            int part = int.Parse(Console.ReadLine());
            int prepart = part;
            if(part >= 5) 
            {
                Console.WriteLine(star);
            }
            else
            {
                Console.WriteLine("need a number bigger then 4");
                System.Environment.Exit(0);
            }
            for (int i = 1; i <= prepart - 1; i++)

            {
                if (part > 3 && i > 1 && i != prepart - 1)
                {

                    for (int j = 1; j <= part - numberwhichisimportant; j++)
                    {

                        if (j == 1)
                        {
                            star = coolstar;
                            reversej++;
                            coolair = "";
                        }
                        if (j <= reversej)
                        {
                            coolair = coolair + " ";
                            air = coolair;
                        }



                        if (j == part - numberwhichisimportant)
                        {
                            star = star + air;
                            part++;
                            j = part - numberwhichisimportant + 2;
                        }
                    }
                }
               

                    star = star + "*";
                if (i == prepart - 1)
                {
                    beforestar = star;
                }
                if (i != prepart - 1)
                {
                    Console.WriteLine(star);
                }

                if (star != beforestar && part > 3 && i > 1)
                {
                    star = beforestar;

                }
                if (i > 1)
                {

                    
                    stargoingup = stargoingup + "*";
                    if (i >= prepart - 1)
                    {


                        star = beforestar + stargoingup;
                        Console.WriteLine(star);
                    }





                }
            }
        }
    }
}