using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class WorkingEngine: IOverload
    {
        FormulaConstants formulaConstant = new FormulaConstants();
        
        public byte time = 0;
        private float cold = 0;
        private float overload = 0;
        public static float temperatureWorkingEngine;
        public static float temperatureOutside;

        public int StartEngine(float temperature, float tempOut)
        {
            formulaConstant.CalculateAcceleration();
            temperatureWorkingEngine = temperature;
            temperatureOutside = tempOut;
            
            while (temperatureWorkingEngine < 110)
            {
                Overload();
                time++;
                if (formulaConstant.countOfArray<=4)
                {
                    formulaConstant.countOfArray++;
                }
                if (time>100)
                {
                    break;
                }
            }
            return time;
        }

        public void Overload()
        {
            while (formulaConstant.countOfArray >= 0)
            {
                overload = formulaConstant.CalculateOverload();
                break;
            }
            
            temperatureWorkingEngine += overload;

            if (temperatureOutside > temperatureWorkingEngine)
            {
                cold = formulaConstant.CalculateCold();
                temperatureWorkingEngine -= cold;
            }
            else
            {
                cold = formulaConstant.CalculateColdWithoutMinus();
                temperatureWorkingEngine -= cold;
            }
        }
    }
}
