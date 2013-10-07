using System;
using System.Collections.Generic;
using System.Threading;

public class ComputerMartin : Player
{
    // Properties
    public static List<List<string>> PossibleWins = new List<List<string>>();
    public static List<List<string>> AllRowsAndColumnForSquareArray = new List<List<string>>();
    public static List<List<string>> PlaceTwoCornersWithEmptyEdge = new List<List<string>>();
    public static bool third90 = false;

    // Constructor
    public ComputerMartin()
    {

    }

    // Methods that creates lists
    private static void CreateListFromBoardSquareArray()
    {
        // Clear the old CreateListFromBoardSquareArray()
        AllRowsAndColumnForSquareArray.Clear();
        // Add to the list
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[0], Program.MyBoard.SquareArray[1], Program.MyBoard.SquareArray[2] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[3], Program.MyBoard.SquareArray[4], Program.MyBoard.SquareArray[5] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[6], Program.MyBoard.SquareArray[7], Program.MyBoard.SquareArray[8] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[0], Program.MyBoard.SquareArray[3], Program.MyBoard.SquareArray[6] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[1], Program.MyBoard.SquareArray[4], Program.MyBoard.SquareArray[7] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[2], Program.MyBoard.SquareArray[5], Program.MyBoard.SquareArray[8] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[0], Program.MyBoard.SquareArray[4], Program.MyBoard.SquareArray[8] });
        AllRowsAndColumnForSquareArray.Add(new List<string> { Program.MyBoard.SquareArray[2], Program.MyBoard.SquareArray[4], Program.MyBoard.SquareArray[6] });
    }
    private static void ListWithPossibleWins(string marker)
    {
        // Clear the old PossibleWins-List
        PossibleWins.Clear();

        //Add to the list
        // 1-2-3
        PossibleWins.Add(new List<string> { "1", marker, marker });
        PossibleWins.Add(new List<string> { marker, "2", marker });
        PossibleWins.Add(new List<string> { marker, marker, "3" });
        // 4-5-6
        PossibleWins.Add(new List<string> { "4", marker, marker });
        PossibleWins.Add(new List<string> { marker, "5", marker });
        PossibleWins.Add(new List<string> { marker, marker, "6" });
        // 7-8-9
        PossibleWins.Add(new List<string> { "7", marker, marker });
        PossibleWins.Add(new List<string> { marker, "8", marker });
        PossibleWins.Add(new List<string> { marker, marker, "9" });
        // 1-4-7
        // allready an opion PossibleWins.Add(new List<string> { "1", marker, marker });
        PossibleWins.Add(new List<string> { marker, "4", marker });
        PossibleWins.Add(new List<string> { marker, marker, "7" });
        // 2-5-8
        PossibleWins.Add(new List<string> { "2", marker, marker });
        // allready an opion PossibleWins.Add(new List<string> { marker, "5", marker });
        PossibleWins.Add(new List<string> { marker, marker, "8" });
        // 3-6-9
        // allready an opion PossibleWins.Add(new List<string> { "2", marker, marker });
        PossibleWins.Add(new List<string> { marker, "6", marker });
        PossibleWins.Add(new List<string> { marker, marker, "9" });
        // 1-5-9
        // allready an opion PossibleWins.Add(new List<string> { "1", marker, marker });
        // allready an opion PossibleWins.Add(new List<string> { marker, "5", marker });
        // allready an opion PossibleWins.Add(new List<string> { marker, marker, "9" });
        // 3-5-7
        PossibleWins.Add(new List<string> { "3", marker, marker });
        // allready an opion PossibleWins.Add(new List<string> { marker, "5", marker });
        PossibleWins.Add(new List<string> { marker, marker, "7" });

        checkWin(marker);
    }
    private static void ListPlaceTwoCornersWithEmptyEdge(string marker)
    {
        //Clear the old PlaceTwoCornerWithEmptyEdge()
        PlaceTwoCornersWithEmptyEdge.Clear();
        // 1-2-3
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { marker, "2", "3" });
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { "1", "2", marker });
        // 1-4-7
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { marker, "4", "7" });
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { "1", "4", marker });
        // 3-6-9
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { marker, "6", "9" });
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { "3", "6", marker });
        // 7-8-9
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { marker, "8", "9" });
        PlaceTwoCornersWithEmptyEdge.Add(new List<string> { "7", "8", marker });

        checkTwoCornersWithEmptySquare(marker);
    }

    // To compare PossibleWins-List with AllRowsAndColumnForSquarArray-List if there is a winning draw
    private static void checkWin(string marker)
    {
        foreach (List<string> PossibleWin in PossibleWins)
        {
            foreach (List<string> RowOrColumn in AllRowsAndColumnForSquareArray)
            {
                if ((PossibleWin[0] == RowOrColumn[0]) && (PossibleWin[1] == RowOrColumn[1]) && (PossibleWin[2] == RowOrColumn[2]))
                {
                    ifMatchForWinningPossibility(PossibleWin, marker);
                }
            }
        }
    }
    private static void ifMatchForWinningPossibility(List<string> posWin, string marker)
    {
        if (posWin[0] != marker)
        {
            SquareOfChoice = posWin[0];
        }
        else if (posWin[1] != marker)
        {
            SquareOfChoice = posWin[1];
        }
        else
        {
            SquareOfChoice = posWin[2];
        }
    }

    // To check if ComputerMartin can put marker in corner so that he gets to corners with an empty square in the middle
    private static void checkTwoCornersWithEmptySquare(string marker)
    {
        foreach (List<string> TwoInCorner in PlaceTwoCornersWithEmptyEdge)
        {
            foreach (List<string> RowOrColumn in AllRowsAndColumnForSquareArray)
            {
                if ((TwoInCorner[0] == RowOrColumn[0]) && (TwoInCorner[1] == RowOrColumn[1]) && (TwoInCorner[2] == RowOrColumn[2]))
                {
                    ifMatchForTwoCornersPossibility(TwoInCorner, marker);
                }
            }
        }
    }
    private static void ifMatchForTwoCornersPossibility(List<string> twoInCorner, string marker)
    {
        if (twoInCorner[0] == marker)
            SquareOfChoice = twoInCorner[2];
        else
            SquareOfChoice = twoInCorner[0];
    }

    // methods that handles the 2 first placed markers on the board
    private static void putInCenterSquare()
    {
        if (amountOfMarkersinArray(Program.MyBoard.SquareArray) <= 1 && (Program.MyBoard.SquareArray[4] == "5"))
        {
            SquareOfChoice = "5";
        }
    }
    private static void opponentStartWithCenter(string opponentMarker)
    {
        if ((amountOfMarkersinArray(Program.MyBoard.SquareArray) == 1) && (Program.MyBoard.SquareArray[4] == opponentMarker))
            SquareOfChoice = "1";
    }

    // Two methods that belongs together, is explained in ComInputSquareChoice()
    private static void secondMarkerIn90Degrees(string marker_XorO, string opponentMarker)
    {
        if (amountOfMarkersinArray(Program.MyBoard.SquareArray) == 2 && (Program.MyBoard.SquareArray[4] == marker_XorO))
        {
            // to put marker 90 degrees away from opponent
            if ((Program.MyBoard.SquareArray[1] == opponentMarker) || (Program.MyBoard.SquareArray[7] == opponentMarker))
                SquareOfChoice = "6";
            if ((Program.MyBoard.SquareArray[3] == opponentMarker) || (Program.MyBoard.SquareArray[5] == opponentMarker))
                SquareOfChoice = "2";
            // to activate the third draw
            if (SquareOfChoice == "2" || SquareOfChoice == "6")
                third90 = true;
        }
    }
    private static void thirdMarkerIn90Degrees(string marker_XorO)
    {
        // to place a marker that will give ComputerMartin 2 in a row with two empty squares availible
        if ((Program.MyBoard.SquareArray[1] == marker_XorO) || (Program.MyBoard.SquareArray[5] == marker_XorO))
            SquareOfChoice = "3";
        if ((Program.MyBoard.SquareArray[3] == marker_XorO) || (Program.MyBoard.SquareArray[7] == marker_XorO))
            SquareOfChoice = "7";
        third90 = false;
    }

    // To choose the corner on the opposite side of the opponents first marker
    private static void diagonalLine(string marker_XorO, string opponentMarker)
    {
        if (amountOfMarkersinArray(Program.MyBoard.SquareArray) == 2 && (Program.MyBoard.SquareArray[4] == marker_XorO))
        {
            if (Program.MyBoard.SquareArray[0] == opponentMarker)
                SquareOfChoice = "9";
            else if (Program.MyBoard.SquareArray[2] == opponentMarker)
                SquareOfChoice = "7";
            else if (Program.MyBoard.SquareArray[6] == opponentMarker)
                SquareOfChoice = "3";
            else
                SquareOfChoice = "1";
        }
    }

    // To count markers on the board
    private static int amountOfMarkersinArray(string[] Array)
    {
        int marker = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == "X" || Array[i] == "O")
            {
                marker++;
            }

        }
        return marker;
    }
    private static int amountOfOpponentMarkerInCorner(string[] array, string opponentMarker)
    {
        int marker = 0;
        if (array[0] == opponentMarker)
            marker++;
        if (array[2] == opponentMarker)
            marker++;
        if (array[6] == opponentMarker)
            marker++;
        if (array[8] == opponentMarker)
            marker++;

        return marker;
    }

    // avoidTrickySituation is explained in ComInputSquareChoice()
    private static void avoidTrickySituation(string opponentMarker)
    {
        if ((amountOfMarkersinArray(Program.MyBoard.SquareArray) == 3) && (amountOfOpponentMarkerInCorner(Program.MyBoard.SquareArray, opponentMarker) == 2))
        {
            SquareOfChoice = "2"; // It does not mather if ComputerMartins choose 2 or 4 or 6 or 8, all edges are equal in this situation
        }
    }

    // The only method called upon from Progam.cs
    public static void ComInputSquareChoice(string marker_XorO)
    {
        SquareOfChoice = "0";

        string opponentMarker_XorO;
        if (marker_XorO == "X")
            opponentMarker_XorO = "O";
        else
            opponentMarker_XorO = "X";

        CreateListFromBoardSquareArray();

        //Check if ComputerMartin can win
        ListWithPossibleWins(marker_XorO);

        //Check to prevent User from winning
        if (SquareOfChoice == "0")
            ListWithPossibleWins(opponentMarker_XorO);

        //Check if center-square is empty.
        if (SquareOfChoice == "0")
            putInCenterSquare();

        //If opponent starts and chose the center square, its best to put next marker i a corner
        if (SquareOfChoice == "0")
            opponentStartWithCenter(opponentMarker_XorO);

        //If ComputerMartin starts with center and opponent put marker in an edge (not corner),
        // computerMartin can put marker 90 degrees from opponents marker and put his third marker,
        // next to the second, giving him 2 in a row with 2 open slots, giving him a garantueed win!
        if (SquareOfChoice == "0")
            secondMarkerIn90Degrees(marker_XorO, opponentMarker_XorO);
        if (SquareOfChoice == "0" && third90 == true)
            thirdMarkerIn90Degrees(marker_XorO);

        // If ComputerMartin starts (with center) and opponent puts its marker in the corner, the best move is 
        // to form a diagonal line (according to many sites at the Internet)
        if (SquareOfChoice == "0")
            diagonalLine(marker_XorO, opponentMarker_XorO);

        // If opponent starts with corner and ComputerMartin puts in centerSquare and opponent puts its second marker to form
        // a diagonal line, ComputerMartin can NOT put his second marker in one of the remaining corners. 
        if (SquareOfChoice == "0")
            avoidTrickySituation(opponentMarker_XorO);

        // Its better to put marker in two corners with an empty edge between instead of one corner and one edge.
        if (SquareOfChoice == "0")
            ListPlaceTwoCornersWithEmptyEdge(marker_XorO);

        // If none of the above situations are true, just pick a random number
        if (SquareOfChoice == "0")
        {
            Random rand = new Random();
            SquareOfChoice = Convert.ToString(rand.Next(1, 10));
        }
    }

}

