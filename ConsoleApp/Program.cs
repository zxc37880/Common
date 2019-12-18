using AlCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double floorInput = 3.14159265358979323846;
            int digit = 2;

            double floorOutput = Common.Floor(floorInput, digit);
            Console.WriteLine($"floorInput:{floorInput}, digit:{digit}");
            Console.WriteLine($"floorOutput:{floorOutput}");

            double value = floorInput;
            double baseValue = 0.01;
            double precisionValue = Common.ConvertTwoNumberPrecisionSame(value, baseValue);
            Console.WriteLine($"value:{value}, baseValue:{baseValue}");
            Console.WriteLine($"precisionValue:{precisionValue}");
        }
    }
}
