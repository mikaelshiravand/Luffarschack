using System;
using System.Collections.Generic;

public class Player
{
    // Properties
    public string Name;

    public int NumberOfWins;
    // Martin: Jag tog bort NumberOfLoses för det kommer ju ändå bara att vara samma info som den andre spelarens vinster
    public string Marker;

    // Constructor
    public Player(string name, string marker)
    {
        Name = name;
        Marker = marker;
        NumberOfWins = 0;
    }

    // Methods

    // TODOPlayer Denna metoden skulle helst kalla på ChangeValueOfBoardSquare i klassen Board.
    public void PlaceMarker(string square, string X_or_O)
    {
        string marker = X_or_O;
        string boardSquare = square;


    }


}

