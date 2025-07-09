using DiceRollGame.UserCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        //build with SRP - single responsibilty principle
       
            private readonly Dice _dice;
            private const int InitialTries = 3; // 3 tries

            public GuessingGame(Dice dice)
            {
                _dice = dice;
            }
            public GameResult Play()
            {
                var diceRollResult = _dice.Roll();
                Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries.");
                var triesLeft = InitialTries;

                while (triesLeft > 0)
                {
                    var userGuess = ConsoleReader.ReadInteger("Enter a number");
                    if (userGuess == diceRollResult)
                    {
                        return GameResult.Victory;
                    }
                    Console.WriteLine($"Wrong number");
                    --triesLeft;
                }
                return GameResult.Loss;
            }

            public static void PrintResult(GameResult gameResult)
            {
                string message = (gameResult == GameResult.Victory) ? "You win!" : "You lose:(";
                Console.WriteLine(message);
            }
        }
    
}
