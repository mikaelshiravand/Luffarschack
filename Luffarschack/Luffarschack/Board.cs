using System;
using System.Collections.Generic;

public class Board
{
    // Properties
    public string Name { get; set; }
    public string Layout { get; set; }
    public string[] SquareArray = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };
    public bool P1Win = false;
    public bool P2Win = false;
    public bool NoWin = false;

    // Constructor
    public Board()
    {

    }

    // Methods used after every User- (or Computer) Input while playing
    public void ChangeMarkerOnBoardSquare(string square, string playerMarker)
    {
        string localColor = "";
        if (playerMarker == "X")
            localColor = "Green";
        else
            localColor = "Blue";


        if (square == "1" && SquareArray[0] == "0")
        {
            playerMarker.CW(6, 3, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "2" && SquareArray[1] == "0")
        {
            playerMarker.CW(14, 3, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "3" && SquareArray[2] == "0")
        {
            playerMarker.CW(22, 3, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "4" && SquareArray[3] == "0")
        {
            playerMarker.CW(6, 7, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "5" && SquareArray[4] == "0")
        {
            playerMarker.CW(14, 7, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "6" && SquareArray[5] == "0")
        {
            playerMarker.CW(22, 7, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "7" && SquareArray[6] == "0")
        {
            playerMarker.CW(6, 11, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "8" && SquareArray[7] == "0")
        {
            playerMarker.CW(14, 11, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
        else if (square == "9" && SquareArray[8] == "0")
        {
            playerMarker.CW(22, 11, localColor);
            ChangeValueOfBoardSquare(square, playerMarker);
        }
    }

    public void ChangeValueOfBoardSquare(string square, string playerMarker)
    {

        string boardsquare = square;

        if (square == "1" && SquareArray[0] == "0")
        {
            SquareArray[0] = playerMarker;
        }
        else if (square == "2" && SquareArray[1] == "0")
        {
            SquareArray[1] = playerMarker;
        }
        else if (square == "3" && SquareArray[2] == "0")
        {
            SquareArray[2] = playerMarker;
        }
        else if (square == "4" && SquareArray[3] == "0")
        {
            SquareArray[3] = playerMarker;
        }
        else if (square == "5" && SquareArray[4] == "0")
        {
            SquareArray[4] = playerMarker;
        }
        else if (square == "6" && SquareArray[5] == "0")
        {
            SquareArray[5] = playerMarker;
        }
        else if (square == "7" && SquareArray[6] == "0")
        {
            SquareArray[6] = playerMarker;
        }
        else if (square == "8" && SquareArray[7] == "0")
        {
            SquareArray[7] = playerMarker;
        }
        else if (square == "9" && SquareArray[8] == "0")
        {
            SquareArray[8] = playerMarker;
        }
    }

    public void CheckWinner()
    {
        if (SquareArray[0] == "X" && SquareArray[1] == "X" && SquareArray[2] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[3] == "X" && SquareArray[4] == "X" && SquareArray[5] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[6] == "X" && SquareArray[7] == "X" && SquareArray[8] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[0] == "X" && SquareArray[3] == "X" && SquareArray[6] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[1] == "X" && SquareArray[4] == "X" && SquareArray[7] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[2] == "X" && SquareArray[5] == "X" && SquareArray[8] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[0] == "X" && SquareArray[4] == "X" && SquareArray[8] == "X")
        {
            P1Win = true;
        }
        else if (SquareArray[2] == "X" && SquareArray[4] == "X" && SquareArray[6] == "X")
        {
            P1Win = true;
        }


        else if (SquareArray[0] == "O" && SquareArray[1] == "O" && SquareArray[2] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[3] == "O" && SquareArray[4] == "O" && SquareArray[5] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[6] == "O" && SquareArray[7] == "O" && SquareArray[8] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[0] == "O" && SquareArray[3] == "O" && SquareArray[6] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[1] == "O" && SquareArray[4] == "O" && SquareArray[7] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[2] == "O" && SquareArray[5] == "O" && SquareArray[8] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[0] == "O" && SquareArray[4] == "O" && SquareArray[8] == "O")
        {
            P2Win = true;
        }
        else if (SquareArray[2] == "O" && SquareArray[4] == "O" && SquareArray[6] == "O")
        {
            P2Win = true;
        }

        else if (SquareArray[0] != "0" &&
            SquareArray[1] != "0" &&
            SquareArray[2] != "0" &&
            SquareArray[3] != "0" &&
            SquareArray[4] != "0" &&
            SquareArray[5] != "0" &&
            SquareArray[6] != "0" &&
            SquareArray[7] != "0" &&
            SquareArray[8] != "0")
        {
            NoWin = true;
        }
    }

    // Methods used before a new game
    public void PrintBoard()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, 1);
        "  ╔═══════╦═══════╦═══════╗\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ║   1   ║   2   ║   3   ║\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ╠═══════╬═══════╬═══════╣\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ║   4   ║   5   ║   6   ║\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ╠═══════╬═══════╬═══════╣\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ║   7   ║   8   ║   9   ║\n".EchoWrite();
        "  ║       ║       ║       ║\n".EchoWrite();
        "  ╚═══════╩═══════╩═══════╝\n".EchoWrite();
    }

    public void ResetProperties()
    {
        P1Win = false;
        P2Win = false;
        NoWin = false;

        SquareArray[0] = "0";
        SquareArray[1] = "0";
        SquareArray[2] = "0";
        SquareArray[3] = "0";
        SquareArray[4] = "0";
        SquareArray[5] = "0";
        SquareArray[6] = "0";
        SquareArray[7] = "0";
        SquareArray[8] = "0";
    }

    public void NewGame(Board MyBoard)
    {
        Console.Clear();
        Program.printInfoAboutPlayers();
        MyBoard.PrintBoard();
        MyBoard.ResetProperties();
        Program.oneTurn();
    }
}
