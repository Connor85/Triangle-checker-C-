using System;
using System.Collections.Generic;


class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter length A");
    string stringSideA = Console.ReadLine();
    int sideALength = int.Parse(stringSideA);
    myTriangle.SideA = sideALength;

    Console.WriteLine("Enter length B");
    string stringSideB = Console.ReadLine();
    int sideBLength = int.Parse(stringSideB);
    myTriangle.SideB = sideBLength;

    Console.WriteLine("Enter length C");
    string stringSideC = Console.ReadLine();
    int sideCLength = int.Parse(stringSideC);
    myTriangle.SideC = sideCLength;


    if (sideALength >= sideBLength + sideCLength || sideBLength >= sideALength + sideCLength || sideCLength >= sideALength + sideBLength)
    {
      Console.WriteLine("This is not a triangle");
    }
    else if (sideALength == sideBLength && sideBLength == sideCLength)
    {
      Console.WriteLine("This is an equilateral triangle");
    }

    else if (sideALength == sideBLength || sideALength == sideCLength || sideBLength == sideCLength)
    {
      Console.WriteLine("This is an isosceles triangle");
    }
    else if (sideALength != sideBLength && sideALength!= sideCLength|| sideBLength != sideCLength && sideBLength != sideALength)
    {
      Console.WriteLine("This is a scalene triangle");
    }


  }
}
