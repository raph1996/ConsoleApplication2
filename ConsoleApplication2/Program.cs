using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet5776_01_
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1();
            Console.ReadKey();

        }

        private static void Question1()
        {
            //create an array with 100 nummbers

            int[] myarray = new Int32[100];
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                myarray[i] = Convert.ToInt32(r.Next(0, 1001));
            }

            int a;

            do
            {
                //ask the user to choice a num
                Console.WriteLine("Enter your choice: \n1.guess a num\n2.guess the number of apparition\n3.exit\n");

                string option = Console.ReadLine();
                a = int.Parse(option);


            switch (a)
                {
                    case 1:
                        if (GuessNumber(myarray) == true)
                            Console.WriteLine("Your number is in the array");
                        else
                            Console.WriteLine("Your number is not in the array");

                        break;


                    case 2:
                        if (GuessIntervall(myarray) == true)
                            Console.WriteLine("You guess true");
                        else
                            Console.WriteLine("You miss");

                        break;


                    case 3:
                        break;

                    default:
                        break;
                }
            } while (a == 3);



        }

        //function for the first case
        private static bool GuessNumber(params int[] myarray)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag=false;
            for (int i = 0; i < 100; i++)
            {
                if (myarray[i] == num)
                {
                    flag = true;
                    return flag;
                }

            }
            return false;

        }

        //function for the second case
        private static bool GuessIntervall(int[] myarray)
        {
            Console.WriteLine("Enter the first num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp;
            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("How many numbers do you think there is int the Intervall?");
            int guess = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (myarray[i] >= num1 && myarray[i] <= num2)
                    count++;
            }
            bool flag = false;
            if (count == guess)
                flag = true;

            return flag;


        }

    }
}