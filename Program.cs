using System;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select the level you wish to play
            Console.WriteLine("WELCOME TO GUESSING GAME");
            Console.WriteLine("Enter 1 for EASY");
            Console.WriteLine("Enter 2 for MEDIUM");
            Console.WriteLine("Enter 3 for HARD");

            var canConvertOne = Int32.TryParse(Console.ReadLine(), out int inputNumber);
            if(!canConvertOne)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            
            if(inputNumber < 1 || inputNumber > 3)
            {
                Console.WriteLine("Invalid selection");
                return;
            }
            
            var random = new Random();
            
            switch (inputNumber)
            {
                case 1:          
                    Console.WriteLine("EASY LEVEL!");
                    Console.WriteLine("You are to guess correctly the hidden number between 1 to 10, and you have 6 maximum guessing chance. Goodluck!");
                    
                    var randomNumberOne = random.Next(1, 10);
                    
                    const int FirstLimit = 6;
                    
                    for (var i=1; i<=FirstLimit; i++)
                    {   
                        Console.WriteLine("Enter your guess number!");
                        var canConvertTwo = Int32.TryParse(Console.ReadLine(), out int guessNumberOne);
                    
                        if(!canConvertTwo || guessNumberOne < 1  || guessNumberOne > 10)
                        {
                            Console.WriteLine("Invalid input");
                            return;
                        }

                        if(guessNumberOne != randomNumberOne)
                        {
                            if(i < (FirstLimit-1)) 
                            {
                                Console.WriteLine("That was wrong! You have {0} more chances to go.", (FirstLimit-i));
                            }
                            
                            else if (i == (FirstLimit-1))
                            {
                                Console.WriteLine("That was wrong! You have {0} guessing chance.", (FirstLimit - i));
                            }
                            
                            else
                            {
                                Console.WriteLine("Game Over!");
                                Console.WriteLine("The correct number is: " + randomNumberOne);
                            }
                        }

                        else
                        {
                            Console.WriteLine("You got it right!");
                            return;
                        }
                    }
                break;
            
                case 2:
                    Console.WriteLine("MEDIUM LEVEL!");
                    Console.WriteLine("You are to guess correctly the hidden number between 1 to 20, and you have 4 maximum guessing chance. Goodluck!");
                    
                    var randomNumberTwo = random.Next(1, 20);
                    
                    const int SecondLimit = 4;
                    
                    for (var i=1; i<=SecondLimit; i++)
                    {   
                        Console.WriteLine("Enter your guess number!");
                        var canConvertThree = Int32.TryParse(Console.ReadLine(), out int guessNumberTwo);
                    
                        if(!canConvertThree || guessNumberTwo < 1  || guessNumberTwo > 20)
                        {
                            Console.WriteLine("Invalid input");
                            return;
                        }

                        if(guessNumberTwo != randomNumberTwo)
                        {
                            if(i < (SecondLimit-1)) 
                            {
                                Console.WriteLine("That was wrong! You have {0} more chances to go.", (SecondLimit-i));
                            }
                    
                            else if (i == (SecondLimit-1))
                            {
                                Console.WriteLine("That was wrong! You have {0} guessing chance.", (SecondLimit - i));
                            }
                    
                            else
                            {
                                Console.WriteLine("Game Over!");
                                Console.WriteLine("The correct number is: " + randomNumberTwo);
                            }
                        }

                        else
                        {
                            Console.WriteLine("You got it right!");
                            return;
                        }
                    }
                break;
            

                default:            
                    Console.WriteLine("HARD LEVEL!");
                    Console.WriteLine("You are to guess correctly the hidden number between 1 to 50, and you have 3 maximum guessing chance. Goodluck!");
                    
                    var randomNumberThree = random.Next(1, 50);
                    
                    const int ThirdLimit = 3;
                    
                    for (var i=1; i<=ThirdLimit; i++)
                    {   
                        Console.WriteLine("Enter your guess number!");
                        var canConvertFour = Int32.TryParse(Console.ReadLine(), out int guessNumberThree);
                    
                        if(!canConvertFour || guessNumberThree < 1  || guessNumberThree > 50)
                        {
                            Console.WriteLine("Invalid input");
                            return;
                        }

                        if(guessNumberThree != randomNumberThree)
                        {
                            if(i < (ThirdLimit-1)) 
                            {
                                Console.WriteLine("That was wrong! You have {0} more chances to go.", (ThirdLimit-i));
                            }
                    
                            else if (i == (ThirdLimit-1))
                            {
                                Console.WriteLine("That was wrong! You have {0} guessing chance.", (ThirdLimit - i));
                            }
                    
                            else
                            {
                                Console.WriteLine("Game Over!");
                                Console.WriteLine("The correct number is: " + randomNumberThree);
                            }
                        }

                        else
                        {
                            Console.WriteLine("You got it right!");
                            return;
                        }
                    }
                break;
            }
        }
    }
}

