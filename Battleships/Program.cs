using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class NewBaseType
    {
        public static void DrawBoardWithShips(string[,] boardToPlaceShips)
        {
            Console.WriteLine("              C  o  l  u  m  n  s");
            Console.WriteLine("    | A | B | C | D | E | F | G | H | I | J");
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  1 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[0, 0], boardToPlaceShips[0, 1], boardToPlaceShips[0, 2], boardToPlaceShips[0, 3], boardToPlaceShips[0, 4], boardToPlaceShips[0, 5], boardToPlaceShips[0, 6], boardToPlaceShips[0, 7], boardToPlaceShips[0, 8], boardToPlaceShips[0, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  2 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[1, 0], boardToPlaceShips[1, 1], boardToPlaceShips[1, 2], boardToPlaceShips[1, 3], boardToPlaceShips[1, 4], boardToPlaceShips[1, 5], boardToPlaceShips[1, 6], boardToPlaceShips[1, 7], boardToPlaceShips[1, 8], boardToPlaceShips[1, 9]);
            Console.WriteLine("L --------------------------------------------");
            Console.WriteLine("  3 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[2, 0], boardToPlaceShips[2, 1], boardToPlaceShips[2, 2], boardToPlaceShips[2, 3], boardToPlaceShips[2, 4], boardToPlaceShips[2, 5], boardToPlaceShips[2, 6], boardToPlaceShips[2, 7], boardToPlaceShips[2, 8], boardToPlaceShips[2, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("i 4 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[3, 0], boardToPlaceShips[3, 1], boardToPlaceShips[3, 2], boardToPlaceShips[3, 3], boardToPlaceShips[3, 4], boardToPlaceShips[3, 5], boardToPlaceShips[3, 6], boardToPlaceShips[3, 7], boardToPlaceShips[3, 8], boardToPlaceShips[3, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  5 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[4, 0], boardToPlaceShips[4, 1], boardToPlaceShips[4, 2], boardToPlaceShips[4, 3], boardToPlaceShips[4, 4], boardToPlaceShips[4, 5], boardToPlaceShips[4, 6], boardToPlaceShips[4, 7], boardToPlaceShips[4, 8], boardToPlaceShips[4, 9]);
            Console.WriteLine("n --------------------------------------------");
            Console.WriteLine("  6 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[5, 0], boardToPlaceShips[5, 1], boardToPlaceShips[5, 2], boardToPlaceShips[5, 3], boardToPlaceShips[5, 4], boardToPlaceShips[5, 5], boardToPlaceShips[5, 6], boardToPlaceShips[5, 7], boardToPlaceShips[5, 8], boardToPlaceShips[5, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("e 7 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[6, 0], boardToPlaceShips[6, 1], boardToPlaceShips[6, 2], boardToPlaceShips[6, 3], boardToPlaceShips[6, 4], boardToPlaceShips[6, 5], boardToPlaceShips[6, 6], boardToPlaceShips[6, 7], boardToPlaceShips[6, 8], boardToPlaceShips[6, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  8 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[7, 0], boardToPlaceShips[7, 1], boardToPlaceShips[7, 2], boardToPlaceShips[7, 3], boardToPlaceShips[7, 4], boardToPlaceShips[7, 5], boardToPlaceShips[7, 6], boardToPlaceShips[7, 7], boardToPlaceShips[7, 8], boardToPlaceShips[7, 9]);
            Console.WriteLine("s --------------------------------------------");
            Console.WriteLine("  9 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[8, 0], boardToPlaceShips[8, 1], boardToPlaceShips[8, 2], boardToPlaceShips[8, 3], boardToPlaceShips[8, 4], boardToPlaceShips[8, 5], boardToPlaceShips[8, 6], boardToPlaceShips[8, 7], boardToPlaceShips[8, 8], boardToPlaceShips[8, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine(" 10 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToPlaceShips[9, 0], boardToPlaceShips[9, 1], boardToPlaceShips[9, 2], boardToPlaceShips[9, 3], boardToPlaceShips[9, 4], boardToPlaceShips[9, 5], boardToPlaceShips[9, 6], boardToPlaceShips[9, 7], boardToPlaceShips[9, 8], boardToPlaceShips[9, 9]);



        } //function used to receive inputs from the boardToPlaceShips array and print the result
    }

    class Program : NewBaseType
    {
        static void Main(string[] args)
        {

            string[,] boardToPlaceShips = new string[10, 10]
            {
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
            };  //array with blank spaces to replace with the boats and shots from the opponent
            string[,] boardToPlaceBotShips = new string[10, 10]
{
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
};  //array with blank spaces to replace with the boats randomly placed by the bot or player 2
            string[,] boardToShoot = new string[10, 10]
            {
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "," "," "},
            }; //array with blank spaces to replace with your shots
            int lineInput = 0;
            int colInput = 0;

            string colInp;

            Console.WriteLine("YOU SUNK MY BATTLE SHIP!");
            Console.WriteLine();


            bool mainMenuInput = false;


            do
            {
                Console.WriteLine("Menu: \n1 - Instructions \n2 - Vs Computer \n3 - Versus mode \n0 - Exit");

                string mainMenuChoice = Console.ReadLine();

                switch (mainMenuChoice)
                {
                    case "1":
                        Console.Clear();
                        Instructions();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        //PLAYER VERSUS COMPUTER

                        //Player placing ships

                        bool carrierPlacement = false;

                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Place the \'Carrier\'!");
                            DrawBoardWithShips(boardToPlaceShips);

                            Console.WriteLine("Choose the orientation: \n1 - Horizontal; \n2 - Vertical.");

                            string shipOrientation = Console.ReadLine();

                            switch (shipOrientation)
                            {
                                case "1":

                                    string lineInp;
                                    do
                                    {
                                        lineInp = LineInput();
                                        if (VerifyLineInput(lineInp) == true)
                                        {
                                            lineInput = ConvertLineInput(lineInp);
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Please insert a valid input!");
                                        }
                                    }
                                    while (VerifyLineInput(lineInp) == false);

                                    Console.Clear();
                                    DrawBoardWithShips(boardToPlaceShips);


                                    do
                                    {
                                        Console.WriteLine("Please input a column from \'A\' to \'F\'.");
                                        colInp = (Console.ReadLine()).ToUpper();
                                        if (VerifyCarrierHorizontal(colInp) == true)
                                        {
                                            colInput = ConvertColumnInput(colInp);
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Please insert a valid input!");
                                        }
                                    }
                                    while (VerifyCarrierHorizontal(colInp) == false);

                                    Console.Clear();

                                    CarrierPlacementHorizontal(lineInput, colInput, boardToPlaceShips);

                                    carrierPlacement = true;



                                    break;

                                case "2":


                                    do
                                    {
                                        Console.WriteLine("Please input a line from \'1\' to \'6\'.");
                                        lineInp = Console.ReadLine();
                                        if (VerifyCarrierVertical(lineInp) == true)
                                        {
                                            lineInput = ConvertLineInput(lineInp);
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Please insert a valid input!");
                                        }
                                    }
                                    while (VerifyCarrierVertical(lineInp) == false);

                                    Console.Clear();
                                    DrawBoardWithShips(boardToPlaceShips);


                                    do
                                    {
                                        colInp = ColumnInput();
                                        VerifyColumnInput(colInp);
                                        if (VerifyColumnInput(colInp) == true)
                                        {
                                            colInput = ConvertColumnInput(colInp);
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Please insert a valid input!");
                                        }
                                    }
                                    while (VerifyColumnInput(colInp) == false);

                                    Console.Clear();

                                    CarrierPlacementVertical(lineInput, colInput, boardToPlaceShips);

                                    carrierPlacement = true;


                                    break;


                                default:
                                    Console.WriteLine("Please, insert a valid input!");

                                    break;

                            }
                        }
                        while (carrierPlacement == false); //Placing the Carrier Cycle

                        for (int numberOfBattleships = 0; numberOfBattleships < 2; numberOfBattleships++) // placing 2 Battleships
                        {

                            bool battleshipPlacement = true;

                            do
                            {

                                Console.Clear();
                                Console.WriteLine("Place the \'Battleship\'!");
                                DrawBoardWithShips(boardToPlaceShips);

                                Console.WriteLine("Choose the orientation: \n1 - Horizontal; \n2 - Vertical.");

                                string shipOrientation = Console.ReadLine();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        string lineInp;
                                        do
                                        {
                                            do
                                            {
                                                lineInp = LineInput();
                                                if (VerifyLineInput(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyLineInput(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);



                                            do
                                            {
                                                Console.WriteLine("Please input a column from \'A\' to \'G\'.");
                                                colInp = (Console.ReadLine()).ToUpper();
                                                if (VerifyBattleshipHorizontal(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyBattleshipHorizontal(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 1, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 2, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 3, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                battleshipPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (battleshipPlacement == true);


                                        Console.Clear();
                                        BattleshipPlacementHorizontal(lineInput, colInput, boardToPlaceShips);





                                        break;

                                    case "2":

                                        do
                                        {
                                            do
                                            {
                                                Console.WriteLine("Please input a line from \'1\' to \'7\'.");
                                                lineInp = Console.ReadLine();
                                                if (VerifyBattleshipVertical(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyBattleshipVertical(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);

                                            do
                                            {
                                                colInp = ColumnInput();
                                                VerifyColumnInput(colInp);
                                                if (VerifyColumnInput(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyColumnInput(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 1, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 2, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 3, colInput, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                battleshipPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (battleshipPlacement == true);


                                        Console.Clear();
                                        BattleshipPlacementVertical(lineInput, colInput, boardToPlaceShips);

                                        break;


                                    default:
                                        Console.WriteLine("Please, insert a valid input!");

                                        break;

                                }
                            }
                            while (battleshipPlacement == true); //Placing the Battleship Cycle

                        } //placing 2 Battleships

                        for (int numberOfDestroyers = 0; numberOfDestroyers < 2; numberOfDestroyers++) // placing 3 Destroyers
                        {

                            bool destroyerPlacement = true;

                            do
                            {

                                Console.Clear();
                                Console.WriteLine("Place the \'Destroyer\'!");
                                DrawBoardWithShips(boardToPlaceShips);

                                Console.WriteLine("Choose the orientation: \n1 - Horizontal; \n2 - Vertical.");

                                string shipOrientation = Console.ReadLine();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        string lineInp;
                                        do
                                        {
                                            do
                                            {
                                                lineInp = LineInput();
                                                if (VerifyLineInput(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyLineInput(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);



                                            do
                                            {
                                                Console.WriteLine("Please input a column from \'A\' to \'H\'.");
                                                colInp = (Console.ReadLine()).ToUpper();
                                                if (VerifyDestroyerHorizontal(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyDestroyerHorizontal(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 1, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 2, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                destroyerPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (destroyerPlacement == true);


                                        Console.Clear();
                                        DestroyerPlacementHorizontal(lineInput, colInput, boardToPlaceShips);





                                        break;

                                    case "2":

                                        do
                                        {
                                            do
                                            {
                                                Console.WriteLine("Please input a line from \'1\' to \'8\'.");
                                                lineInp = Console.ReadLine();
                                                if (VerifyDestroyerVertical(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyDestroyerVertical(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);

                                            do
                                            {
                                                colInp = ColumnInput();
                                                VerifyColumnInput(colInp);
                                                if (VerifyColumnInput(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyColumnInput(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 1, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 2, colInput, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                destroyerPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (destroyerPlacement == true);


                                        Console.Clear();
                                        DestroyerPlacementVertical(lineInput, colInput, boardToPlaceShips);

                                        break;


                                    default:
                                        Console.WriteLine("Please, insert a valid input!");

                                        break;

                                }
                            }
                            while (destroyerPlacement == true);

                        } //placing 2 Destroyers

                        for (int numberOfSubmarines = 0; numberOfSubmarines < 2; numberOfSubmarines++) // placing 2 Submarines
                        {

                            bool submarinePlacement = true;

                            do
                            {

                                Console.Clear();
                                Console.WriteLine("Place the \'Submarine\'!");
                                DrawBoardWithShips(boardToPlaceShips);

                                Console.WriteLine("Choose the orientation: \n1 - Horizontal; \n2 - Vertical.");

                                string shipOrientation = Console.ReadLine();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        string lineInp;
                                        do
                                        {
                                            do
                                            {
                                                lineInp = LineInput();
                                                if (VerifyLineInput(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyLineInput(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);



                                            do
                                            {
                                                Console.WriteLine("Please input a column from \'A\' to \'H\'.");
                                                colInp = (Console.ReadLine()).ToUpper();
                                                if (VerifySubmarineHorizontal(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifySubmarineHorizontal(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 1, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 2, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                submarinePlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (submarinePlacement == true);


                                        Console.Clear();
                                        SubmarinePlacementHorizontal(lineInput, colInput, boardToPlaceShips);





                                        break;

                                    case "2":

                                        do
                                        {
                                            do
                                            {
                                                Console.WriteLine("Please input a line from \'1\' to \'8\'.");
                                                lineInp = Console.ReadLine();
                                                if (VerifySubmarineVertical(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifySubmarineVertical(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);

                                            do
                                            {
                                                colInp = ColumnInput();
                                                VerifyColumnInput(colInp);
                                                if (VerifyColumnInput(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyColumnInput(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 1, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 2, colInput, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                submarinePlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (submarinePlacement == true);


                                        Console.Clear();
                                        SubmarinePlacementVertical(lineInput, colInput, boardToPlaceShips);

                                        break;


                                    default:
                                        Console.WriteLine("Please, insert a valid input!");

                                        break;

                                }
                            }
                            while (submarinePlacement == true);

                        } //placing 2 Submarines

                        for (int numberOfPatrols = 0; numberOfPatrols < 4; numberOfPatrols++) // placing 4 Boat Patrols
                        {

                            bool patrolPlacement = true;

                            do
                            {

                                Console.Clear();
                                Console.WriteLine("Place the \'Boat Patrols\'!");
                                DrawBoardWithShips(boardToPlaceShips);

                                Console.WriteLine("Choose the orientation: \n1 - Horizontal; \n2 - Vertical.");

                                string shipOrientation = Console.ReadLine();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        string lineInp;
                                        do
                                        {
                                            do
                                            {
                                                lineInp = LineInput();
                                                if (VerifyLineInput(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyLineInput(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);



                                            do
                                            {
                                                Console.WriteLine("Please input a column from \'A\' to \'H\'.");
                                                colInp = (Console.ReadLine()).ToUpper();
                                                if (VerifyPatrolHorizontal(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyPatrolHorizontal(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput, colInput + 1, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                patrolPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (patrolPlacement == true);


                                        Console.Clear();
                                        PatrolPlacementHorizontal(lineInput, colInput, boardToPlaceShips);





                                        break;

                                    case "2":

                                        do
                                        {
                                            do
                                            {
                                                Console.WriteLine("Please input a line from \'1\' to \'9\'.");
                                                lineInp = Console.ReadLine();
                                                if (VerifyPatrolVertical(lineInp) == true)
                                                {
                                                    lineInput = ConvertLineInput(lineInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyPatrolVertical(lineInp) == false);

                                            Console.Clear();
                                            DrawBoardWithShips(boardToPlaceShips);

                                            do
                                            {
                                                colInp = ColumnInput();
                                                VerifyColumnInput(colInp);
                                                if (VerifyColumnInput(colInp) == true)
                                                {
                                                    colInput = ConvertColumnInput(colInp);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Please insert a valid input!");
                                                }
                                            }
                                            while (VerifyColumnInput(colInp) == false);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips) == true || VerifyIfSquareIsFilled(lineInput + 1, colInput, boardToPlaceShips) == true)
                                            {
                                                Console.WriteLine("Place the ship elsewhere!");
                                                DrawBoardWithShips(boardToPlaceShips);
                                                continue;
                                            }
                                            else
                                            {
                                                patrolPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (patrolPlacement == true);


                                        Console.Clear();
                                        PatrolPlacementVertical(lineInput, colInput, boardToPlaceShips);

                                        break;


                                    default:
                                        Console.WriteLine("Please, insert a valid input!");

                                        break;

                                }
                            }
                            while (patrolPlacement == true);

                        } //placing 4 Boat Patrols

                        DrawBoardWithShips(boardToPlaceShips);


                        //BOT RANDOM SHIP PLACEMENT

                        Random botAnswers = new Random();
                        carrierPlacement = false;
                        do
                        {

                            Console.Clear();

                            string shipOrientation = (botAnswers.Next(1, 3)).ToString();

                            switch (shipOrientation)
                            {
                                case "1":

                                    lineInput = botAnswers.Next(0, 10);
                                    colInput = botAnswers.Next(0, 6);

                                    CarrierPlacementHorizontal(lineInput, colInput, boardToPlaceBotShips);

                                    carrierPlacement = true;



                                    break;

                                case "2":

                                    lineInput = botAnswers.Next(0, 6);
                                    colInput = botAnswers.Next(0, 10);

                                    CarrierPlacementVertical(lineInput, colInput, boardToPlaceBotShips);

                                    carrierPlacement = true;


                                    break;


                                default:
                                    carrierPlacement = false;
                                    break;

                            }
                        }
                        while (carrierPlacement == false); //Placing the Carrier for the bot

                        for (int numberOfBattleships = 0; numberOfBattleships < 2; numberOfBattleships++) // placing 2 Battleships
                        {

                            bool battleshipPlacement = true;

                            do
                            {

                                string shipOrientation = botAnswers.Next(1, 3).ToString();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        do
                                        {

                                            lineInput = botAnswers.Next(0, 10);
                                            colInput = botAnswers.Next(0, 7);


                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 1), boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 2), boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 3), boardToPlaceBotShips) == true)
                                            {
                                                battleshipPlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                BattleshipPlacementHorizontal(lineInput, colInput, boardToPlaceBotShips);
                                                battleshipPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (battleshipPlacement == true);






                                        break;

                                    case "2":

                                        do
                                        {
                                            lineInput = botAnswers.Next(0, 7);
                                            colInput = botAnswers.Next(0, 10);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 1), colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 2), colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 3), colInput, boardToPlaceBotShips) == true)
                                            {
                                                battleshipPlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                BattleshipPlacementVertical(lineInput, colInput, boardToPlaceBotShips);
                                                battleshipPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (battleshipPlacement == true);


                                        break;


                                    default:
                                        battleshipPlacement = true;
                                        break;

                                }
                            }
                            while (battleshipPlacement == true); //Placing the Battleship Cycle

                        } //placing 2 Battleships 

                        for (int numberOfDestroyers = 0; numberOfDestroyers < 2; numberOfDestroyers++) // placing 2 Destroyers
                        {

                            bool destroyerPlacement = true;

                            do
                            {

                                string shipOrientation = botAnswers.Next(1, 3).ToString();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        do
                                        {

                                            lineInput = botAnswers.Next(0, 10);
                                            colInput = botAnswers.Next(0, 8);


                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 1), boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 2), boardToPlaceBotShips) == true)
                                            {
                                                destroyerPlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                DestroyerPlacementHorizontal(lineInput, colInput, boardToPlaceBotShips);
                                                destroyerPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (destroyerPlacement == true);






                                        break;

                                    case "2":

                                        do
                                        {
                                            lineInput = botAnswers.Next(0, 8);
                                            colInput = botAnswers.Next(0, 10);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 1), colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 2), colInput, boardToPlaceBotShips) == true)
                                            {
                                                destroyerPlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                DestroyerPlacementVertical(lineInput, colInput, boardToPlaceBotShips);
                                                destroyerPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (destroyerPlacement == true);


                                        break;


                                    default:
                                        destroyerPlacement = true;
                                        break;

                                }
                            }
                            while (destroyerPlacement == true); //Placing the Destroyer Cycle

                        } //placing 2 Destroyer

                        for (int numberOfSubmarines = 0; numberOfSubmarines < 2; numberOfSubmarines++) // placing 2 Destroyers
                        {

                            bool submarinePlacement = true;

                            do
                            {

                                string shipOrientation = botAnswers.Next(1, 3).ToString();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        do
                                        {

                                            lineInput = botAnswers.Next(0, 10);
                                            colInput = botAnswers.Next(0, 8);


                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 1), boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 2), boardToPlaceBotShips) == true)
                                            {
                                                submarinePlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                SubmarinePlacementHorizontal(lineInput, colInput, boardToPlaceBotShips);
                                                submarinePlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (submarinePlacement == true);

                                        break;

                                    case "2":

                                        do
                                        {
                                            lineInput = botAnswers.Next(0, 8);
                                            colInput = botAnswers.Next(0, 10);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 1), colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 2), colInput, boardToPlaceBotShips) == true)
                                            {
                                                submarinePlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                SubmarinePlacementVertical(lineInput, colInput, boardToPlaceBotShips);
                                                submarinePlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (submarinePlacement == true);


                                        break;


                                    default:
                                        submarinePlacement = true;
                                        break;

                                }
                            }
                            while (submarinePlacement == true); //Placing the Submarine Cycle

                        } //placing 2 Submarines

                        for (int numberOfPatrols = 0; numberOfPatrols < 4; numberOfPatrols++) // placing 2 Boat Patrols
                        {

                            bool patrolPlacement = true;

                            do
                            {

                                string shipOrientation = botAnswers.Next(1, 3).ToString();

                                switch (shipOrientation)
                                {
                                    case "1":

                                        do
                                        {

                                            lineInput = botAnswers.Next(0, 10);
                                            colInput = botAnswers.Next(0, 8);


                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled(lineInput, (colInput + 1), boardToPlaceBotShips) == true)
                                            {
                                                patrolPlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                PatrolPlacementHorizontal(lineInput, colInput, boardToPlaceBotShips);
                                                patrolPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available
                                        }
                                        while (patrolPlacement == true);






                                        break;

                                    case "2":

                                        do
                                        {
                                            lineInput = botAnswers.Next(0, 8);
                                            colInput = botAnswers.Next(0, 10);



                                            if (VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips) == true || VerifyIfSquareIsFilled((lineInput + 1), colInput, boardToPlaceBotShips) == true)
                                            {
                                                patrolPlacement = true;

                                            }
                                            else
                                            {

                                                Console.Clear();
                                                PatrolPlacementVertical(lineInput, colInput, boardToPlaceBotShips);
                                                patrolPlacement = false;
                                            }
                                            //verify if any squares that will be occupied by the ship are available

                                        }
                                        while (patrolPlacement == true);


                                        break;


                                    default:
                                        patrolPlacement = true;
                                        break;

                                }
                            }
                            while (patrolPlacement == true); //Placing the Patrol Cycle

                        } //placing 4 Patrol

                        //Game Phase cycle

                        bool gamePhase = true;

                        do
                        {

                            //Player turn
                            bool playerTurn = true;
                            do
                            {
                                playerTurn = true;
                                Console.WriteLine("Player turn to shoot");
                                DrawBoardToShoot(boardToShoot);

                                string lineInp;
                                do
                                {
                                    lineInp = LineInput();
                                    if (VerifyLineInput(lineInp) == true)
                                    {
                                        lineInput = ConvertLineInput(lineInp);
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please insert a valid input!");
                                    }
                                }
                                while (VerifyLineInput(lineInp) == false);

                                Console.Clear();
                                DrawBoardWithShips(boardToShoot);


                                do
                                {
                                    Console.WriteLine("Please input a column from \'A\' to \'J\'.");
                                    colInp = (Console.ReadLine()).ToUpper();
                                    if (VerifyColumnInput(colInp) == true)
                                    {
                                        colInput = ConvertColumnInput(colInp);
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please insert a valid input!");
                                    }
                                }
                                while (VerifyColumnInput(colInp) == false);

                                Console.Clear();

                                bool isSqareFilled = VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips);

                                ShotsHitOrMiss(lineInput, colInput, isSqareFilled, boardToShoot); //replace square with 'X' or 'O' if shot landed or not, respectivelly
                                DrawBoardToShoot(boardToShoot);
                                PlayerVictoryVerification(boardToPlaceBotShips);

                                if (isSqareFilled == true)
                                {
                                    Console.WriteLine("NICE SHOT! \n Press any key to shoot again!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("YOU MISSED! \n Press any key to pass the turn!");
                                    Console.ReadKey();
                                }
                                playerTurn = VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceBotShips);

                            }
                            while (playerTurn == true);

                            // BOT TURN

                            bool botTurn = true;
                            do
                            {
                                botTurn = true;
                                Console.WriteLine("Bot turn to shoot");
                                DrawBoardToShoot(boardToPlaceShips);

                                lineInput = botAnswers.Next(0, 10);
                                colInput = botAnswers.Next(0, 10);

                                bool isSqareFilled = VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips);

                                ShotsHitOrMiss(lineInput, colInput, isSqareFilled, boardToPlaceShips);
                                DrawBoardToShoot(boardToPlaceShips);

                                if (isSqareFilled == true)
                                {
                                    Console.WriteLine("THE BOT GOT YOU! \n And will shoot again! After you press any key.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("THE BOT MISSED! \n Press any key to start your turn!");
                                    Console.ReadKey();
                                }
                                botTurn = VerifyIfSquareIsFilled(lineInput, colInput, boardToPlaceShips);

                            }
                            while (botTurn == true);

                        }
                        while (gamePhase == true);

                        break;

                    case "3":
                        break;

                    case "0":
                        ExitGame();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please insert a valid input!");
                        break;
                }
            }
            while (mainMenuInput == false); //MAIN MENU

        }

        public static void ExitGame()
        {
            Console.WriteLine("Press any key to exit...");
            System.Environment.Exit(0);
        } //function of the Main Menu used to exit the game

        public static void DrawBoardToShoot(string[,] boardToShoot)
        {
            Console.WriteLine("              C  o  l  u  m  n  s");
            Console.WriteLine("    | A | B | C | D | E | F | G | H | I | J");
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  1 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[0, 0], boardToShoot[0, 1], boardToShoot[0, 2], boardToShoot[0, 3], boardToShoot[0, 4], boardToShoot[0, 5], boardToShoot[0, 6], boardToShoot[0, 7], boardToShoot[0, 8], boardToShoot[0, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  2 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[1, 0], boardToShoot[1, 1], boardToShoot[1, 2], boardToShoot[1, 3], boardToShoot[1, 4], boardToShoot[1, 5], boardToShoot[1, 6], boardToShoot[1, 7], boardToShoot[1, 8], boardToShoot[1, 9]);
            Console.WriteLine("L --------------------------------------------");
            Console.WriteLine("  3 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[2, 0], boardToShoot[2, 1], boardToShoot[2, 2], boardToShoot[2, 3], boardToShoot[2, 4], boardToShoot[2, 5], boardToShoot[2, 6], boardToShoot[2, 7], boardToShoot[2, 8], boardToShoot[2, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("i 4 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[3, 0], boardToShoot[3, 1], boardToShoot[3, 2], boardToShoot[3, 3], boardToShoot[3, 4], boardToShoot[3, 5], boardToShoot[3, 6], boardToShoot[3, 7], boardToShoot[3, 8], boardToShoot[3, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  5 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[4, 0], boardToShoot[4, 1], boardToShoot[4, 2], boardToShoot[4, 3], boardToShoot[4, 4], boardToShoot[4, 5], boardToShoot[4, 6], boardToShoot[4, 7], boardToShoot[4, 8], boardToShoot[4, 9]);
            Console.WriteLine("n  --------------------------------------------");
            Console.WriteLine("  6 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[5, 0], boardToShoot[5, 1], boardToShoot[5, 2], boardToShoot[5, 3], boardToShoot[5, 4], boardToShoot[5, 5], boardToShoot[5, 6], boardToShoot[5, 7], boardToShoot[5, 8], boardToShoot[5, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("e 7 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[6, 0], boardToShoot[6, 1], boardToShoot[6, 2], boardToShoot[6, 3], boardToShoot[6, 4], boardToShoot[6, 5], boardToShoot[6, 6], boardToShoot[6, 7], boardToShoot[6, 8], boardToShoot[6, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("  8 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[7, 0], boardToShoot[7, 1], boardToShoot[7, 2], boardToShoot[7, 3], boardToShoot[7, 4], boardToShoot[7, 5], boardToShoot[7, 6], boardToShoot[7, 7], boardToShoot[7, 8], boardToShoot[7, 9]);
            Console.WriteLine("s --------------------------------------------");
            Console.WriteLine("  9 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[8, 0], boardToShoot[8, 1], boardToShoot[8, 2], boardToShoot[8, 3], boardToShoot[8, 4], boardToShoot[8, 5], boardToShoot[8, 6], boardToShoot[8, 7], boardToShoot[8, 8], boardToShoot[8, 9]);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine(" 10 | {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} ", boardToShoot[9, 0], boardToShoot[9, 1], boardToShoot[9, 2], boardToShoot[9, 3], boardToShoot[9, 4], boardToShoot[9, 5], boardToShoot[9, 6], boardToShoot[9, 7], boardToShoot[9, 8], boardToShoot[9, 9]);



        } //function used to receive inputs from the boardToPlaceShips array and print the result

        public static void Instructions()
        {
            Console.WriteLine("I N S T R U C T I O N S");
            Console.WriteLine();
            Console.WriteLine("You will have two 10 by 10 boards, one to place the ships and to display the shots taken and the other to shoot your shots.");
            Console.WriteLine("The rows will be numbered from 1 to 10 and the columns will be identified from A to J.");
            Console.WriteLine("Your fleet (as well as the adversary's) will have the following lineup:");
            Console.WriteLine();

            string[,] ships = new string[6, 4] //ships' description
			{
                {" Ship type   ","Squares occupied","Indentification on board","Quantity"},
                {"  Carrier    ","      5         ","          C             ","    1   "},
                {" Battlership ","      4         ","          B             ","    2   "},
                {"  Destroyer  ","      3         ","          D             ","    2   "},
                {"  Submarine  ","      3         ","          S             ","    2   "},
                {" Boat Patrol ","      2         ","          P             ","    4   "}
            };

            Console.WriteLine("{0} | {1} | {2} | {3}", ships[0, 0], ships[0, 1], ships[0, 2], ships[0, 3]);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("{0} | {1} | {2} | {3}", ships[1, 0], ships[1, 1], ships[1, 2], ships[1, 3]);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("{0} | {1} | {2} | {3}", ships[2, 0], ships[2, 1], ships[2, 2], ships[2, 3]);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("{0} | {1} | {2} | {3}", ships[3, 0], ships[3, 1], ships[3, 2], ships[3, 3]);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("{0} | {1} | {2} | {3}", ships[4, 0], ships[4, 1], ships[4, 2], ships[4, 3]);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("{0} | {1} | {2} | {3}", ships[5, 0], ships[5, 1], ships[5, 2], ships[5, 3]);
            Console.WriteLine();

            Console.WriteLine("First thing you will do is place the ships in the same order they were presente to you in this list.");
            Console.WriteLine("In order to place a ship first choose the orientation, \'horizontal\' or \' vertical\', then a line from \'1 to 10\' and finally then a column from \'A to J\'.");
            Console.WriteLine();

            Console.WriteLine("After placing all your ships the shooting begins! To shoot you must choose a line from \'1 to 10\', then a column from \'A to J\'. \nIf the shot missed the turn is over and the opponent will shoot back. \nEach time a shot lands on a ship that player will get another shot, there is no limit!");
            Console.WriteLine();

            Console.WriteLine("Valid hits will be displayed with an \'X\', missed shots will be displayed with an \'O\'.");
            Console.WriteLine("Every time you shoot it will be annouced whether you missed or not. Every time you get shot at, it will be annouced where it landed and whether one of your ships were hit or not.");
            Console.WriteLine("The game ends when a player's fleet is completely destroyed. The player who destroyed the opponents' fleet wins the game!");
            Console.WriteLine();

            Console.WriteLine("Press any key to return to the main menu . . .");
            Console.ReadKey(); //CHANGE THIS TO READ KEY
        } //function to display the instructions

        //LINE AND COLUMNS VERIFICATION

        public static string LineInput()
        {
            Console.WriteLine("Please input a line from \'1\' to \'10\'.");
            return Console.ReadLine();
        } //function used to ask for the line input for shooting

        public static string ColumnInput()
        {
            Console.WriteLine("Please input a column from \'A\' to \'J\'.");
            return (Console.ReadLine()).ToUpper();
        } //function used to ask for the column input for shooting

        public static bool VerifyColumnInput(string columnInput)
        {
            if (columnInput == "A" || columnInput == "B" || columnInput == "C" || columnInput == "D" || columnInput == "E" || columnInput == "F" || columnInput == "G" || columnInput == "H" || columnInput == "I" || columnInput == "J")
            {
                return true;
            }
            else
            {
                return false;
            }
        } //function used to verify if the input matches one of the possible from 'A' to 'J' 

        //If VerifyColumnInput returns true use ConvertColumnInput to return a value to use in the arrays

        public static int ConvertColumnInput(string columnInput)
        {

            switch (columnInput)
            {
                case "A":

                    return 0;

                case "B":
                    return 1;

                case "C":
                    return 2;

                case "D":
                    return 3;

                case "E":
                    return 4;

                case "F":
                    return 5;

                case "G":
                    return 6;

                case "H":
                    return 7;

                case "I":
                    return 8;

                case "J":
                    return 9;

                default:
                    return 0;
            };
        } //function used to convert the column input from letter to number only after verification

        public static bool VerifyLineInput(string lineInput)
        {
            {
                if (lineInput == "1" || lineInput == "2" || lineInput == "3" || lineInput == "4" || lineInput == "5" || lineInput == "6" || lineInput == "7" || lineInput == "8" || lineInput == "9" || lineInput == "10")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } //function used to verify if the user input for the line goes from 1 to 10

        public static int ConvertLineInput(string lineInput)
        {

            switch (lineInput)
            {
                case "1":
                    return 0;

                case "2":
                    return 1;

                case "3":
                    return 2;

                case "4":
                    return 3;

                case "5":
                    return 4;

                case "6":
                    return 5;

                case "7":
                    return 6;

                case "8":
                    return 7;

                case "9":
                    return 8;

                case "10":
                    return 9;

                default:
                    return 0;

            }
        }

        public static bool VerifyIfSquareIsFilled(int lineInp, int colInput, string[,] boardToPlaceShips)
        {
            if (boardToPlaceShips[lineInp, colInput] != " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        } //function to verify if the placement square is filled.
          //then use a cycle to increase the input in order to verify if the ship the plaer is placing will not overlap with another ship already placed

        public static void ShotsHitOrMiss(int lineInp, int colInp, bool isSquareFilled, string[,] boardToShoot)
        {
            if (isSquareFilled == true)
            {
                boardToShoot[lineInp, colInp] = "X";


            }
            else
            {
                boardToShoot[lineInp, colInp] = "O";
            }
        }

        public static void PlayerVictoryVerification(string[,] boardToPlaceBotShips) //function used to verify if the player won the game
        {
            int playerShotsLanded = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (boardToPlaceBotShips[i, j] == "X")
                    {
                        playerShotsLanded++;

                        if (playerShotsLanded == 33)
                        {
                            Console.WriteLine("YOU WON!");
                           
                            
                        }
                    }
                }
            }
        }

        public static void BotVictoryVerification(string[,] boardToPlaceShips)
        {
            int botShotsLanded = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (boardToPlaceShips[i, j] == "X")
                    {
                        botShotsLanded++;

                        if (botShotsLanded == 33)
                        {
                            Console.WriteLine("YOU LOST!");
                            ExitGame();
                        }
                    }
                }
            }
        }






        //Ship placement and verification




        public static bool VerifyCarrierHorizontal(string columnInput)
        {
            if (columnInput == "A" || columnInput == "B" || columnInput == "C" || columnInput == "D" || columnInput == "E" || columnInput == "F")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyCarrierVertical(string lineInput)
        {
            if (lineInput == "1" || lineInput == "2" || lineInput == "3" || lineInput == "4" || lineInput == "5" || lineInput == "6")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CarrierPlacementHorizontal(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "C";
                colInput++;
                shipLength++;

            }
            while (shipLength < 5);
        }

        public static void CarrierPlacementVertical(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "C";
                lineInp++;
                shipLength++;

            }
            while (shipLength < 5);
        }


        public static bool VerifyBattleshipHorizontal(string columnInput)
        {
            if (columnInput == "A" || columnInput == "B" || columnInput == "C" || columnInput == "D" || columnInput == "E" || columnInput == "F" || columnInput == "G")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyBattleshipVertical(string lineInput)
        {
            if (lineInput == "1" || lineInput == "2" || lineInput == "3" || lineInput == "4" || lineInput == "5" || lineInput == "6" || lineInput == "7")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void BattleshipPlacementHorizontal(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "B";
                colInput++;
                shipLength++;

            }
            while (shipLength < 4);
        }

        public static void BattleshipPlacementVertical(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "B";
                lineInp++;
                shipLength++;

            }
            while (shipLength < 4);
        }


        public static bool VerifyDestroyerHorizontal(string columnInput)
        {
            if (columnInput == "A" || columnInput == "B" || columnInput == "C" || columnInput == "D" || columnInput == "E" || columnInput == "F" || columnInput == "G" || columnInput == "H")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyDestroyerVertical(string lineInput)
        {
            if (lineInput == "1" || lineInput == "2" || lineInput == "3" || lineInput == "4" || lineInput == "5" || lineInput == "6" || lineInput == "7" || lineInput == "8")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DestroyerPlacementHorizontal(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "D";
                colInput++;
                shipLength++;

            }
            while (shipLength < 3);
        }

        public static void DestroyerPlacementVertical(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "D";
                lineInp++;
                shipLength++;

            }
            while (shipLength < 3);
        }


        public static bool VerifySubmarineHorizontal(string columnInput)
        {
            if (columnInput == "A" || columnInput == "B" || columnInput == "C" || columnInput == "D" || columnInput == "E" || columnInput == "F" || columnInput == "G" || columnInput == "H")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifySubmarineVertical(string lineInput)
        {
            if (lineInput == "1" || lineInput == "2" || lineInput == "3" || lineInput == "4" || lineInput == "5" || lineInput == "6" || lineInput == "7" || lineInput == "8")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SubmarinePlacementHorizontal(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "S";
                colInput++;
                shipLength++;

            }
            while (shipLength < 3);
        }

        public static void SubmarinePlacementVertical(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "S";
                lineInp++;
                shipLength++;

            }
            while (shipLength < 3);
        }


        public static bool VerifyPatrolHorizontal(string columnInput)
        {
            if (columnInput == "A" || columnInput == "B" || columnInput == "C" || columnInput == "D" || columnInput == "E" || columnInput == "F" || columnInput == "G" || columnInput == "H" || columnInput == "I")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyPatrolVertical(string lineInput)
        {
            if (lineInput == "1" || lineInput == "2" || lineInput == "3" || lineInput == "4" || lineInput == "5" || lineInput == "6" || lineInput == "7" || lineInput == "8" || lineInput == "9")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PatrolPlacementHorizontal(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "P";
                colInput++;
                shipLength++;

            }
            while (shipLength < 2);
        }

        public static void PatrolPlacementVertical(int lineInp, int colInput, string[,] boardToPlaceShips)

        {
            int shipLength = 0;
            do
            {
                boardToPlaceShips[lineInp, colInput] = "P";
                lineInp++;
                shipLength++;

            }
            while (shipLength < 2);
        }

    }
}
