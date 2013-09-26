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

        // Mikael: När ENTER trycks ned så...
        if (Console.Read() == (char)13)
        {
            // Här måste vi skriva (något i form med) att spelarens nuvarande marker ersätter den nuvarande positionens permanenta värde (för resten av den rundan).
            // T.ex. Om jag är Spelare1 och jag är på B2 och trycker Enter så ska B2's värde ändras till X, och ingen annan ska få ändra B2 mer i resten av den rundan.
        }
        
    }


    // Mikael: Tillfällig test-metod för styrning. Än så länge sätter den cursor på B2 (mitteN) efter att spelarna fyllt i sina namn.
    // Detta kan t.ex. vara styrningsmetoden.
    public static void Move()
    {
        // Sätter cursor på B2.
        Console.SetCursorPosition(9, 6);

        Console.ReadLine();
    }

}

