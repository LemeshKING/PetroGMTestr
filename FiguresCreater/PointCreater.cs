using System.Collections.Generic;
using Figures;

namespace FiguresCreater
{
   public class PointCreater : iCreator
   {
      public iFigure FactoryMethod(List<double> parameters)
      {
         return new Point(parameters[0], parameters[1]);
      }
   }
}
