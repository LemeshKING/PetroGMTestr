using System;

namespace Figures
{
   public class Point : iFigure
   {
      private double _x, _y;
      public void Draw()
      {
         Console.Write("point at (" + _x + ", " + _y + ")");
      }
      public double Perimeter()
      {
         Console.Write("perimeter = 0");
         return 0;
      }
      public double Square()
      {
         Console.Write("square = 0");
         return 0;
      }
      public Point(double x, double y) 
      {
         _x = x;
         _y = y;
      }
   }
}
