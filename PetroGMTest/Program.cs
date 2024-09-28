using System;
using System.Collections.Generic;
using Figures;
using FiguresCreater;
using System.IO;

namespace PetroGMTest
{
   internal class Program
   {
      static void Main(string[] args)
      {

         List<iFigure> figures = new List<iFigure>();
         try
         {
            using (StreamReader reader = new StreamReader("../../figures.txt"))
            {
               while (!reader.EndOfStream)
               {
                  string line = reader.ReadLine();
                  string[] words = line.Split(' ');
                  if (words[0] == "point")
                  {
                     iCreator creator = new PointCreater();
                     figures.Add(creator.FactoryMethod(new List<double>() { double.Parse(words[1]), double.Parse(words[2]) }));
                  }
                  else if (words[0] == "rect")
                  {
                     iCreator creator = new RectCreater();
                     figures.Add(creator.FactoryMethod(new List<double>() { double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]), double.Parse(words[4]) }));
                  }
                  else if (words[0] == "line")
                  {
                     iCreator creator = new LineCreater();
                     figures.Add(creator.FactoryMethod(new List<double>() { double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]), double.Parse(words[4]) }));
                  }
                  else if (words[0] == "circle")
                  {
                     iCreator creator = new CircleCreator();
                     figures.Add(creator.FactoryMethod(new List<double>() { double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]) }));
                  }
                  else if (words[0] == "rhomb")
                  {
                     iCreator creator = new RhombCreater();
                     figures.Add(creator.FactoryMethod(new List<double>() { double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]), double.Parse(words[4]) }));
                  }
                  else if (words[0] == "square")
                  {
                     iCreator creator = new SquareCreator();
                     figures.Add(creator.FactoryMethod(new List<double>() { double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]) }));
                  }
               }
            }
            foreach (iFigure f in figures)
            {
               f.Draw();
               if (f is Rhomb)
               {
                  var tmp = (Rhomb)f;
                  Console.Write(" ");
                  tmp.Perimeter1();
                  Console.Write(" ");
                  tmp.Square1();
               }

               Console.Write(" ");
               f.Perimeter();
               Console.Write(" ");
               f.Square();
               Console.WriteLine();

            }
            Console.ReadLine();
         }
         catch
         {
            Console.WriteLine("file figure.txt not found");
            Console.ReadLine();
         }
      }
   }
}
