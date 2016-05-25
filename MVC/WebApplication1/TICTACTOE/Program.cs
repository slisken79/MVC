using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        private string playerPiece = "n";


        //METHODS
        //Move takes a multi-dimensional array board, and a string piece that are both ref 
        public void Move(ref string[,] board, ref string piece)
        {
            playerPiece = piece;
            int rows = 3;
            int columns = 3;
            bool turnOver = false;
            bool validMove = false;
            string playerMove;


            do
            {
                //Reset counters
                int availabilityCounter = 0;
                bool playerMoveValid = false;

                ///Check the board to see if any moves are available
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {


                        if ((board[i, j] == "o") || (board[i, j] == "x"))
                        {
                            availabilityCounter++;
                            if (availabilityCounter == 9)
                            {
                                turnOver = true;
                            }
                        }

                    }
                }


                if (!turnOver)
                {


                    Console.WriteLine("\n\nPLEASE CHOOSE A NUMBER FOR YOUR NEXT MOVE: \n\n");
                    playerMove = Console.ReadLine();
                    do
                    {

                        //See if the player's move is equal to a string 1-9 and increase the playerMove counter if it is found
                        //If the playerMove counter = 1 then the move has been found,  if not then please ask the player to enter a valid move
                        for (int r = 1; r <= 9; r++)
                        {
                            if (playerMove == Convert.ToString(r))
                            {
                            playerMoveValid = true;
                        }
                    }

                        //Make sure the player has entered a space on the board
                        //if they haven't make them choose again
                    if (!playerMoveValid)
                    {
                        Console.WriteLine("\nThat is not a valid choice please enter a new number...\n");
                        playerMove = Console.ReadLine();
                    }

                } while (!playerMoveValid) ;

                //This loop searchs through the board looking for player's desired move while his/her turn is not over
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {


                        //Find the player's desired move, see if the spot is occupied, if not, place the player piece
                        if ((board[i, j] == playerMove) & (board[i, j] != "o") & (board[i, j] != "x"))
                        {
                            board[i, j] = playerPiece;
                            turnOver = true;
                            validMove = true;
                        }

                    }
                }

                //If the move is not available because the space is occupied inform the player
                if (!validMove)
                {
                    Console.WriteLine("THAT MOVE IS NOT AVAILABLE!\n");
                }

            }

            //Updated so that while statement does check for mutually exclusive events.  turnOver will never be true when validMove is false so I only need to check one of them.
            } while ((!turnOver));

        }//End move player

}//End player class


public class Computer
{
    private string computerPiece = "n";

    //METHODS
    //Move takes a multidimensional array board refernce and a string piece reference
    public void Move(ref string[,] board, ref string cPiece)
    {
        //create an instance of the random class
        Random RandomClass = new Random();
        computerPiece = cPiece;
        bool turnOver = false;
        int rows = 3;
        int columns = 3;

        //AI
        //The computer will make a move based on random numbers
        do
        {

            int availabilityCounter = 0;

            ///Check the board to see if any moves are available
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    if ((board[i, j] == "o") || (board[i, j] == "x"))
                    {
                        availabilityCounter++;
                        if (availabilityCounter == 9)
                        {
                            turnOver = true;
                        }
                    }
                }
            }

            if (!turnOver)
            {


                int randomOne = RandomClass.Next(0, 3);
                int randomTwo = RandomClass.Next(0, 3);

                //End turn when the computer places a piece
                if ((board[randomOne, randomTwo] != "x") & (board[randomOne, randomTwo] != "o"))
                {
                    board[randomOne, randomTwo] = cPiece;

                    turnOver = true;
                }
            }

        } while ((!turnOver));

    }//End Move

}//End Computer 



public class Board
{
    //Creates a game board with pre-set values
    private string[,] gameBoard =
    {
            {"1","2","3"}, {"4","5","6"}, {"7","8","9"}
        };


    //Methods
    //Display just displays the updated game board
    public void Display()
    {

        Console.WriteLine("\n{0} {1} {2}\n", gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2]);
        Console.WriteLine("{0} {1} {2}\n", gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
        Console.WriteLine("{0} {1} {2}\n\n", gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);

    }

    //CheckBoard accepts a board and checks it to see who has won, then returns a string that describes who won
    public string Check()//use gameBoard member here instead!
    {
        string gameOver = "n";


        //Conditions for winning the game
        string[,] winningCombos =
        {
                {gameBoard[0,0], gameBoard[0,1], gameBoard[0,2]},
                {gameBoard[1,0], gameBoard[1,1], gameBoard[1,2]},
                {gameBoard[2,0], gameBoard[2,1], gameBoard[2,2]},
                {gameBoard[0,0], gameBoard[1,0], gameBoard[2,0]},
                {gameBoard[0,1], gameBoard[1,1], gameBoard[2,1]},
                {gameBoard[0,2], gameBoard[1,2], gameBoard[2,2]},
                {gameBoard[0,0], gameBoard[1,1], gameBoard[2,2]},
                {gameBoard[0,2], gameBoard[1,1], gameBoard[2,0]}
            };

        int totalCombos = 8;

        //Check the Board to see if anyone has won
        for (int i = 0; i < totalCombos; i++)
        {

            //Check all the winning rows to see if x's won
            if ((winningCombos[i, 0] == "x") & (winningCombos[i, 1] == "x") & (winningCombos[i, 2] == "x"))
            {
                gameOver = "X";
            }

            //Check all the winning rows to see if o's have won
            if ((winningCombos[i, 0] == "o") & (winningCombos[i, 1] == "o") & (winningCombos[i, 2] == "o") & (gameOver != "X"))
            {
                gameOver = "O";
            }

        }

        //return the status of the game
        return gameOver;

    }//End Check

    //accessor method for retrieving the board
    public string[,] Get()
    {
        return gameBoard;
    }

}//End Board 


public class GameLoop
{


    public void Run()
    {
        string userResponse = "";
        string gameStatus = "n";

        do
        {

            Console.WriteLine("\n\nWELCOME TO ANEXA'S TIC TAC TOE GAME!!");

            //Create a new Player, a new Board, and a new Computer
            Player newPlayer = new Player();
            Computer newComputer = new Computer();
            Board newBoard = new Board();
            //the variable turn will helps to determine when the game is a tie
            int turn = 0;

            //Use the Board accessor method to get the newly created board and store it in newGameBoard
            string[,] newGameBoard = newBoard.Get();


            Console.WriteLine("\nWould you like to be X's or O's?");
            string userXorO = Console.ReadLine();

            //If the user does not enter x or o then keep asking until they do
            do
            {
                if ((userXorO != "x") & (userXorO != "o"))
                {
                    Console.WriteLine("You must type lower case x or lower case o to continue: ");
                    userXorO = Console.ReadLine();
                }

            } while ((userXorO != "x") & (userXorO != "o"));

            //display the updated newGameBoard
            newBoard.Display();



            do
            {

                string playerGamePiece = userXorO;

                //If the player chooses x then they will always move first
                if (userXorO == "x")
                {
                    string computerPiece = "o";

                    //Get the player move
                    newPlayer.Move(ref newGameBoard, ref playerGamePiece);
                    //Get the status of the game after the player's move
                    gameStatus = newBoard.Check();
                    //Display the updated board after the move
                    newBoard.Display();
                    //increase the turn count so we can tell when there's a tie
                    turn++;

                    //same logic as player move 
                    newComputer.Move(ref newGameBoard, ref computerPiece);
                    gameStatus = newBoard.Check();
                    newBoard.Display();
                    turn++;

                }

                //if the player chooses o then they will always move after the computer
                else if (userXorO == "o")
                {
                    string computerPiece = "x";

                    //same as above
                    newComputer.Move(ref newGameBoard, ref computerPiece);
                    gameStatus = newBoard.Check();
                    newBoard.Display();
                    turn++;

                    //same as above
                    newPlayer.Move(ref newGameBoard, ref playerGamePiece);
                    gameStatus = newBoard.Check();
                    newBoard.Display();
                    turn++;
                }


                //if the gameStatus has X as the winner, and the player's piece is X, then congratulate them
                if ((gameStatus == "X") & (userXorO == "x"))
                {
                    Console.WriteLine("YOU WON!\n");
                    Console.WriteLine("Would you like to play again? (y or n)");
                    userResponse = Console.ReadLine();
                }

                //if the game status has X as the winner and the player piece is o, then tell them they lost
                else if ((gameStatus == "X") & (userXorO == "o"))
                {
                    Console.WriteLine("YOU LET THE COMPUTER BEAT YOU?\n");
                    Console.WriteLine("Would you like to play again? ( y or n )");
                    userResponse = Console.ReadLine();
                }

                //Same logic as above
                if ((gameStatus == "O") & (userXorO == "x"))
                {
                    Console.WriteLine("YOU LET THE COMPUTER BEAT YOU?\n");
                    Console.WriteLine("Would you like to play again? ( y or n )");
                    userResponse = Console.ReadLine();
                }

                else if ((gameStatus == "O") & (userXorO == "o"))
                {
                    Console.WriteLine("YOU WON!\n");
                    Console.WriteLine("Would you like to play again? (y or n)");
                    userResponse = Console.ReadLine();
                }

                //if we have gone through all 9 turns and the game status does not show x or o as a winner then there is a tie, inform the player
                if ((turn > 9) & (gameStatus != "X") & (gameStatus != "O"))
                {
                    Console.WriteLine("IT'S A TIE!!!\n");
                    Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? (y or n)\n\n");
                    userResponse = Console.ReadLine();
                    gameStatus = "T";
                }

                //continue to get player moves while the there is no winner and no tie
            } while ((gameStatus != "X") & (gameStatus != "O") & (gameStatus != "T"));

            //If the player chooses to quit then end the overall game loop.  If the player chooses to continue playing start at the top of the outer do, while loop
        } while (userResponse != "n");

    }//Run

    static void Main()
    {
        //Create an instance of the gameloop class and run it
        GameLoop g = new GameLoop();
        g.Run();
    }

}//End GameLoop 
}
