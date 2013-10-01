using System;
using System.Collections.Generic;

public class Player
{
    public string Name;
    public int NumberOfWins;
    public int NoWin;
    public string Marker;
    public static string SquareOfChoice = "";

    public Player(string name, string marker)
    {
        Name = name;
        Marker = marker;
        NumberOfWins = 0;
        NoWin = 0;
    }
    public static void setColorForCorrectingInput(string playerMarker)
    {
        if (playerMarker == "X")
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Blue;
    }
    public static void InputSquareChoice(string playerMarker)
    { 
        int localNumber;
        
        // Om inmatningen går att göra om till en int, och den är lika med eller mindre än 9, och det inte är en nolla händer detta:
        while (true)
        {
            SquareOfChoice = Console.ReadLine(); // Detta är en string eftersom vi även skickar vidare "SquareOfChoice" in i andra metoder. 
            if (int.TryParse(SquareOfChoice, out localNumber) && localNumber <= 9 && localNumber > 0)
            {
                if (Program.MyBoard.SquareArray[Convert.ToInt32(SquareOfChoice) - 1] != "X" && Program.MyBoard.SquareArray[Convert.ToInt32(SquareOfChoice) - 1] != "O") // Här ska du kolla att inamtningens plats INTE är upptagen, MN:Nu gör jag det
                {
                    Program.MyBoard.ChangeMarkerOnBoardSquare(SquareOfChoice, playerMarker);
                    break; // Här är enda stället som vi går ur InputSquareChoice
                }
                else // Om den ÄR upptagen händer detta:
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    "Du kan inte sätta din markör på en upptagen ruta. Försök igen!".EchoWriteLine();
                    setColorForCorrectingInput(playerMarker);
                    //Console.ForegroundColor = ConsoleColor.DarkGray; TODOMN:Ta bort denna raden vid rensning av kod
                }
            }
            else // Om inmatningen är högre än nummer 9, eller om den är 0 (eller mindre, dvs negativt tal) eller om det är en/flera bokstav händer detta:
            {
                Console.ForegroundColor = ConsoleColor.White;
                "Fel Inmatning. Försök igen!".EchoWriteLine();
                setColorForCorrectingInput(playerMarker);
                //Console.ForegroundColor = ConsoleColor.DarkGray; TODOMN: Ta bort denna raden vid rensning av kod
            }
        } // Slut på while(true)
    } // Slut på playerInputSquareChoice
} 

