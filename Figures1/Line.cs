using System;

namespace Figures
{
   public class Line : iFigure
   {
      private double _x1, _y1, _x2, _y2;
      public void Draw()
      {
         Console.Write("line at (" + _x1 + ", " + _y1 + ") (" + _x2 + ", " + _y2 + ")");

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
      public Line(double x1, double y1, double x2, double y2) 
      {
         _x1 = x1;
         _y1 = y1;
         _x2 = x2;
         _y2 = y2;
      }
   }
}
