using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasPr
{
    public class Areas
    {
        private static double Sqr(double a)
        {
            return a * a;
        }

        // Площадь круга.
        public static double CircleArea(double r)
        {
            return 3.14f * r * r;
        }

        // Прямоугольный ли треугольник.
        public static bool RightTriangle(double a, double b, double c)
        {
            a = Math.Abs(a); b = Math.Abs(b); c = Math.Abs(c);

            bool result = false;
            double[] lines = new double[3] { a, b, c };

            // Ищем сторону треугольника с максимальной длиной.
            int maxI = 0;
            for (int i = 1; i < 3; i++)
                if (lines[i] > lines[maxI])
                    maxI = i;

            // Если сумма квадратов меньших сторон равна квадрату наибольшей стороны, то треугольник прямоугольный.
            if (Sqr(lines[maxI]) == Sqr(lines[(maxI + 1) % 3]) + Sqr(lines[(maxI + 2) % 3]))
            {
                result = true;
            }

            return result;
        }

        // Площадь треугольника.
        public static double TriangleArea(double a, double b, double c)
        {
            a = Math.Abs(a); b = Math.Abs(b); c = Math.Abs(c);

            // Используем формулу Герона.
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Невозможно вычислить площадь фигуры без знания типа фигуры.
    }
}
