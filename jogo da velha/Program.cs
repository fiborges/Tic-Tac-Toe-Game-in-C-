// See https://aka.ms/new-console-template for more information
using System;

namespace JogoDaVelha
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // By default player 1 starts
        static int choice; // User choice for position
        static int flag = 0; // 1: game won, -1: game draw, 0: continue playing

        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); // Whenever loop restarts we clear the console
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Turno do Player 2");
                }
                else
                {
                    Console.WriteLine("Turno do Player 1");
                }
                Console.WriteLine("\n");
                Board(); // calling the board Function
                choice = int.Parse(Console.ReadLine()); // Taking users choice

                // checking that position where user want to run is marked (with X or O) or not
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) // if player2 turn then mark O else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                // If there is any possition where user want to run
                // and that is already marked then show message and load board again
                {
                    Console.WriteLine("Desculpe, a linha {0} já está marcada com um {1}.", choice, arr[choice]);
                    Console.WriteLine("\n");
                }
                flag = CheckWin(); // calling of check win
            }
            while (flag != 1 && flag != -1);

            Console.Clear(); // When loop is over we clear the console
            Board(); // calling the board Function
            if (flag == 1)
            {
                Console.WriteLine("Player {0} venceu!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Empate!");
            }
            Console.ReadLine();
        }

        // Board method which creats board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        // Checking that any player has won or not
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            // Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            // Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            // Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion

            #region Vertical Winning Condtion
            // Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            // Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            // Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all cells are filled with X or O then no player has won
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    }
}

