using System.Collections.Generic;
using Figures;

namespace FiguresCreater
{
   public class LineCreater : iCreator
   {
      public iFigure FactoryMethod(List<double> parameters)
      {
         return new Line (parameters[0], parameters[1], parameters[2], parameters[3]);
      }
   }
}
