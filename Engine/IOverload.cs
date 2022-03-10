using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    interface IOverload
    {
        private float OverloadSpeed(int overloadSpeed, float iecewiseLinerDependency, decimal dependsOfTorque, decimal dependsOfSpeed, float speed)
        {
            return overloadSpeed;
        }
    }
}
