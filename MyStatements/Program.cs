using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

              string name = "Rahim";


            // showFiveTimes(name);

            //threeTimes(name);


            sevenTimes(name);


        }


      public static void showFiveTimes(string textToShow)
        {
          

            int counter = 0;


            /* 0 < 5  true
             * 1 < 5   true
             * 2 < 5   true
             * 3 < 5 true
             * 4 < 5  true
             * 5 < 5  false
             *
             *
             *
             *
             *
             *
             *
             */



            while (counter < 5)
            {
             
                Console.WriteLine(textToShow);

                counter = counter + 1;
               

            }
            Console.ReadLine();

        }


        public static void threeTimes(string showThreeTimes)
        {

           

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(showThreeTimes);
            }

            Console.ReadLine();
        }


        public static void sevenTimes(string showSevenTimes)
        {

            int counter = 0;

            do
            {

             

                Console.WriteLine(showSevenTimes);
                counter = counter + 1;

            } while (counter < 7);

            Console.ReadLine();
        }

    }
}
