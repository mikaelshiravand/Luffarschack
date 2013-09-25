using System;
using System.Collections.Generic;

class Program
{
    public static void menu()
    {
        "Välkommen till TicTacToe!!".EchoWriteLine();
        "Ange namn på Spelare1\n->".EchoWrite();
        "Ange namn på Spelare2\n->".EchoWrite();
    }
    static void Main()
    {
        Board board = new Board();
        board.PrintBoard();
        menu();
    }
}

