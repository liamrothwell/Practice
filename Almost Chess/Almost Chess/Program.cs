using System;
using System.Linq;

namespace Almost_Chess
{
    class Program
    {
        static void Main()
        {
            bool play = true;

            while (play)
            {
                string[,] grid = CreateGrid();

                string[,] CreateGrid()
                {
                    string[,] _grid = new string[8, 8];

                    for (int i = 2; i < 7; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            _grid[i, j] = " O ";
                        }
                    }

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            _grid[i, j] = " 1 ";
                        }
                    }

                    for (int i = 6; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            _grid[i, j] = " 2 ";
                        }
                    }

                    return _grid;
                }

                while (CheckForWinner() == string.Empty)
                {
                    Console.Clear();
                    PrintGrid();
                    PlayerOne();
                    Console.Clear();
                    PrintGrid();
                    PlayerTwo();

                }

                Console.WriteLine(CheckForWinner() + " Congratulations!");

                Console.WriteLine("Play again?");
                string playAgain = Console.ReadLine();
                if (playAgain == "no" || playAgain == "No" || playAgain == "n" || playAgain == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing, press any key to exit.");
                    Console.ReadKey();
                    play = false;
                }

                void PlayerOne()
                {
                    bool turnComplete = false;
                    while (turnComplete == false)
                    {
                        Console.WriteLine("Player One, its your turn.");
                        int[] currentCoordinates = GetCurrentCoordinates();
                        int[] desiredCoordinates = GetDesiredCoordinates();
                        if (grid[currentCoordinates[0] - 1, currentCoordinates[1] - 1] == " 1 ")
                        {
                            MovePiece(currentCoordinates, desiredCoordinates, " 1 ");
                            if (grid[currentCoordinates[0]-1, currentCoordinates[1]-1] == " O ")
                            {
                                turnComplete = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("No cheating! You can only move your own pieces.");
                        }

                    }
                }

                void PlayerTwo()
                {
                    bool turnComplete = false;
                    while (turnComplete == false)
                    {
                        Console.WriteLine("Player Two, its your turn.");
                        int[] currentCoordinates = GetCurrentCoordinates();
                        int[] desiredCoordinates = GetDesiredCoordinates();
                        
                        if (grid[currentCoordinates[0] - 1, currentCoordinates[1] - 1] == " 2 ")
                        {
                            MovePiece(currentCoordinates, desiredCoordinates, " 2 ");
                            if (grid[currentCoordinates[0]-1, currentCoordinates[1]-1] == " O ")
                            {
                                turnComplete = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No cheating! You can only move your own pieces.");
                        }
                        
                    }
                }

                string CheckForWinner()
                {
                    bool playerOne = true;
                    bool playerTwo = true;

                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (grid[i, j].Contains(" 1 "))
                            {
                                playerOne = false;
                            }

                            if (grid[i, j].Contains(" 2 "))
                            {
                                playerTwo = false;
                            }
                        }
                    }

                    if (playerOne)
                    {
                        return "Player One Wins.";
                    }

                    if (playerTwo)
                    {
                        return "Player Two Wins.";
                    }

                    return string.Empty;
                }



                int[] GetCurrentCoordinates()
                {
                    Console.Write("Enter current Co-Ordinates of the piece (X,Y) e.g. 3,6: ");
                    string currentInput = Console.ReadLine();
                    if (currentInput != null)
                    {
                        currentInput.Replace(" ", "");
                        string[] currentCoordinatesString = currentInput.Split(',');
                        int[] currentCoordinates = new int[2];
                        currentCoordinates[0] = Convert.ToInt32(currentCoordinatesString[1]);
                        currentCoordinates[1] = Convert.ToInt32(currentCoordinatesString[0]);
                        return currentCoordinates;
                    }
                    return null;
                }

                int[] GetDesiredCoordinates()
                {
                    Console.Write("Enter the desired Co-Ordinates (X,Y) e.g. 4,2: ");
                    string desiredInput = Console.ReadLine();
                    if (desiredInput != null)
                    {
                        desiredInput.Replace(" ", "");
                        string[] desiredCoordinatesString = desiredInput.Split(',');
                        int[] desiredCoordinates = new int[2];
                        desiredCoordinates[0] = Convert.ToInt32(desiredCoordinatesString[1]);
                        desiredCoordinates[1] = Convert.ToInt32(desiredCoordinatesString[0]);
                        return desiredCoordinates;
                    }
                    return null;
                }

                void MovePiece(int[] currentCoordinates, int[] desiredCoordinates, string newPiece)
                {

                    if (MoveCheckPiece(currentCoordinates, desiredCoordinates))
                    {
                        grid[currentCoordinates[0] - 1, currentCoordinates[1] - 1] = " O ";
                        grid[desiredCoordinates[0] - 1, desiredCoordinates[1] - 1] = newPiece;
                    }
                    
                }

                bool MoveCheckPiece(int[] currentCoordinates, int[] desiredCoordinates)
                {
                    if (grid[desiredCoordinates[0] - 1, desiredCoordinates[1] - 1] == " O ")
                    {
                        if (currentCoordinates[0] + 1 == desiredCoordinates[0] && currentCoordinates[1] == desiredCoordinates[1] ||
                            currentCoordinates[0] - 1 == desiredCoordinates[0] && currentCoordinates[1] == desiredCoordinates[1])
                        {
                            return true;
                        }
                    }

                    if (grid[currentCoordinates[0] - 1, currentCoordinates[1] - 1] == " 1 ")
                    {
                        if (grid[desiredCoordinates[0] - 1, desiredCoordinates[1] - 1] == " 2 ")
                        {
                            Console.WriteLine("Position taken, do you want to take this piece? (yes or no) ");
                            string answer = Console.ReadLine();
                            if (answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y")
                            {
                                TakePiece(currentCoordinates, desiredCoordinates, " 1 ");
                            }
                            return false;
                        }
                    }

                    if (grid[currentCoordinates[0] - 1, currentCoordinates[1] - 1] == " 2 ")
                    {
                        if (grid[desiredCoordinates[0] - 1, desiredCoordinates[1] - 1] == " 1 ")
                        {
                            Console.WriteLine("Position taken, do you want to take this piece? (yes or no) ");
                            string answer = Console.ReadLine();
                            if (answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y")
                            {
                                TakePiece(currentCoordinates, desiredCoordinates, " 2 ");
                            }
                            return false;
                        }
                    }

                    return false;

                }

                void TakePiece(int[] currentCoordinates, int[] desiredCoordinates, string newPiece)
                {
                    if (TakeCheckPiece(currentCoordinates, desiredCoordinates))
                    {
                        grid[currentCoordinates[0] - 1, currentCoordinates[1] - 1] = " O ";
                        grid[desiredCoordinates[0] - 1, desiredCoordinates[1] - 1] = newPiece;
                    }
                }

                bool TakeCheckPiece(int[] currentCoordinates, int[] desiredCoordinates)
                {
                    if (desiredCoordinates[0] + 1 == currentCoordinates[0] && desiredCoordinates[1] + 1 == currentCoordinates[1] ||
                        desiredCoordinates[0] + 1 == currentCoordinates[0] && desiredCoordinates[1] - 1 == currentCoordinates[1] ||
                        desiredCoordinates[0] - 1 == currentCoordinates[0] && desiredCoordinates[1] + 1 == currentCoordinates[1] ||
                        desiredCoordinates[0] - 1 == currentCoordinates[0] && desiredCoordinates[1] - 1 == currentCoordinates[1])
                    {
                        return true;
                    }

                    return false;
                }

                void PrintGrid()
                {
                    Console.WriteLine("   1  2  3  4  5  6  7  8");
                    Console.WriteLine("  -----------------------");
                    int rowCount = 1;
                    for (int i = 0; i < 8; i++)
                    {
                        Console.Write(rowCount + "|");
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write(grid[i, j]);
                        }
                        Console.Write("\r\n");
                        rowCount++;
                    }
                }
            }
        }
    }
}
