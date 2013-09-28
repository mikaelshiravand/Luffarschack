using System;
using System.Collections.Generic;

public class Player
{
    public string Name;
    public int NumberOfWins;
    public string Marker;

    public Player(string name, string marker)
    {
        Name = name;
        Marker = marker;
        NumberOfWins = 0;
    }

    // TODOPlayer Denna metoden skulle helst kalla på ChangeValueOfBoardSquare i klassen Board.
    public void PlaceMarker(string square, string X_or_O)
    {
        string marker = X_or_O;
        string boardSquare = square;

    }
}

