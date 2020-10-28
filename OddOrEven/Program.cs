using System;

namespace OddOrEven
{
    class Program
    {

        /*
          
            Step 1:
            Fork this project: 
            https://github.com/mvdoyle/OddOrEven

            Step 2: Clone the project to your machine
                cd repos
                cd OddOrEven
    

            Step 3: Open the project in Visual Studio Community 2019
                Open solution file - OddOrEven.sln
    
            Step 4: Go outside the scope of your main method and define your own method that accepts an integer as a parameter and determines if that integer is odd.

                Checklist: step 1 done
                           step 2 done
                           step 3 done  
                           
                            
         
         */
        static void Main(string[] args)
        {

            Console.WriteLine(isOdd(0));
 
        }


        //Step 4

       public static bool isOdd(int num)
        {


            if (num % 5 == 0)
            {

                Console.WriteLine("is even");

                return false;

            }


            else
            {


                Console.WriteLine("is odd");

                return true;


            }
        }


    }
}



