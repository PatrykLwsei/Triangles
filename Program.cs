using System.Runtime.Serialization;
using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
  class Program
  {
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        double A = double.Parse(Console.ReadLine()); //AB//
        double B = double.Parse(Console.ReadLine()); //BC//
        double C = double.Parse(Console.ReadLine()); //CA//
        
        var S = Math.Round((A + B + C) / 2); //S needed for Heron's Formula//

        double perimeter = Math.Round(A + B + C);        
        double area = Math.Sqrt(S * (S - A) * (S - B) * (S - C)); //Heron's Formula//
        double pythagoras = Math.Pow(A, 2) + Math.Pow(B, 2); //Pythagorean theorem//

        if (A <= 0 || B <= 0 || C <= 0) {
          Console.WriteLine("Incorrect data. Sides must be possitive!"); //Can't be negative//
        }
        if (A + B < C) {
          Console.WriteLine("Incorrect data. The Triangle cannot be made!"); //If C is longer than B and A, the triangle couldn't exist//
        }
        if (perimeter > 0 ) {
          Console.WriteLine("perimeter = {0:N2}", perimeter); //If the Perimiter equals 0 or less It's not a Triangle//
        }
        if (area >= 0) {
          Console.WriteLine("area = {0:N2}", area); //If the Area equals 0 or less It's not a Triangle//
        }
        if (pythagoras > Math.Pow(C, 2)) {
          Console.WriteLine("The triangle is acute"); //If C^ equals More than B^+A^ the triangle has to be Acute//
        }
        if (pythagoras < Math.Pow(C, 2)) {
          Console.WriteLine("The triangle is obtuse"); //If C^ equals less than B^+A^ the triangle has to be Obtuse//
        }
        if (pythagoras == Math.Pow(C, 2)) { 
          Console.WriteLine("The triangle is rectangular"); //C^2 Has to match the Pythagoras int//
        }
        if (A == B && B == C) {
            Console.WriteLine("The triangle is equilateral."); //Equilateral triangle has all It's sides dead even//
        }
          else if ((A == B) || (B == C) || (A == C)) {
              Console.WriteLine("The triangle is isoceles."); //Isoceles triangle has two sides of equal length//
          }
        else {
            Console.WriteLine("The triangle is scalene."); //Scalene triangle has three equal sides + There is no other types that It could be.//
        }
    }
  }
}


// 