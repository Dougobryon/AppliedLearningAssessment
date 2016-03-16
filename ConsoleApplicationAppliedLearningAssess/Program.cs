using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAppliedLearningAssess
{
    class Program
    {
        static void Main(string[] args)
        {

            //NOTE: The final strings of closing brackets have been abbreviated for the sake of readability and brevity.**
            // ** If desired, the complete and working code for each is available.

            // Solution #1 Below

            Console.WriteLine("Enter Any Integer: ");
            int anyInteger = int.Parse(Console.ReadLine());
            if (anyInteger < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }




            //Solution #2 Below

            {
                double[] pointvalues = { 2.2, 4.4, 6.6, 8.8, 9.9 };
                Console.WriteLine(pointvalues[1]);
                //Console.ReadLine();
            }




            //Solution #3 Below


            double[] pointvalues2 = { 2.2, 4.4, 6.6, 8.8, 9.9 };
            foreach (double pointvalue in pointvalues2)
            {
                Console.Write("{0} ", pointvalue.ToString("N1"));
            }



            // Solution #4 Below

            Console.WriteLine("Enter a number: ");

            string text = Console.ReadLine();

            int value = 0;

            Int32.TryParse(text, out value);

            switch (value)
            {
                case 1:
                    Console.WriteLine("Only one?");
                    break;
                case 100:
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:
                    Console.WriteLine("Input not recognized.");
                    break;
            }

            Console.ReadLine();




        }
    }
}
