using System;
using System.Globalization;

namespace Engine
{
    static class Program
    {
        public static string strTemperature = "";
        public static float temperatureEngine;
        public static float temperatureOutside;

        static void Main(string[] args)
        {
            strTemperature = Console.ReadLine();

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
            };

            try
            {
                float _temperatureOutside = float.Parse(strTemperature, numberFormatInfo);
                temperatureEngine = _temperatureOutside;
                temperatureOutside = temperatureEngine;
            }
            catch (Exception)
            {
                Console.WriteLine("Please, use only numbers, and numbers with that '.' separator");
                Main(args);
            }

            WorkingEngine.StartEngine();

            Console.WriteLine("Your engine have been worked without overload "+WorkingEngine.time + " seconds");
            Console.ReadLine();
        }
    }
}
