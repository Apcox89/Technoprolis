using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //ref: https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/

    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();

         public static int RandomNumber(int minimumValue, int maximumValue)
         {
         return _generator.Next(minimumValue, maximumValue + 1);
         }
    }
}
