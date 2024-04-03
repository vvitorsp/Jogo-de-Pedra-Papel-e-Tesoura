using System;
using System.Reflection.Metadata;

class program
{
    static void Main ()
    {
        int randomNumber;
        string userAnswer;
        bool playAgain = true;
        string machineChoices;

        Random random = new Random();

        while (playAgain)
        {
            randomNumber = random.Next(1,4);
            machineChoices = "";

            if (randomNumber == 1)
            {
                machineChoices = "Rock";         
            } else if (randomNumber == 2)
            {
                machineChoices = "paper";
            }
            else if (randomNumber == 3)
            {
                machineChoices = "Scissors";
            }
           machineChoices = machineChoices.ToUpper();

            Console.WriteLine("Rock, paper or Scissors: ");
            userAnswer = Console.ReadLine();
            userAnswer = userAnswer.ToUpper();

              if (userAnswer == machineChoices)
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("It is a draw!");
            } else if (userAnswer == "ROCK" && machineChoices == "PAPER")
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("YOU LOSE!");
            } else if (userAnswer == "ROCK" && machineChoices == "SCISSORS")
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("YOU WIN!");
            } else if(userAnswer == "PAPER" && machineChoices == "SCISSORS")
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("YOU LOSE!");
            } else if (userAnswer == "PAPER" && machineChoices == "ROCK")
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("YOU WIN!");
            } else if (userAnswer == "SCISSORS" && machineChoices == "ROCK")
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("YOU lOSE!");
            } else if (userAnswer == "SCISSORS" && machineChoices == "PAPER")
            {
                Console.WriteLine("Player: " + userAnswer);
                Console.WriteLine("Machine: " + machineChoices);
                Console.WriteLine("YOU WIN!");
            } else
            {
                Console.WriteLine("Resposta invalida!");
            }

            Console.WriteLine("Do you wanna play again? (Y/N)");
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();

            if (userChoice == "Y")
            {
                playAgain = true;
            }else if (userChoice == "N")
            {
                playAgain = false;
                Console.WriteLine("Thanks for play!");
            }
            Console.ReadKey();
        }
    }
}