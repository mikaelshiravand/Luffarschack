using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    //Martin säger: Om vi skapar myBoard och players här så kommer vi åt den på fler ställen, men själva värdet på myBoard skapas fortfarande i Main.
    public static Board MyBoard;
    public static Player Player1;
    public static Player Player2;
    public static int whoseTurn = 0;
    public static string playerChoiceOfSquare = "";
    public static bool Player1Human = false; //TODOMN:från multiplayer
    public static bool Player2Human = false;
    public static int ComputerPlayer;
    // Martin: Tror inte att ett objekt av ComputerOrjan behövs, som följer: public static ComputerOrjan AiOrjan; (sök på TODOMN (omkring rad 270) för mer info
    public static bool InputOk;

    // Methods for GamePlay
    
   
    static void startMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        "Välkommen till Grupp 4 TicTacToe!".CW(0, 0, "Yellow");

        Console.ForegroundColor = ConsoleColor.White;

        "1 : Människa.".CW(0, 2, "Gray");
        "2 : Linhs Datorspelare.".CW(0, 3, "Gray");
        "3 : Martins Datorspelare.".CW(0, 4, "Gray");
        "4 : Mikaels Datorspelare.".CW(0, 5, "Gray");
        "5 : Rabihs Datorspelare.".CW(0, 6, "Gray");
        "6 : Amatör-Örjans Datorspelare.".CW(0, 7, "Gray");

        while (true)
        {
            "Välj Player 1: ".CW(0, 9, "White");
            string Play1 = Console.ReadLine();
            if (Play1 == "1")
            {
                Player1Human = true;
                Player1.Player1Name(Player1);
                break;
            }
            else if (Play1 == "2" || Play1 == "3" || Play1 == "4" || Play1 == "5" || Play1 == "6")
            {
                createComputerPlayer1(Play1);
                break;
            }
            else
            {
                checkInputInStartMenu();
            }
        }// avslutar while(true) för att göra spelare 1

        while (true)
        {
            "Välj Player 2: ".CW(0, 9, "White");
            string Play2 = Console.ReadLine();
            if (Play2 == "1")
            {
                Player2Human = true;
                Player2.Player2Name(Player2); //TODOMN:Denna kanske bara funkar om Player görs först i main
                break;
            }
            else if (Play2 == "2" || Play2 == "3" || Play2 == "4" || Play2 == "5" || Play2 == "6")
            {
                createComputerPlayer2(Play2);
                break;
            }
            else
            {
                checkInputInStartMenu();
            }
        } // avslutar while(true) för att göra spelare 2
    } // avslutar hela startMenu()

    public static void turnQueue()
    {
        if (whoseTurn == 0)
            whoWillStart();
        else
            whoseTurn++;

        if (whoseTurn % 2 == 0) // Om whosTurn faller på spelare1 
        {
            if (Player1Human == true)
            {
                clearLowerScreen();
                ("\nDet är " + Player1.Name + returnLastLetter(Player1.Name) + " tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "Green");
                InputOk = false;
                while (InputOk == false)
                {
                    Player.InputSquareChoice();
                    Player.CheckIfSquareChoiceIsOk(Player1.Marker, Player.SquareOfChoice);
                }
            }
            else
            {
                clearLowerScreen();
                waitingForComputerPlayer(1);
                computerPlayerMove(Player1.Marker);
            }
        } // Avslutar om whoseTurn är på spelare1

        else // Om whosTurn faller på spelare2
        {
            if (Player2Human == true) 
            {
                clearLowerScreen();
                ("\nDet är " + Player2.Name + returnLastLetter(Player2.Name) + " tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "Blue");
                InputOk = false;
                while (InputOk == false)
                {
                    Player.InputSquareChoice();
                    Player.CheckIfSquareChoiceIsOk(Player2.Marker, Player.SquareOfChoice);
                }
            }
            else
            {
                clearLowerScreen();
                waitingForComputerPlayer(2);
                computerPlayerMove(Player2.Marker);
            }
        }// Avslutar om whoseTurn är på spelare2

        MyBoard.CheckWinner();

        if (MyBoard.P1Win == true)
        {
            clearLowerScreen();
            ("\nGRATTIS! " + Player1.Name + " vann! \nTryck ENTER för nästa spel.\n-> ").CW(2, 15, "Yellow");
            Console.ReadKey();
            //Spelare1 vinner.
            Player1.NumberOfWins++;
            // Supersnygg mini-metod istället för megastor copypaste
            MyBoard.NewGame(MyBoard);
        }

        else if (MyBoard.P2Win == true)
        {
            clearLowerScreen();
            ("\nGRATTIS! " + Player2.Name + " vann! \nTryck ENTER för nästa spel.\n-> ").CW(2, 15, "Yellow");
            Console.ReadKey();
            //Spelare2 vinner.
            Player2.NumberOfWins++;
            // Supersnygg mini-metod istället för megastor copypaste
            MyBoard.NewGame(MyBoard);
        }

        else if (MyBoard.NoWin == true)
        {
            // Martin: Denna raden behövs nog inte.....Console.ForegroundColor = ConsoleColor.Yellow;
            clearLowerScreen();
            ("\nOAVGJORT!" +
            "\nTryck ENTER för nästa spel.\n-> ").CW(2, 15, "Red");
            Console.ReadKey();
            // Ingen vinner.
            Player1.NoWin++;
            Player2.NoWin++;
            // Supersnygg mini-metod istället för megastor copypaste
            MyBoard.NewGame(MyBoard);
        }

    }

    public static void oneTurn()
    {
        while (MyBoard.P1Win == false || MyBoard.P2Win == false)
        {
            turnQueue();
        }
    }


    static void computerPlayerMove(string playerMarker_XorO)
    {
        if (ComputerPlayer == 1) // Om det är Linhs Datorspelare
        {
            // Kalla på er Datorspelarklass olika metoder
        }
        else if (ComputerPlayer == 2) // Om det är Martins Datorspelare
        {
            InputOk = false;
            while (InputOk == false)
            {
                ComputerMartin.InputSquareChoice();
                Player.CheckIfSquareChoiceIsOk(playerMarker_XorO, ComputerMartin.SquareOfChoice);
            }
        }
        else if (ComputerPlayer == 3) // Om det är Mikaels Datorspelare
        {
            // Kalla på er Datorspelarklass olika metoder
        }
        else if (ComputerPlayer == 4) // Om det är Rabihs Datorspelare
        {
            // Kalla på er Datorspelarklass olika metoder
        }
        else if (ComputerPlayer == 5) // Om det är Amatör-Örjans Datorspelare
        {
            InputOk = false;
            while (InputOk == false)
            {
                ComputerOrjan.InputSquareChoice();
                Player.CheckIfSquareChoiceIsOk(playerMarker_XorO, ComputerOrjan.SquareOfChoice);
            }
        }
    }
    static void createComputerPlayer1(string number)
    {
        clearStartMenuScreen();
        if (number == "2")
        {
            Player1.Name = "DatorLinh";
            ComputerPlayer = 1;
        }
        else if (number == "3")
        {
            Player1.Name = "DatorMartin";
            ComputerPlayer = 2;
        }
        else if (number == "4")
        {
            Player1.Name = "DatorMikael";
            ComputerPlayer = 3;
        }
        else if (number == "5")
        {
            Player1.Name = "DatorRabih";
            ComputerPlayer = 4;
        }
        else if (number == "6")
        {
            Player1.Name = "DatorÖrjan";
            ComputerPlayer = 5;
        }
    }
    static void createComputerPlayer2(string number)
    {
        clearStartMenuScreen();
        if (number == "2")
        {
            Player2.Name = "DatorLinh";
            ComputerPlayer = 1;
        }
        else if (number == "3")
        {
            Player2.Name = "DatorMartin";
            ComputerPlayer = 2;
        }
        else if (number == "4")
        {
            Player2.Name = "DatorMikael";
            ComputerPlayer = 3;
        }
        else if (number == "5")
        {
            Player2.Name = "DatorRabih";
            ComputerPlayer = 4;
        }
        else if (number == "6")
        {
            Player2.Name = "DatorÖrjan";
            ComputerPlayer = 5;
        }

    }

    // Helping methods
    static void checkInputInStartMenu()
    {
        clearStartMenuScreen();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(24, 9);
        "\nFel Inmatning. Försök igen!".EchoWriteLine();
        startMenu();
    }

    static void programInfo()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Title = "Grupp 4: Tic Tac Toe";
        Console.SetWindowSize(80, 27);
    }
    
    public static void printInfoAboutPlayers()
    {
        Console.SetCursorPosition(3, 2);

        Console.ForegroundColor = ConsoleColor.Green;
        ("\t\t\t\tSpelare 1: " + Player1.Name).EchoWriteLine();
        ("\t\t\t\tAntal segrar: " + Player1.NumberOfWins).EchoWriteLine();
        ("\t\t\t\tSpelmarkör: " + Player1.Marker).EchoWriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        ("\n").EchoWriteLine();
        ("\t\t\t\tOavgjort:" + Player1.NoWin).EchoWriteLine();
        ("\n").EchoWriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        ("\t\t\t\tSpelare 2: " + Player2.Name).EchoWriteLine();
        ("\t\t\t\tAntal segrar: " + Player2.NumberOfWins).EchoWriteLine();
        ("\t\t\t\tSpelmarkör: " + Player2.Marker).EchoWriteLine();
    }

    public static void clearStartMenuScreen()
    {
        string blankRow = new string(' ', Console.WindowWidth);
        blankRow.CW(24, 9, "DarkGray");
        blankRow.CW(0, 10, "DarkGray");
        blankRow.CW(0, 11, "DarkGray");

    }
    public static void clearLowerScreen()
    {
        string blankRow = new string(' ', Console.WindowWidth);
        blankRow.CW(0, 15, "DarkGray");
        blankRow.CW(0, 16, "DarkGray");
        blankRow.CW(0, 17, "DarkGray");
        blankRow.CW(0, 18, "DarkGray");
        blankRow.CW(0, 19, "DarkGray");
        blankRow.CW(0, 20, "DarkGray");
        blankRow.CW(0, 21, "DarkGray");
        blankRow.CW(0, 22, "DarkGray");
        blankRow.CW(0, 23, "DarkGray");
        blankRow.CW(0, 24, "DarkGray");
        blankRow.CW(0, 25, "DarkGray");
    }

    private static void waitingForComputerPlayer(int Player1or2)
    {
        if (Player1or2 == 1)
        {
            (Player1.Name + " tänker, var god vänta.").CW(2, 15, "Green");
            Thread.Sleep(1000);
            //(Player2.Name + " tänker, var god vänta. .").CW(2, 15, "Green");
            //Thread.Sleep(1000);
            //(Player2.Name + " tänker, var god vänta. . .").CW(2, 15, "Green");
            //Thread.Sleep(1000);
            //(Player2.Name + " tänker, var god vänta. . . .").CW(2, 15, "Green");
            //Thread.Sleep(1000);
        }
        if (Player1or2 == 2)
        {
            (Player2.Name + " tänker, var god vänta.").CW(2, 15, "Cyan");
            Thread.Sleep(1000);
            //(Player2.Name + " tänker, var god vänta. .").CW(2, 15, "Cyan");
            //Thread.Sleep(1000);
            //(Player2.Name + " tänker, var god vänta. . .").CW(2, 15, "Cyan");
            //Thread.Sleep(1000);
            //(Player2.Name + " tänker, var god vänta. . . .").CW(2, 15, "Cyan");
            //Thread.Sleep(1000);
        }
    }
    
    public static void whoWillStart()
    {
        Random rand = new Random();
        //Martin: google verkar säga att man ska skriva .Next("lägsta talet", "högsta talet") men 3 verkar vara "mindre än 3"
        whoseTurn = rand.Next(1, 3);
    }

    public static string returnLastLetter(string playerName)
    {
        string x = "s";
        string LastCharOfName = Convert.ToString(playerName[playerName.Length - 1]);

        if (LastCharOfName == x)
        {
            x = "";
        }

        return x;
    }




    // Main method
    static void Main()
    {
        programInfo();
        Player1 = new Player("", "X"); 
        Player2 = new Player("", "O");
        MyBoard = new Board();
        // Martin: Kommentar kl 9.00 Gör AiOrjan till ett objekt för att kunna kalla på metoder i klassen ComputerOrjan.
        // Martin: Kommentar kl 11.30 Jag kom på att AiOrjan aldrig någonsin behöver användas, kommenterar ut den men låter den stå kvar för säkerhetsskull. TODOMN:Radera AiOrjan innan inlämning om den inte behövs
        //AiOrjan = new ComputerOrjan(); 

        startMenu();
        Console.Clear();
        printInfoAboutPlayers();
        MyBoard.PrintBoard();
        oneTurn();
    }
    
   
}

