using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    // Properties
    public static Board MyBoard;
    public static Player Player1;
    public static Player Player2;
    public static int whoseTurn = 0;
    public static bool Player1Human = false; 
    public static bool Player2Human = false;
    public static int ComputerPlayer;
    public static bool InputOk;
    public static string fillLine = new string(' ', Console.WindowWidth); // För att radera felaktiga inmatningar av användaren

    // Methods
    static void StartMenu()
    {
        "Välkommen till Grupp 4 TicTacToe!".CW(0, 0, "Yellow");

        Console.ForegroundColor = ConsoleColor.White;

        "1 : Människa.".CW(0, 2, "Gray");
        "2 : Martins Datorspelare.".CW(0, 3, "Gray");
        "3 : Amatör-Örjans Datorspelare.".CW(0, 4, "Gray");

        StartMenuCreatePlayer1();
        StartMenuCreatePlayer2();
        
        "Spelarna är valda, tryck på valfri tangent för att börja spela!".CW(0, 20, "Yellow");
        Console.ReadKey();
    } 

    static void StartMenuCreatePlayer1()
    {
        while (true)
        {
            fillLine.CW(0, 9, "");
            "Välj Spelare ett: ".CW(0, 9, "Green");
            Console.ForegroundColor = ConsoleColor.Gray;
            string play1 = Console.ReadLine();
            if (play1 == "1")
            {
                fillLine.CW(0, 10, "");
                Player1Human = true;
                Player1.Player1Name(Player1);
                break;
            }
            else if (play1 == "2" || play1 == "3")
            {
                CreateComputerPlayer1(play1);
                break;
            }
            else
            {
                CheckInputInStartMenu();
            }
        }
    }

    static void StartMenuCreatePlayer2()
    {
        while (true)
        {
            fillLine.CW(0, 9, "");
            "Välj Spelare två: ".CW(0, 9, "Blue");
            Console.ForegroundColor = ConsoleColor.Gray;
            string Play2 = Console.ReadLine();
            if (Play2 == "1")
            {
                fillLine.CW(0, 10, "");
                Player2Human = true;
                Player2.Player2Name(Player2);
                break;
            }
            else if (Play2 == "2" || Play2 == "3")
            {
                CreateComputerPlayer2(Play2);
                break;
            }
            else
            {
                CheckInputInStartMenu();
            }
        }
    }

    public static void TurnQueue()
    {
        MyBoard.CheckWinner();
        if (MyBoard.P1Win == true)
            Player1Win();
        else if (MyBoard.P2Win == true)
            Player2Win();
        else if (MyBoard.NoWin == true)
            NoWin();

        if (whoseTurn == 0)
            WhoWillStart();
        else
            whoseTurn++;

        if (whoseTurn % 2 == 0) // Om whosTurn faller på spelare1 
            Playe1Turn();
        else
            Player2Turn();
    }

    public static void Playe1Turn()
    {
        if (Player1Human == true)
        {
            ClearLowerScreen();
            ("\nDet är " + Player1.Name + ReturnLastLetter(Player1.Name) + " tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "Green");
            InputOk = false;
            while (InputOk == false)
            {
                Player.InputSquareChoice();
                Player.CheckIfSquareChoiceIsOk(Player1.Marker, Player.SquareOfChoice, Player1Human);
            }
        }
        else
        {
            ClearLowerScreen();
            WaitingForComputerPlayer(1);
            ComputerPlayerMove(Player1.Marker);
        }
    }

    public static void Player2Turn()
    {
        if (Player2Human == true)
        {
            ClearLowerScreen();
            ("\nDet är " + Player2.Name + ReturnLastLetter(Player2.Name) + " tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "Blue");
            InputOk = false;
            while (InputOk == false)
            {
                Player.InputSquareChoice();
                Player.CheckIfSquareChoiceIsOk(Player2.Marker, Player.SquareOfChoice, Player2Human);
            }
        }
        else
        {
            ClearLowerScreen();
            WaitingForComputerPlayer(2);
            ComputerPlayerMove(Player2.Marker);
        }
    }

    public static void Player1Win()
    {
        ClearLowerScreen();
        ("\nGRATTIS! " + Player1.Name + " vann! \nTryck ENTER för nästa spel.\n-> ").CW(2, 15, "Yellow");
        Console.ReadKey();
        Player1.NumberOfWins++;
        MyBoard.NewGame(MyBoard);
    }

    public static void Player2Win()
    {
        ClearLowerScreen();
        ("\nGRATTIS! " + Player2.Name + " vann! \nTryck ENTER för nästa spel.\n-> ").CW(2, 15, "Yellow");
        Console.ReadKey();
        Player2.NumberOfWins++;
        MyBoard.NewGame(MyBoard);
    }

    public static void NoWin()
    {
        ClearLowerScreen();
        ("\nOAVGJORT!" +
        "\nTryck ENTER för nästa spel.\n-> ").CW(2, 15, "Red");
        Console.ReadKey();
        Player1.NoWin++;
        MyBoard.NewGame(MyBoard);
    }

    public static void TurnOne()
    {
        while (MyBoard.P1Win == false || MyBoard.P2Win == false)
        {
            TurnQueue();
        }
    }

    static void ComputerPlayerMove(string playerMarker_XorO)
    {
        if ((Player1.Name == "DatorMartin" && playerMarker_XorO == "X") || (Player2.Name == "DatorMartin" && playerMarker_XorO == "O")) // Om det är Martins Datorspelare
        {
            InputOk = false;
            while (InputOk == false)
            {
                bool sendFalse = false; // Behövs för att skicka falskt till CheckIfSquareChoiceIsOk()
                ComputerMartin.ComInputSquareChoice(playerMarker_XorO);
                Player.CheckIfSquareChoiceIsOk(playerMarker_XorO, ComputerMartin.SquareOfChoice, sendFalse);
            }
        }
        else if ((Player1.Name == "DatorÖrjan" && playerMarker_XorO == "X") || (Player2.Name == "DatorÖrjan" && playerMarker_XorO == "O")) // Om det är Amatör-Örjans Datorspelare
        {
            InputOk = false;
            while (InputOk == false)
            {
                bool sendFalse = false; // Se 10 rader upp i koden
                ComputerOrjan.ComInputSquareChoice();
                Player.CheckIfSquareChoiceIsOk(playerMarker_XorO, ComputerOrjan.SquareOfChoice, sendFalse);
            }
        }
    }

    static void CreateComputerPlayer1(string number)
    {
        ClearStartMenuScreen();
        if (number == "2")
        {
            Player1.Name = "DatorMartin";
            ComputerPlayer = 2;
            PrintPlayer1Name();
        }
        else if (number == "3")
        {
            Player1.Name = "DatorÖrjan";
            ComputerPlayer = 3;
            PrintPlayer1Name();
        }
    }

    static void CreateComputerPlayer2(string number)
    {
        ClearStartMenuScreen();
        if (number == "2")
        {
            Player2.Name = "DatorMartin";
            ComputerPlayer = 2;
            PrintPlayer2Name();
        }
        else if (number == "3")
        {
            Player2.Name = "DatorÖrjan";
            ComputerPlayer = 3;
            PrintPlayer2Name();
        }

    }

    static void PrintPlayer1Name()
    {
        ("Spelare ett heter").CW(0, 14, "Gray");
        "->".CW(0, 15, "Gray");
        (Player1.Name).CW(3, 15, "Green");
    }

    static void PrintPlayer2Name()
    {
        ("Spelare två heter").CW(0, 16, "Gray");
        "->".CW(0, 17, "Gray");
        (Player2.Name).CW(3, 17, "Blue");
    }
   
    static void CheckInputInStartMenu()
    {
        ClearStartMenuScreen();
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(24, 9);
        "\nFel Inmatning. Försök igen! (Ange ett nummer mellan 1-3) ".EchoWriteLine();
    }

    static void ProgramInfo()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Title = "Grupp 4: Tic Tac Toe";
        Console.SetWindowSize(80, 27);
    }
    
    public static void PrintInfoAboutPlayers()
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

    public static void ClearStartMenuScreen()
    {
        string blankRow = new string(' ', Console.WindowWidth);
        blankRow.CW(24, 9, "DarkGray");
        blankRow.CW(0, 10, "DarkGray");
        blankRow.CW(0, 11, "DarkGray");

    }

    public static void ClearLowerScreen()
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

    private static void WaitingForComputerPlayer(int player1or2)
    {
        if (player1or2 == 1)
        {
            (Player1.Name + " tänker, var god vänta.").CW(2, 15, "Green");
            Thread.Sleep(1000);
            (Player1.Name + " tänker, var god vänta. .").CW(2, 15, "Green");
            Thread.Sleep(1000);
            (Player1.Name + " tänker, var god vänta. . .").CW(2, 15, "Green");
            Thread.Sleep(1000);
           
        }
        if (player1or2 == 2)
        {
            (Player2.Name + " tänker, var god vänta.").CW(2, 15, "Blue");
            Thread.Sleep(1000);
            (Player2.Name + " tänker, var god vänta. .").CW(2, 15, "Blue");
            Thread.Sleep(1000);
            (Player2.Name + " tänker, var god vänta. . .").CW(2, 15, "Blue");
            Thread.Sleep(1000);
        }
    }
    
    public static void WhoWillStart()
    {
        Random rand = new Random();
        whoseTurn = rand.Next(1, 3); // Slumpar ett tal mellan 1-2
    }

    public static string ReturnLastLetter(string playerName)
    {
        string s = "s";
        string LastCharOfName = Convert.ToString(playerName[playerName.Length - 1]);

        if (LastCharOfName == s)
        {
            s = "";
        }

        return s;
    }

    // Main
    static void Main()
    {
        ProgramInfo();
        Player1 = new Player("", "X"); 
        Player2 = new Player("", "O");
        MyBoard = new Board();

        StartMenu();
        Console.Clear();
        PrintInfoAboutPlayers();
        MyBoard.PrintBoard();
        TurnOne();
    }
}

