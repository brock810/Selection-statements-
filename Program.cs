
using System.Net.Http.Headers;

namespace Selection_statements_2
{
    class program
    {
       public static void Main(string[] args)
        {
            var userGuess = int.Parse(Console.ReadLine());
            var favouriteNumber = 694;

            if (userGuess < favouriteNumber)
            {
                Console.WriteLine($"TOO low");
            }
            else if (userGuess > favouriteNumber)
            {
                Console.WriteLine($"TOO high");
            }
            if (userGuess == favouriteNumber)
            {
                Console.WriteLine($"You got it!");

                Console.WriteLine("What is your favorite subject?");

                string subject = Console.ReadLine();

                switch (subject)
                {
                    case "Math":
                        Console.WriteLine("I hate math");
                        break;
                    case "Science":
                        Console.WriteLine("I love science");
                        break;
                    case "Gym":
                        Console.WriteLine("Gym is awesome");
                        break;
                    case "History":
                        Console.WriteLine("History is radical");
                        break;
                    case "Geo":
                        Console.WriteLine("Geo sucks");
                        break;
                    default:
                        Console.WriteLine("I don't know that subject");
                        break;
                }



            }


            }

        }

    }

