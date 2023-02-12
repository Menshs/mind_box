using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreasPr;

namespace AreaTestPr
{
    [TestClass]
    public class AreasTest
    {
        [TestMethod]
        // Тестируем площадь круга.
        public void TestCircleArea()
        {
            double[] r = new double[5] { 5d, 6d, 3d, 4d, 4.5d };
            double[] result = new double[5] { 78.5d, 113.04d, 28.26d, 50.24d, 63.585d };

            for (int i = 0; i < r.Length; i++)
            {
                double act = Areas.CircleArea(r[i]);
                Assert.AreEqual(result[i], act, 0.01d);
            }
        }

        // Тестируем площадь треугольника.
        public void TestTriangleArea()
        {
            double[] a = new double[2] { 3d, 3d };
            double[] b = new double[2] { 4d, 4.5d };
            double[] c = new double[2] { 5d, 6d };
            double[] result = new double[2] { 6d, 6.54d };

            for (int i = 0; i < a.Length; i++)
            {
                double act = Areas.TriangleArea(a[i], b[i], c[i]);
                Assert.AreEqual(result[i], act, 0.01d);
            }
        }

        // Тестируем на наличие прямого угла в треугольнике.
        public void TestRightTriangle()
        {
            double[] a = new double[2] { 3d, 3d };
            double[] b = new double[2] { 4d, 4.5d };
            double[] c = new double[2] { 5d, 6d };
            bool[] result = new bool[2] { true, false };

            for (int i = 0; i < a.Length; i++)
            {
                bool act = Areas.RightTriangle(a[i], b[i], c[i]);
                Assert.AreEqual(result[i], act);
            }
        }
    }
}
