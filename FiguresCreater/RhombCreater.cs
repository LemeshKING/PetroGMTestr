using System.Collections.Generic;
using Figures;

namespace FiguresCreater
{
   public class RhombCreater : iCreator
   {
      public iFigure FactoryMethod(List<double> parameters)
      {
         return new Rhomb(parameters[0], parameters[1], parameters[2], parameters[3]);
      }
   }
}
