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
    }
    public Player()
    { 
        //If making a computerPlayer
    }
    
    // Methods
    public static void InputSquareChoice()
    {
        string fillRestOfLine = new string(' ', Console.WindowWidth - 3); // Jag skriver WindowWidth -3 eftersom vi på raden nedanför skriver ut på position x = 3
        fillRestOfLine.CW(3, 17, "");
        Console.SetCursorPosition(3, 17);
        SquareOfChoice = Console.ReadLine();
    }
    public static void CheckIfSquareChoiceIsOk(string playerMarker, string localChoice, bool isHuman)
    {
        int localNumber;
        string fillRestOfLine = new string(' ', Console.WindowWidth - 3);

        if (int.TryParse(localChoice, out localNumber) && localNumber <= 9 && localNumber > 0)
        {
            if (Program.MyBoard.SquareArray[Convert.ToInt32(localChoice) - 1] != "X" && Program.MyBoard.SquareArray[Convert.ToInt32(localChoice) - 1] != "O")
            {
                Program.MyBoard.ChangeValueAndMarker(localChoice, playerMarker);
                Program.InputOk = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                fillRestOfLine.CW(0, 18, "");
                if (isHuman == true)
                {
                    Console.SetCursorPosition(0, 18);
                    "Du kan inte sätta din markör på en upptagen ruta. Försök igen!".EchoWriteLine();
                    SetColorForCorrectingInput(playerMarker);
                }
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            fillRestOfLine.CW(0, 18, "");
            Console.SetCursorPosition(0, 18);
            "Fel Inmatning. Försök igen!".EchoWriteLine();
            SetColorForCorrectingInput(playerMarker);
        }
    }

    public static void SetColorForCorrectingInput(string playerMarker)
    {
        if (playerMarker == "X")
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Blue;
    }
    
    public void Player1Name(Player Player1)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        "Ange namn på Spelare ett\n-> ".CW(0, 14, "Gray");
        Console.ForegroundColor = ConsoleColor.Green;
        Player1.Name = Console.ReadLine();
    }
    public void Player2Name(Player Player2)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        "Ange namn på Spelare två\n-> ".CW(0, 16, "Gray");
        Console.ForegroundColor = ConsoleColor.Blue;
        Player2.Name = Console.ReadLine();
    }
}

