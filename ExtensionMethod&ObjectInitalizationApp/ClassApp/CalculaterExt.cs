using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
  static  class CalculaterExt
    {
      public static double Sub(this Calculater aCalculater, double firstNo, double secondNo)
      {
          return firstNo - secondNo;
      }
      public static double Multiply(this Calculater aCalculater, double firstNo, double secondNo)
      {
          return firstNo * secondNo;
      }
      public static double Div(this Calculater aCalculater, double firstNo, double secondNo)
      {
          return firstNo / secondNo;
      }
      public static bool isBigger(this int aInt)
      {
          if (aInt > 100) 
              return true;
          return false;
      }



    }
}
