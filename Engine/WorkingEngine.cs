using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class WorkingEngine: IAcceleration, IOverload
    {
        public const byte inertia = 10;
        public const byte limitTemperature = 110;
        public const decimal dependsOfTorque = 0.01m;
        public const decimal dependsOfSpeed = 0.0001m;
        public const float coefficient = 0.1f;

        public static byte time = 0;
        private static byte overload;
        private static float cold;

        static short[] speed = { 0, 75, 150, 200, 250, 300 };
        static short[] piecewiseLinerDependency = { 20,75,100,105,75,0};
        static float[] acceleration = new float[6];
        

        public static int StartEngine()
        {
            CalculateAcceleration();

            while (Program.temperatureEngine < 110)
            {
                Overload();
                time++;
            }

            return time;
        }

        private static string Overload()
        {
            overload = piecewiseLinerDependency[1] * dependsOfTorque + (speed[1] * speed[1]) * dependsOfSpeed;
            Program.temperatureEngine += overload;

            if (Program.temperatureOutside > Program.temperatureEngine)
            {
                cold = coefficient * (Program.temperatureOutside - Program.temperatureEngine);
                Program.temperatureEngine -= cold;
            }
            else
            {
                cold = -coefficient * (Program.temperatureOutside - Program.temperatureEngine);
                Program.temperatureEngine -= cold;
            }
            
            return Program.temperatureEngine.ToString();
        }

        private void Cold()
        {
            cold = coefficient * (Program.temperatureOutside - Program.temperatureEngine);
        }

        private static float[] CalculateAcceleration()
        {
            for (int i = 0; i <= piecewiseLinerDependency.Length-1; i++)
            {
                acceleration[i] = piecewiseLinerDependency[i] / inertia;
            }
            return acceleration;
        }
    }
}
