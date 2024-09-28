using System;

namespace Figures
{
   public class Rhomb : iFigure
   {
      private double _x, _y, _h, _w;
      public void Draw()
      {
         Console.Write("rhomb at (" + _x + ", " + _y + ") " + "height = " + _h + " width = " + _w);
      }
      public double Perimeter1()
      {
         double perimeter = 4 * _w;
         Console.Write("perimeter = " + perimeter);
         return perimeter;
      }
      public double Square1()
      {
         double square = _w * _h;
         Console.Write("square = " + square);
         return square;
      }
      public double Perimeter()
      {
         double perimeter = 4 * Math.Sqrt(_h * _h / 4 + _w * _w / 4);
         Console.Write("perimeter = " + perimeter);
         return perimeter;
      }
      public double Square()
      {
         double square = _h * _w / 2;
         Console.Write("square = " + square);
         return square;
      }
      public Rhomb(double x, double y, double h, double w) 
      {
         _x = x; 
         _y = y; 
         _h = h; 
         _w = w;
      }
   }
}
