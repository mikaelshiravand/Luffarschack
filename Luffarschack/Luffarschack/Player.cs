using System;
using System.Collections.Generic;

public class Player
{
    // Properties
    public string Name;
    public int NumberOfWins;
    public int NumberOfLoses;
    public string Marker;

    // Constructor
    public Player(string name, string marker)
    { 
        Name = name;
        Marker = marker;
        NumberOfWins = 0;
        NumberOfLoses = 0;
    }
    
    // Methods
    public void PlaceMarker(string X_or_O)
    {
        string marker = X_or_O;
        "Var vill du sätta en spelpjäs?".EchoWriteLine();
        //TODO: få det vi skriver här att sätta ett värde på MyBoard.
    }


}

