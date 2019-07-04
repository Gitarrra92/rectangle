using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                GiveData();

               

                Console.WriteLine("Do you want to continue? Y/N");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Thank you");
                    return;
                }
                else
                {
                    
                        Console.WriteLine("wrong answer");
            

                }
            }

        }

        static void GiveData()
        {
            Console.WriteLine("Give rectangle length");
            string a = Console.ReadLine();
            int x = Int32.Parse(a);
            Console.WriteLine("Your length is {0} ", x);

            Console.WriteLine("Give rectangle height");
            string b = Console.ReadLine();
            int y = Int32.Parse(b);
            Console.WriteLine("Your length is {0} ", y);

            int z = x * y;
            Console.WriteLine("wynik {0}", z);

            for (int i = 1; i <= x; i++)
            {
                Console.Write("o");
                for (int j = 1; j <= y; j++)
                {
                    Console.Write("*");
                }
                Console.Write("o");
                Console.WriteLine();
            }
            //Console.ReadKey();
        }

       
    }
}
