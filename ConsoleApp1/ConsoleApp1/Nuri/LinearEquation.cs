using ConsoleApp1.Simberdeev;
using System;
using System.Collections.Generic;

namespace Simberdeev
{
    class LinearEquation
    {
        public List<float> linearEquation(float a, float b)
        {
            if (a == 0)
            {
                throw new NuriException("Ошибка: уравнение не существует.");
            }

            return new List<float> { -b / a };
        }
    }
}