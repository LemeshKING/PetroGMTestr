using System.Collections.Generic;
using Figures;

namespace FiguresCreater
{
   public class CircleCreator : iCreator
   {
      public iFigure FactoryMethod(List<double> parameters)
      {
         return new Circle(parameters[0], parameters[1], parameters[2]);
      }
   }
}
