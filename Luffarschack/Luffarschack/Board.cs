using System;
using System.Collections.Generic;

public class Board
{
    // Properties
    public string[] SquareArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public bool P1Win = false;
    public bool P2Win = false;
    public bool NoWin = false;
    
    // Methods
    public void ChangeValueAndMarker(string square, string playerMarker)
    {
        string localColor = "";
        if (playerMarker == "X")
            localColor = "Green";
        else
            localColor = "Blue";

        if (square == "1" && SquareArray[0] == "1")
        {
            playerMarker.CW(6, 3, localColor);
            SquareArray[0] = playerMarker;
        }
        else if (square == "2" && SquareArray[1] == "2")
        {
            playerMarker.CW(14, 3, localColor);
            SquareArray[1] = playerMarker;
        }
        else if (square == "3" && SquareArray[2] == "3")
        {
            playerMarker.CW(22, 3, localColor);
            SquareArray[2] = playerMarker;
        }
        else if (square == "4" && SquareArray[3] == "4")
        {
            playerMarker.CW(6, 7, localColor);
            SquareArray[3] = playerMarker;
        }
        else if (square == "5" && SquareArray[4] == "5")
        {
            playerMarker.CW(14, 7, localColor);
            SquareArray[4] = playerMarker;
        }
        else if (square == "6" && SquareArray[5] == "6")
        {
            playerMarker.CW(22, 7, localColor);
            SquareArray[5] = playerMarker;
        }
        else if (square == "7" && SquareArray[6] == "7")
        {
            playerMarker.CW(6, 11, localColor);
            SquareArray[6] = playerMarker;
        }
        else if (square == "8" && SquareArray[7] == "8")
        {
            playerMarker.CW(14, 11, localColor);
            SquareArray[7] = playerMarker;
        }
        else if (square == "9" && SquareArray[8] == "9")
        {
            playerMarker.CW(22, 11, localColor);
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

        else if (SquareArray[0] != "1" &&
            SquareArray[1] != "2" &&
            SquareArray[2] != "3" &&
            SquareArray[3] != "4" &&
            SquareArray[4] != "5" &&
            SquareArray[5] != "6" &&
            SquareArray[6] != "7" &&
            SquareArray[7] != "8" &&
            SquareArray[8] != "9")
        {
            NoWin = true;
        }
    }

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

        SquareArray[0] = "1";
        SquareArray[1] = "2";
        SquareArray[2] = "3";
        SquareArray[3] = "4";
        SquareArray[4] = "5";
        SquareArray[5] = "6";
        SquareArray[6] = "7";
        SquareArray[7] = "8";
        SquareArray[8] = "9";
    }

    public void NewGame(Board MyBoard)
    {
        Console.Clear();
        Program.PrintInfoAboutPlayers();
        MyBoard.PrintBoard();
        MyBoard.ResetProperties();
        Program.TurnOne();
    }
}
