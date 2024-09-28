using System;

namespace Figures
{
   public class Circle : iFigure
   {
      private double _x, _y, _r;
      public void Draw()
      {
         Console.Write("circle at (" + _x + ", " + _y + ") radius = " + _r);
      }
      public double Perimeter()
      {
         double perimeter = 2 * Math.PI * _r;
         Console.Write("perimeter = " + perimeter);
         return perimeter;
      }
      public double Square()
      {
         double square = Math.PI * _r * _r;
         Console.Write("square = " + square);
         return square;
      }
      public Circle(double x, double y, double r) 
      {
         _x = x;  
         _y = y;
         _r = r;
      }

   }
}
