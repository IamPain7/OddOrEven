using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Executing

            Console.WriteLine(IsOdd(5));




        }

        //Step 4 Creating own method

        public static bool IsOdd(int num)
        {


            if (num % 2 == 0)
            {

                Console.WriteLine(" is true");
                return false;

            }

            else
            {
                Console.WriteLine(" is even");
                return true;

            }



        }
    }
}


