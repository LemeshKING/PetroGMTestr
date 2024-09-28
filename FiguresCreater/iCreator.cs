using System.Collections.Generic;
using Figures;

namespace FiguresCreater
{
   public interface iCreator
   {
      iFigure FactoryMethod(List<double> parameters);
   }
}
