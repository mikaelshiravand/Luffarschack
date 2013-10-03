﻿using System;
using System.Collections.Generic;

class Program
{
    //Martin säger: Om vi skapar myBoard och players här så kommer vi åt den på fler ställen, men själva värdet på myBoard skapas fortfarande i Main.
    public static Board MyBoard;
    public static Player Player1;
    public static Player Player2;
    public static int whoseTurn = 0;
    public static string playerChoiceOfSquare = "";
    public static bool MultiPlayer = false;
    public static int ComputerPlayer;
    public static ComputerMartin AiMartin;
 

    static void programInfo()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Title = "Grupp 4: Tic Tac Toe";
        Console.SetWindowSize(80, 27);
    }
    static void startMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        "Välkommen till Grupp 4 TicTacToe!".CW(0, 0, "White");

        Console.ForegroundColor = ConsoleColor.White;
        
        "1 : Spelare mot Spelare.".CW(0, 2, "Gray");
        "2 : Spelare mot Linhs Datorspelare.".CW(0, 3, "Gray");
        "3 : Spelare mot Martins Datorspelare.".CW(0, 4, "Gray");
        "4 : Spelare mot Mikaels Datorspelare.".CW(0, 5, "Gray");
        "5 : Spelare mot Rabihs Datorspelare.".CW(0, 6, "Gray");

        "Vänligen välj spelläge: ".CW(0, 8, "White");
        
        string gameModeInput = Console.ReadLine();

        if (gameModeInput == "1")
        {
            Player1.Player1Name(Player1);
            Console.ForegroundColor = ConsoleColor.Gray;
            "Ange namn på Spelare 2\n-> ".EchoWrite();
            Console.ForegroundColor = ConsoleColor.Blue;
            Player2.Name = Console.ReadLine();
            MultiPlayer = true;
         }
        else if (gameModeInput == "2")
        {
            Player1.Player1Name(Player1);
            Player2.Name = "DatorLinh";
            MultiPlayer = false;
            ComputerPlayer = 1;
        }
        else if (gameModeInput == "3")
        {
            Player1.Player1Name(Player1);
            Player2.Name = "DatorMartin";
            MultiPlayer = false;
            ComputerPlayer = 2;
        }
        else if (gameModeInput == "4")
        {
            Player1.Player1Name(Player1);
            Player2.Name = "DatorMikael";
            MultiPlayer = false;
            ComputerPlayer = 3;
        }
        else if (gameModeInput == "5")
        {
            Player1.Player1Name(Player1);
            Player2.Name = "DatorRabih";
            MultiPlayer = false;
            ComputerPlayer = 4;
        }
        else
        {
            Console.SetCursorPosition(0, 9);
            "Fel Inmatning. Försök igen!".EchoWriteLine();
            startMenu();
        }
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

    public static void turnQueue()
    {
        if (whoseTurn == 0)
            whoWillStart();
        else
            whoseTurn++;

        //Console.ForegroundColor = ConsoleColor.DarkGray; TODOMartin: Tror inte att denna raden används, ska tas bort sist av allat
        if (whoseTurn % 2 == 0)
        {
            clearLowerScreen();
            ("\nDet är " + Player1.Name + returnLastLetter(Player1.Name) + " tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "Green");
            Player.InputSquareChoice(Player1.Marker);
        }
        else
        {
            if (MultiPlayer == true)
            {
                clearLowerScreen();
                ("\nDet är " + Player2.Name + returnLastLetter(Player2.Name) + " tur, välj ruta och tryck ENTER\n-> ").CW(2, 15, "Blue");
                Player.InputSquareChoice(Player2.Marker);
            }
            else if (MultiPlayer == false)
            {
                clearLowerScreen();
                ("\nDet är " + Player2.Name + returnLastLetter(Player2.Name) + " tur att välja en ruta, var god vänta.").CW(2, 15, "Blue");

                // Här ska Datorspelarens drag göras (istället för en Console.ReadLine)

                if(ComputerPlayer == 1) // Om det är Linhs Datorspelare
                {
                    // Kalla på er Datorspelarklass olika metoder
                }
                else if (ComputerPlayer == 2) // Om det är Martins Datorspelare
                {
                    AiMartin.SquareOfChoice();
                    
                }
                else if (ComputerPlayer == 3) // Om det är Mikaels Datorspelare
                {
                    // Kalla på er Datorspelarklass olika metoder
                }
                else if (ComputerPlayer == 4) // Om det är Rabihs Datorspelare
                {
                    // Kalla på er Datorspelarklass olika metoder
                }
            }
        }
        

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
            Console.ForegroundColor = ConsoleColor.Yellow;
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

    public static void whoWillStart()
    {
        Random rand = new Random();
        //Martin: google verkar säga att man ska skriva .Next("lägsta talet", "högsta talet") men 3 verkar vara "mindre än 3"
        whoseTurn = rand.Next(1, 3);
    }

    public static void oneTurn()
    {
        while (MyBoard.P1Win == false || MyBoard.P2Win == false)
        {
            turnQueue();
        }
    }
    static void Main()
    {
        programInfo();
        Player1 = new Player("", "X");
        Player2 = new Player("", "O");
        MyBoard = new Board();
        // Gör AiMartin till ett objekt för att kunna kalla på metoder i klassen ComputerMartin
        AiMartin = new ComputerMartin("hej"); 

        startMenu();
        Console.Clear();
        printInfoAboutPlayers();
        MyBoard.PrintBoard();
        oneTurn();
    }
}

