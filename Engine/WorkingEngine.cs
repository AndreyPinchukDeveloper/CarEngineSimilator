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

        InputData inputData = new InputData();

        public byte time = 0;
        private float cold = 0;
        private float overload = 0;

        public void StartEngine()
        {
            formulaConstant.CalculateAcceleration();

            while (InputData.temperatureEngine < 110)
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
        }

        public void Overload()
        {
            while (formulaConstant.countOfArray >= 0)
            {
                overload = formulaConstant.CalculateOverload();
                break;
            }
            
            InputData.temperatureEngine += overload;

            if (InputData.temperatureOutside > InputData.temperatureEngine)
            {
                cold = formulaConstant.CalculateCold();
                InputData.temperatureEngine -= cold;
            }
            else
            {
                cold = formulaConstant.CalculateColdWithoutMinus();
                InputData.temperatureEngine -= cold;
            }
        }
    }
}
