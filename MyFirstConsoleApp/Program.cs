using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rahim sen guclu olacaqsan. Bismillah !");

            // deyisen riyaziyyatdaki kimi a = 5 , a integer'dir
            string stopDeyisen = "";
            int a = 1;
            double b = 2.1;
            Boolean c = false;
            

            while (stopDeyisen != "stop" )
            {
                stopDeyisen = Console.ReadLine();

                if (stopDeyisen == "alma")
                {
                    Console.Write("qardas biz alma sevmirik!!");
                }

                if (stopDeyisen == "armud")
                {
                    Console.Write("cox sevirem armudu");
                }
                if (stopDeyisen == "calculate")
                {
                    Console.WriteLine("toplamaq ucun 1 basiniz;");
                    Console.WriteLine("Cixma ucun 2 basiniz;");
                    Console.WriteLine("Bolme ucun 3 basiniz;");
                    Console.WriteLine("Vurma ucun 4 basiniz;");
                    string secim = Console.ReadLine();

                    if (secim == "1")
                    {
                        string operator1 = "";
                        string operator2 = "";

                        Console.WriteLine("zehmet olmasa ilk reqemi yazin");
                        operator1 = Console.ReadLine();

                        Console.WriteLine("zehmet olmasa ikinci reqemi yazin");
                        operator2 = Console.ReadLine();

                        int sum = CalculateSUM (Convert.ToInt32(operator1), Convert.ToInt32(operator2));

                        Console.WriteLine("cemi: " + sum);

                       

                    }
                    if (secim == "2" )
                    {
                        string operator1 = "";
                        string operator2 = "";
                        Console.WriteLine("zehmet olmasa ilk reqemi yazin");
                        operator1 = Console.ReadLine();

                        Console.WriteLine("zehmet olmasa ikinci reqemi yazin");
                        operator2 = Console.ReadLine();


                        int sum = int.Parse(operator1) - int.Parse(operator2);

                        Console.WriteLine("ferq:" + sum);
                        
                    }

                    if (secim == "3")
                    {
                        string operator1 = "";
                        string operator2 = "";
                        Console.WriteLine("zehmet olmasa ilk reqemi yazin");
                        operator1 = Console.ReadLine();

                        Console.WriteLine("zehmet olmasa ikinci reqemi yazin");
                        operator2 = Console.ReadLine();


                        int sum = int.Parse(operator1) / int.Parse(operator2);

                        Console.WriteLine("nisbet:" + sum);

                    }

                    if (secim == "4")
                    {
                        string operator1 = "";
                        string operator2 = "";
                        Console.WriteLine("zehmet olmasa ilk reqemi yazin");
                        operator1 = Console.ReadLine();

                        Console.WriteLine("zehmet olmasa ikinci reqemi yazin");
                        operator2 = Console.ReadLine();


                        int sum = int.Parse(operator1) * int.Parse(operator2);

                        Console.WriteLine("hasil:" + sum);

                    }





                }


            };
        }


        public static int CalculateSUM(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        public static int CalculateMultiplication(int a, int b)
        {
            int sum = a * b;

            return sum;
        }


        public static int CalculateDivision(int a, int b)
        {
            int sum = a / b;

            return sum;
        }

    }
}
