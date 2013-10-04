using System;
using System.Collections.Generic;

public class Player
{
    // Properties
    public string Name;
    public int NumberOfWins;
    public int NoWin;
    public string Marker;
    public static string SquareOfChoice = "";
    
    // Constructors
    public Player(string name, string marker)
    {
        Name = name;
        Marker = marker;
        NumberOfWins = 0;
        NoWin = 0;
    }
    
    // Methods for Input and Controll of Input
    public static void InputSquareChoice()
    {
        string fillRestOfLine = new string(' ', Console.WindowWidth - 3); // Jag skriver WindowWidth -3 eftersom vi på raden nedanför skriver ut på position x = 3
        fillRestOfLine.CW(3, 17, "");
        Console.SetCursorPosition(3, 17);
        SquareOfChoice = Console.ReadLine(); // Detta är en string eftersom vi även skickar vidare "SquareOfChoice" in i andra metoder. 
    }
    public static void CheckIfSquareChoiceIsOk(string playerMarker, string localChoice)
    {
        int localNumber;
        string fillRestOfLine = new string(' ', Console.WindowWidth - 3); // Jag skriver WindowWidth -3 eftersom vi på raden nedanför skriver ut på position x = 3

        // Om inmatningen (som är SquareOfCoice från metoden InputSquareOfChoice) går att göra om till en int, och den är lika med eller mindre än 9, och det inte är en nolla händer detta:
        if (int.TryParse(localChoice, out localNumber) && localNumber <= 9 && localNumber > 0)
        {
            if (Program.MyBoard.SquareArray[Convert.ToInt32(localChoice) - 1] != "X" && Program.MyBoard.SquareArray[Convert.ToInt32(localChoice) - 1] != "O") // Här ska du kolla att inmatningens plats INTE är upptagen, MN:Nu gör jag det
            {
                Program.MyBoard.ChangeMarkerOnBoardSquare(localChoice, playerMarker);
                Program.InputOk = true; // Här är enda stället som vi går ur while(InputOk == false) i Program
            }
            else // Om den ÄR upptagen händer detta:
            {
                Console.ForegroundColor = ConsoleColor.White;
                fillRestOfLine.CW(0, 18, "");
                Console.SetCursorPosition(0, 18);
                "Du kan inte sätta din markör på en upptagen ruta. Försök igen!".EchoWriteLine();
                setColorForCorrectingInput(playerMarker);
            }
        }
        else // Om inmatningen är högre än nummer 9, eller om den är 0 (eller mindre, dvs negativt tal) eller om det är en/flera bokstav händer detta:
        {
            Console.ForegroundColor = ConsoleColor.White;
            fillRestOfLine.CW(0, 18, "");
            Console.SetCursorPosition(0, 18);
            "Fel Inmatning. Försök igen!".EchoWriteLine();
            setColorForCorrectingInput(playerMarker);
        }

    } // Slut på CheckIfSquareChoiceIsOk

    // Other methods
    public static void setColorForCorrectingInput(string playerMarker)
    {
        if (playerMarker == "X")
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Blue;
    }
    
    public void Player1Name(Player Player1)
    {
        //Player1 = new Player("", "X"); //TODOMN:Kolla att detta blir rätt placerat här.
        Console.ForegroundColor = ConsoleColor.Gray;
        "Ange namn på Spelare ett\n-> ".CW(0, 14, "Gray");
        Console.ForegroundColor = ConsoleColor.Green;
        Player1.Name = Console.ReadLine();
    }
    public void Player2Name(Player Player2)
    {
        //Player2 = new Player("", "O"); //TODOMN:Kolla att detta blir rätt placerat här.
        Console.ForegroundColor = ConsoleColor.Gray;
        "Ange namn på Spelare två\n-> ".CW(0, 16, "Gray");
        Console.ForegroundColor = ConsoleColor.Blue;
        Player2.Name = Console.ReadLine();
    }
}

