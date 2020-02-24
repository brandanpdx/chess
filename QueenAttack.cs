using System;
using System.Collections.Generic;

 public class Queen
{
  public int locX;
  public int locY;
  public int pawnLocX;
  public int pawnLocY;
}
public class QueenAttack
{
  public static void Main()
  {
    Queen newQueen = new Queen();
    Console.WriteLine("Enter X Coordinate for Queen's location:");
    string queenXCoordinates = Console.ReadLine();
    int userQueenX = int.Parse(queenXCoordinates);
    if ((userQueenX >= 1) && (userQueenX <=8))
    {
      newQueen.locX = userQueenX;
    }
    else
    { 
      Console.WriteLine("Please enter a number between 1 and 8.");
    }
    Console.WriteLine("Enter Y Coordinate for Queen's location:");
    string queenYCoordinates = Console.ReadLine();
    int userQueenY = int.Parse(queenYCoordinates);
    if ((userQueenY >= 1) && (userQueenY <=8))
    {
      newQueen.locY = userQueenY;
    }
    else
    { 
      Console.WriteLine("Please enter a number between 1 and 8.");
    }
    Console.WriteLine("Enter X Coordinate for Pawn's location:");
    string pawnXCoordinates = Console.ReadLine();
    int userPawnX = int.Parse(pawnXCoordinates);
    if ((userPawnX >= 1) && (userPawnX <=8))
    {
      newQueen.pawnLocX = userPawnX;
    }
    else
    { 
      Console.WriteLine("Please enter a number between 1 and 8.");
    }
    Console.WriteLine("Enter Y Coordinate for Pawn's location:");
    string pawnYCoordinates = Console.ReadLine();
    int userPawnY = int.Parse(pawnYCoordinates);
    if ((userPawnY >= 1) && (userPawnY <=8))
    {
      newQueen.pawnLocY = userPawnY;
    }
    else
    { 
      Console.WriteLine("Please enter a number between 1 and 8.");
    }
    Console.WriteLine(newQueen.locX + ", " + newQueen.locY);
    Console.WriteLine(newQueen.pawnLocX + ", " + newQueen.pawnLocY);
    if ((newQueen.locX == newQueen.pawnLocX) || (newQueen.locY == newQueen.pawnLocY))
    {
      Console.WriteLine("Queen takes pawn.");
    }
    if (Math.Abs(newQueen.locX - newQueen.pawnLocX) == Math.Abs(newQueen.locX - newQueen.pawnLocX))
    {
      Console.WriteLine("Diagonal");
    }
  }
}