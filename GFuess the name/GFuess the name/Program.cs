using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFuess_the_name
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomGuess = 0;
            int counter = 1;
            string userGuess;
            string playAgain;
            Console.WriteLine("Welcome to Guess the Number");
            Console.WriteLine("");
            Console.WriteLine("By Euan Comrie");
            Console.WriteLine("");
            Console.WriteLine("Guess a random number Genrated by the computer");
            Console.WriteLine("");


            Random rand = new Random();
            int randomNumber = rand.Next(1,11);

            // Console.WriteLine("The secret number is " + secretNumber);

            userGuess = Console.ReadLine();
            randomGuess = Convert.ToInt32(userGuess);

           

            while (randomGuess != randomNumber )
            {
                if (randomGuess < randomNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Guess was too low please guess again"); 
                    Console.WriteLine("");
                    userGuess = Console.ReadLine();
                    randomGuess = Convert.ToInt32(userGuess);
                    counter = counter + 1;

                }

                else if (randomGuess > randomNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Guess was too high please guess again");
                    Console.WriteLine("");
                    userGuess = Console.ReadLine();
                    randomGuess = Convert.ToInt32(userGuess);
                    counter = counter + 1;

                }
            }
            Console.WriteLine("");

            Console.WriteLine("Well done you have been able to guess the random number. You took " + counter + " attempts ");

            Console.WriteLine("Done you want to play again y/n");
            Console.WriteLine("");
            playAgain = Console.ReadLine();
            Console.WriteLine("");

            while (playAgain == "y")
            {
                int randomGuess2 = 0;
                int counter2 = 1;
                string userGuess2;
                string playAgain2;
                Console.WriteLine("Welcome to Guess the Number");
                Console.WriteLine("");
                Console.WriteLine("By Euan Comrie");
                Console.WriteLine("");
                Console.WriteLine("Guess a random number Genrated by the computer");
                Console.WriteLine("");

                Random rand2 = new Random();
                int randomNumber2 = rand.Next(1, 11);

                // Console.WriteLine("The secret number is " + secretNumber);

                userGuess2 = Console.ReadLine();
                randomGuess2 = Convert.ToInt32(userGuess);



                while (randomGuess2 != randomNumber2)
                {
                    if (randomGuess2 < randomNumber2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Guess was too low please guess again");
                        Console.WriteLine("");
                        userGuess2 = Console.ReadLine();
                        randomGuess2 = Convert.ToInt32(userGuess2);
                        counter2 = counter2 + 1;

                    }

                    else if (randomGuess2 > randomNumber2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Guess was too high please guess again");
                        Console.WriteLine("");
                        userGuess2 = Console.ReadLine();
                        randomGuess2 = Convert.ToInt32(userGuess2);
                        counter2 = counter2 + 1;

                    }
                    
                }
                Console.WriteLine("");

                Console.WriteLine("Well done you have been able to guess the random number. You took " + counter2 + " attempts ");

                Console.WriteLine("Done you want to play again y/n");
                Console.WriteLine("");
                playAgain = Console.ReadLine();
                Console.WriteLine("");
            }
             if (playAgain == "n")
            {
                Console.WriteLine("Thanks for playing");
            }

 






            Console.ReadKey();









        }
    }
}
