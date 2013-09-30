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


    // Mikael -> Martin
    // ((Jag tror att detta kan funka...lol))
    // Har börjat på en metod som kan ersätta stora delar av "den 100 rader långa metoden"
    // Kan inte göra mer på denna eftersom det kommer in på ditt område
    // Alltså får du testa om den fungerar eller inte.
    public void Input()
    {
        string input = Console.ReadLine();
        int number;
        
        // Om inmatningen går att göra om till en int, och den är lika med eller mindre än 9, och det inte är en nolla händer detta:
        if (int.TryParse(input, out number) && number <= 9 && number != 0)
        {
            
            if () // Här ska du kolla att inamtningens plats INTE är upptagen
            {
                // Då ska du sätta spelarens markör på input platsen
            }
            else // Om den ÄR upptagen händer detta:
            {
                Console.ForegroundColor = ConsoleColor.White;
                "Du kan inte sätta din markör på en upptagen ruta. Försök igen!".EchoWriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
        else // Om inmatningen är högre än nummer 9, eller om den är 0 eller om det är en/flera bokstav händer detta:
        {
            Console.ForegroundColor = ConsoleColor.White;
            "Fel Inmatning. Försök igen!".EchoWriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        
                
    }
}

