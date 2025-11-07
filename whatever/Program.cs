using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static bool ABC(char letter)
        {
            for (char i = 'A'; i <= 'z'; i++)
            {
                if (letter == i)
                {
                    return true;
                }
            }
          
            return false;
        }
        static void Main(string[] args)
        {
            int counter = 0;
            bool found = false;
            char letter;
            int min = 0 ;
            for (int i = 1; i <= 20; i++)
            {
                counter = 0;
                found = false;
                while (found == false)
                {
                    Console.WriteLine("what is char");
                    letter=char.Parse(Console.ReadLine());
                    if (ABC(letter)==false)
                    {
                        found=true;
                    }
                    counter++;
                }
                if (i == 1)
                {
                    min = counter;
                }
                else if (counter < min)
                {
                    min = counter;
                }
                Console.WriteLine(counter);
            }
            Console.WriteLine(min);
         
        }
        
    }
}
