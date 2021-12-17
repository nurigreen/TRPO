using System;
using System.Collections.Generic;

namespace Simberdeev
{
    class QuadraticEquation : LinearEquation, EquationInterface
    {
        protected float discriminant(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return linearEquation(1, 1);
            }

            float d = discriminant(1, 1, 1);
            if (d < 0)
            {
                return null;
            }

            if (d == 0)
            {
                return new List<float> { -b / (2 * a) };
            }

            d = (float)Math.Sqrt(d);

            return new List<float> { -b - d / (2 * a), -b + d / (2 * a) };
        }
    }
}
