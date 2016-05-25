using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random numbers = new Random();
            int startNumber = 1;
            startNumber = numbers.Next(1, 2);
            Console.WriteLine(startNumber);

            bool gameOn = true;
            while (gameOn)
            {


                for (int sum = 1; sum <= 21; sum++)
                {

                    Console.WriteLine("Enter a higher number with 1 or 2!");
                    int playerInput = int.Parse(Console.ReadLine());
                    if (playerInput > sum + 2 || playerInput < sum + 1)
                    {
                        Console.WriteLine("Not a valid input!");
                        Console.WriteLine(sum);
                        break;
                    }
                    sum = playerInput + numbers.Next(1, 3);

                    if (sum == 21 || playerInput == 21)
                    {
                        Console.WriteLine("Congratulations, you won this round ....");
                        gameOn = false;

                    }
                    if (sum > 21)
                    {
                        Console.WriteLine("New game started:");
                        Random numbers2 = new Random();
                        int startNumber2 = 1;
                        startNumber = numbers.Next(1, 2);
                        Console.WriteLine(startNumber);
                        Console.WriteLine("Enter a higher number with 1 or 2!");
                        int playerInput2 = int.Parse(Console.ReadLine());
                        int sum2 = playerInput2 + numbers.Next(1, 3);
                    }

                    else
                    {
                        Console.WriteLine(sum);

                    }


                }




                Console.ReadLine();
            }
        }
    }
}
