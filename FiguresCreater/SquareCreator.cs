using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace FiguresCreater
{
   public class SquareCreator : iCreator
   {
      public iFigure FactoryMethod(List<double> parameters)
      {
         return new cSquare(parameters[0], parameters[1], parameters[2]);
      }
   }
}
