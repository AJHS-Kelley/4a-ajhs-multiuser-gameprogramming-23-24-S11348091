// Amaure Cooper, Program Template, v0.1
/*
Generate secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print game instructions including range and num. of guesses allowed.
   MATCH == first player to score 3 points.
   ROUND == guessing a specific number, until correct or no more attempts.
Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not.
      If guess is correct {
        Tell them they have gusseed correctly.
        Award the player a point.
    } else {    
          Tell them they are wrong. 
          Tell player if the guess is too high or too low
        Check to see if they have guesses remaining {
            If guess remain: {
                allow player to guess again.
            } else }
                  CPu wins the round.
        }
      }
    

*/
using System;

namespace numberGuess
{
    0 references
    class numberGuess 
    {
        static void Main(string[] args)
        {
           int secrectNumber = -1;
           int numGuesses = 0; // Number of guesses player is Allowed. 
           int numAttempts = 0; // Number of guesses TAKEN.
           int playersScore =0,
           int cpuScore = 0; 
           string difficulty = "";
           int rangeMIn = -1;
           int rangeMax = -1,
        
           Console.WriteLine("Welcome to the number Guess Game!\nYou will select a difficulty next.\n")
           Console.WriteLine("Easy Mode: Range is 0 - 10 with 4 guesses.\nNormal Mode: Range is 0 - 25 with 4 guesses. \nHard Mode: range is 0 - 50 with 4 guesses.")
          
           // DIFFICULTY SELECTION
           Console.WriteLine("Please type Easy, Normal, or Hard and press Enter.")
            difficuty = Console.ReadLine(); 
            // Console.ReadLine() will save to string by default.
            Console.WriteLine("You have selected " +diffcuilty);
            if(diffcuilty == "Easy") { 
                rangeMin = 0; 
                rangeMax = 0
                numGuesses = 4;
          
            }else if (Normal Mode) {
                // Code to run.
            } else if (Hard Mode)
                // Code to run.
            } else {
                // Code to run if no diffculity is seleted.
            }    
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax):
            Console.WrtieLine("Num. Guesses: " + numGuesses):



         -
        }
    }
}