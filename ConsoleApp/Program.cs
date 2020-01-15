using AlCommon.Util;
using ConsoleApp.Model;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var http = new HttpClient())
            {
                const string url = "http://docs.microsoft.com/";
                var body = await http.GetStringAsync(url);
                Console.WriteLine($"Size: {body.Length}");
            }


            //Common.SendMail();
            //Nlog(); 
        } 

        private static void Nlog()
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

            Logger logger = NLog.LogManager.GetCurrentClassLogger();
            try
            {
                Employee emp = new Employee();
                emp.Email = "XXX.com.tw";
                emp.EngName = "XXY";
                // log here
                logger.Trace("Trace");
                logger.Debug("Debug");
                logger.Info("Info");
                logger.Warn("Warn");
                logger.Error("Error");
                logger.Fatal("Fatal");


                logger.Trace(emp);

                int foo = 0;
                foo /= foo;
            }
            catch (Exception ex)
            {
                // log with exception here
                logger.Debug(ex, "Error");
            }
        }
    }
}
