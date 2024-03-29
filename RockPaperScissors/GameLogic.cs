﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_RockPaperScissors
{
    public class GameConsole
    {
        public static List<string> scissor = new List<string>()
        {
            "O O",
            " X ",
            "/ \\"
        };

        public static List<string> paper = new List<string>()
        {
            "___",
            "| |",
            "---"
        };

        public static List<string> rock = new List<string>()
        {
            " n ",
            "< >",
            " u "
        };

        public static List<KeyValuePair<string, string>> gameMenu = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("R", "Rock"),
            new KeyValuePair<string, string>("S", "Scissor"),
            new KeyValuePair<string, string>("P", "Paper"),
            new KeyValuePair<string, string>("Q", "EXIT")
        };

        public static string PrintGameResult(bool userWinConfirmation, string computerChoice)
        {
            return (userWinConfirmation) ? "Congratulations, you won this round!" : $"Unfortunately, you lost to the computer who played {computerChoice}!";
        }
        
        public static void RunConsole()
        {
            ConsoleKeyInfo userInput;
            do
            {
                Random randomNum = new Random();
                KeyValuePair<string, string> computerInput = gameMenu.ElementAt(randomNum.Next(gameMenu.Count - 1));
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Shoot!");
                Console.WriteLine("This small game is played through your terminal.");
                Console.WriteLine("Look at the menu below and enter the button of your choice or type 'Q' to exit:");
                foreach (KeyValuePair<string, string> option in gameMenu)
                {
                    Console.WriteLine($"{option.Key} {option.Value}");
                }
                userInput = Console.ReadKey(true);
                switch(userInput.Key.ToString())
                {
                    case "Q":
                        break;
                    case "R":
                        Console.WriteLine("\n");
                        foreach(string piece in rock)
                        {
                            Console.WriteLine(piece);
                        }
                        Console.WriteLine("\n");
                        break;
                    case "S":
                        Console.WriteLine("\n");
                        foreach (string piece in scissor)
                        {
                            Console.WriteLine(piece);
                        }
                        Console.WriteLine("\n");
                        break;
                    case "P":
                        Console.WriteLine("\n");
                        foreach (string piece in paper)
                        {
                            Console.WriteLine(piece);
                        }
                        Console.WriteLine("\n");
                        break;
                }
                if(userInput.Key.ToString() == "Q")
                {
                    break;
                }
                else if (computerInput.Key == userInput.Key.ToString())
                {
                    Console.WriteLine($"Draw! You both played {computerInput.Value}");
                }
                else
                {
                    bool didPlayerWin = ((computerInput.Key == "P" && userInput.Key.ToString() == "S") || (computerInput.Key == "R" && userInput.Key.ToString() == "P") || (computerInput.Key == "S" && userInput.Key.ToString() == "R")) ? true : false;
                    Console.WriteLine(PrintGameResult(didPlayerWin, computerChoice: computerInput.Value));
                }
                } while (userInput.Key.ToString() != "Q");
        }
    }
}
