using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    interface IAcceleration
    {
        private float[] CalculateAcceleration(float[] dependency, int inertia, float[] acceleration)
        {
            return acceleration;
        }
    }
}
