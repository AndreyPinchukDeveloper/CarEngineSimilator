using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Engine
{
    public class InputData
    {
        public string strTemperature = "";
        public float temperatureEngine;
        public float temperatureOutside;

        public void GetInformation()
        {
            WorkingEngine workingEngine = new WorkingEngine();

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
                GetInformation();
            }

            if (temperatureOutside <= -45)
            {
                Console.WriteLine("Your engine have been freezed !");
                Console.ReadLine();
            }

            workingEngine.StartEngine(temperatureEngine, temperatureOutside);

            if (workingEngine.time < 100)
            {
                Console.WriteLine("Your engine have been worked without overload " + workingEngine.time + " seconds");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your engine will not get an overload ! ");
                Console.ReadLine();
            }
        }
    }
}
