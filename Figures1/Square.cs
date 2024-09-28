using System;

namespace Figures
{
   public class cSquare : iFigure
   {
      private double _x, _y, _l;
      public void Draw()
      {
         Console.Write("square at (" + _x + ", " + _y + ") length = " + _l);
      }
      public double Perimeter()
      {
         double perimeter = 4 * _l;
         Console.Write("perimeter = " + perimeter);
         return perimeter;
      }
      public double Square()
      {
         double square = _l * _l;
         Console.Write("square = " + square);
         return square;
      }
      public cSquare(double x, double y, double l) 
      {
         _x = x;
         _y = y; 
         _l = l;
      }
   }
}
