using System;
class Program{
    static void Main() {
        Console.WriteLine("Welcome to the Dice Game!");
        Round();
            
        static void Round() {
            var Dice = Roll();
            int MyTotal = Dice.Item1 + Dice.Item2;
            int CTotal = Dice.Item3 + Dice.Item4;

            Console.WriteLine("\nYour Roll");
            Console.WriteLine($"You rolled a {Dice.Item1} and a {Dice.Item2}");
            Console.WriteLine($"Total is {MyTotal}\n");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.WriteLine("\nComputer's Roll");
            Console.WriteLine($"Computer rolled a {Dice.Item3} and a {Dice.Item4}");
            Console.WriteLine($"Total is {CTotal}\n");
            Console.WriteLine("You" + " " + Result(MyTotal, CTotal) + "\n");
            Console.WriteLine("Play again? y or n");
            string Input = Console.ReadLine();
            if (Input == "y") {
                Round();
            }
            else {
                return;
            }
        }

        static (int, int, int, int) Roll() {
            Random Num = new();
            int Dice1 = Num.Next(1, 7);
            int Dice2 = Num.Next(1, 7);
            int Dice3 = Num.Next(1, 7);
            int Dice4 = Num.Next(1, 7);
            return (Dice1, Dice2, Dice3, Dice4);
        }

        static string Result(int Total, int CTotal) {
            if (Total > CTotal) {
                return "WON :)";
            }
            else if (Total < CTotal) {
                return "LOST :(";
            }
            else {
                return "DREW :|";
            }
        }
    }
}

