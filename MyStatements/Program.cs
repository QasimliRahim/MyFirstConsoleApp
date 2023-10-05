using MyObjectsLibrary;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Web;

namespace MyStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

             string name = "Rahim";


             showFiveTimes(name);

            threeTimes(name);

            sevenTimes(name);

             Console.Write("ayi bura girin:");

            string month = Console.ReadLine();

            showMonth(month);


            string[] fruits = { "alma", "armud", "nar", "uzum", "heyva", "banan", "mandalin", "apresin", "ananas", "kivi" };

            showFruits(fruits);


            Animal MyfirstAnimal = new Animal();

            Animal MySecondAnimal = new Animal();

            MyfirstAnimal.MakeNoise("hav hav hav");

            MySecondAnimal.MakeNoise("mo mo mo");

            Random rnd = new Random();


            int FirstRandom = rnd.Next(1, 10);

            MyfirstAnimal.Kitten(FirstRandom);

            Animal ChildAnimal = MyfirstAnimal.GetNewAnimal();



            Console.WriteLine(ChildAnimal.Name);



            MyfirstAnimal.Speed = 10;

            MyfirstAnimal.IncreaseSpeed(20);


            MySecondAnimal.Speed = 5;

            MySecondAnimal.IncreaseSpeed(10);


            Console.WriteLine(MyfirstAnimal.Speed);
            Console.WriteLine(MySecondAnimal.Speed);

            Console.WriteLine(MyfirstAnimal.Enviroment);

            Console.WriteLine(MySecondAnimal.Enviroment);


            Animal ChildGetLamb = MyfirstAnimal.GetWhiteLamb();
            Console.WriteLine(ChildGetLamb.Name);

            Animal ChildBlackLamb = MySecondAnimal.GetBlackLamb();

            Console.WriteLine(ChildBlackLamb.Name);



            Console.ReadLine();

          



        }


        public static void showFiveTimes(string textToShow)
        {


            int counter = 0;





            while (counter < 5)
            {

                Console.WriteLine(textToShow);

                counter = counter + 1;


            }
            

        }



        public static void threeTimes(string showThreeTimes)
        {



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(showThreeTimes);
            }

           
        }


        public static void sevenTimes(string showSevenTimes)
        {

            int counter = 0;

            do
            {



                Console.WriteLine(showSevenTimes);
                counter = counter + 1;

            } while (counter < 7);

        
        }



        public static void showMonth(string month)
        {
            string[] months = { "yanvar", "fevral", "mart", "aprel", "may", "iyun", "iyul", "avqust", "sentyabr", "oktyabr", "noyabr", "dekabr" };


            foreach (string item in months)
            {

                if (item == month)
                {

                    switch (month)
                    {
                        case "yanvar":

                            Console.WriteLine("Hava soyuqdur");
                            break;


                        case "fevral":

                            Console.WriteLine("Hava soyuqdur");
                            break;

                        case "mart":
                            Console.WriteLine("Hava soyuqdur");
                            break;

                        case "aprel":
                            Console.WriteLine("Hava yagislidir");
                            break;

                        case "may":
                            Console.WriteLine("Hava istidir");
                            break;

                        case "iyun":
                            Console.WriteLine("Hava istidir");
                            break;

                        case "iyul":
                            Console.WriteLine("Hava istidir");
                            break;

                        case "avqust":
                            Console.WriteLine("Hava istidir");
                            break;

                        case "sentyabr":
                            Console.WriteLine("Hava istidir");
                            break;


                        case "oktyabr":
                            Console.WriteLine("Hava yagislidir");
                            break;

                        case "noyabr":
                            Console.WriteLine("Hava yagislidir");
                            break;

                        case "dekabr":
                            Console.WriteLine("Hava soyuqdur");
                            break;
                    }


                }
              


            }








        }


        public static void showFruits(string[] fruits)
        {
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

       

        

    }

  
}
