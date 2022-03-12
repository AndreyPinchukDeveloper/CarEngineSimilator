using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FormulaConstants:IAcceleration
    {
        public byte inertia = 10;
        public byte limitTemperature = 110;
        public decimal dependsOfTorque = 0.01m;
        public decimal dependsOfSpeed = 0.0001m;
        public float coefficient = 0.1f;

        public short[] speed = { 0, 75, 150, 200, 250, 300 };
        public short[] piecewiseLinerDependency = { 20, 75, 100, 105, 75, 0 };
        private float[] acceleration = new float[6];

        public float calculateOverload;
        public float calculateCold;
        public int countOfArray = 0;

        public float CalculateOverload()
        {
            return calculateOverload = (float)(piecewiseLinerDependency[countOfArray] * dependsOfTorque
                                  + (speed[countOfArray] * speed[countOfArray]) * dependsOfSpeed); ;
        }

        public float CalculateCold()
        {
            
            calculateCold = coefficient * (InputData.temperatureOutside - InputData.temperatureEngine);
            return calculateCold;
        }

        public float CalculateColdWithoutMinus()
        {
            calculateCold = coefficient * (InputData.temperatureEngine - InputData.temperatureOutside);
            return calculateCold;
        }

        public float[] CalculateAcceleration()
        {
            for (int i = 0; i <= piecewiseLinerDependency.Length - 1; i++)
            {
                acceleration[i] = piecewiseLinerDependency[i] /inertia;
            }
            return acceleration;
        }
    }
}
