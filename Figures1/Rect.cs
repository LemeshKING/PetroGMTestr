using System;

namespace Figures
{
   public class Rect : iFigure
   {
      private double _x1, _y1, _x2, _y2;
      public void Draw()
      {
         Console.Write("rect at (" + _x1 + ", " + _y1 + ") (" + _x2 + ", " + _y2 + ")");
      }
      public double Perimeter()
      {
         double perimeter = 2 * (Math.Sqrt((_x2 - _x1) * (_x2 - _x1)) + Math.Sqrt((_y2 - _y1) * (_y2 - _y1)));
         Console.Write("perimeter = " + perimeter);
         return perimeter;
      }
      public double Square()
      {
         double square = Math.Sqrt((_x2 - _x1) * (_x2 - _x1)) * Math.Sqrt((_y2 - _y1) * (_y2 - _y1));
         Console.Write("square = " + square);
         return square;
      }
      public Rect(double x1, double y1, double x2, double y2)
      {
         _x1 = x1;
         _y1 = y1;
         _x2 = x2;
         _y2 = y2;
      }
   }
}
