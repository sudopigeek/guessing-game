using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Welcome to Guessing Game! ====");
            Console.Write("What difficulty do you want (Cheater, Easy, Medium, or Hard)? ");
            string difficulty = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(difficulty))
            {
                Console.WriteLine("**Difficulty set to Easy.");
                difficulty = "Easy";
            }
            else
            {
                Console.WriteLine("**Difficulty set to {0}.", difficulty);
            }
            int? diff = null;
            switch (difficulty)
            {
                case "cheater":
                    diff = 10;
                    break;
                case "easy":
                    diff = 8;
                    break;
                case "medium":
                    diff = 6;
                    break;
                case "hard":
                    diff = 4;
                    break;
            }
            int secretNum = new Random().Next(0, 101);
            int? number = null;
            for (int i = 0; i < diff; i++)
            {
                if (number == null)
                {
                    Console.Write("Guess the secret number: ", number);
                }
                else
                {
                    Console.Write("Guess the secret number (you last guessed {0}): ", number);
                }
                number = int.Parse(Console.ReadLine());
                if (number == secretNum)
                {
                    Console.WriteLine("Congratulations! You guessed the right number!");
                    break;
                }
                else
                {
                    if ((3 - i) == 1)
                    {
                        if (number > secretNum)
                        {
                            Console.WriteLine("Your number was too high, you have {0} guess left.", 3 - i);
                        }
                        else if (number < secretNum)
                        {
                            Console.WriteLine("Your number was too low, you have {0} guess left.", 3 - i);
                        }
                    }
                    else
                    {
                        if ((3 - i) == 0)
                        {
                            if (number > secretNum)
                            {
                                Console.WriteLine("Your number was too high, and you don't have any guesses left.\n");
                            }
                            else if (number < secretNum)
                            {
                                Console.WriteLine("Your number was too low, and you don't have any guesses left.\n");
                            }
                        }
                        else
                        {
                            if (number > secretNum)
                            {
                                if (difficulty == "cheater")
                                {
                                    Console.WriteLine("Your number was too high, and you have more guesses left than you can count.\n", 3 - i);
                                }
                                else
                                {
                                    Console.WriteLine("Your number was too high, and you have {0} guesses left.\n", 3 - i);
                                }

                            }
                            else if (number < secretNum)
                            {
                                if (difficulty == "cheater")
                                {
                                    Console.WriteLine("Your number was too low, and you have more guesses left than you can count.\n", 3 - i);
                                }
                                else
                                {
                                    Console.WriteLine("Your number was too low, and you have {0} guesses left.\n", 3 - i);
                                }
                            }
                        }
                    }
                }

                if (diff == 10)
                {
                    i = 0;
                }
            }
        }
    }
}
