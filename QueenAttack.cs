using System;
using System.Collections.Generic;

 public class Piece
{
  public int LocX;
  public int LocY;
}
public class QueenAttack
{
  public static void Main()
  {
    Piece queen = new Piece();
    Piece pawn = new Piece();
    Console.WriteLine("Enter X Coordinate for Queen's location:");
    string queenXCoordinates = Console.ReadLine();
    int userQueenX = int.Parse(queenXCoordinates);
    if ((userQueenX >= 1) && (userQueenX <=8))
    {
      queen.LocX = userQueenX;
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
      queen.LocY = userQueenY;
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
      pawn.LocX = userPawnX;
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
      pawn.LocY = userPawnY;
    }
    else
    { 
      Console.WriteLine("Please enter a number between 1 and 8.");
    }
    Console.WriteLine(queen.LocX + ", " + queen.LocY);
    Console.WriteLine(pawn.LocX + ", " + pawn.LocY);
    if ((queen.LocX == pawn.LocX) || (queen.LocY == pawn.LocY) || (Math.Abs(queen.LocX - pawn.LocX) == Math.Abs(queen.LocY - pawn.LocY)))
    {
      Console.WriteLine("Queen takes pawn.");
    }
    else
    {
     Console.WriteLine("Pawn is safe.");
    }
  }
}