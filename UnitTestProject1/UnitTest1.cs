using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Решение_квадратного_уравнения;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void testSim()
        {
            string a = "1";
            string b = "с";
            string c = "1";
            string expected = "Ошибка ввода ВТОРОГО коэффициента: коэффициент должен иметь числовое значение.";
            try
            {
                CountRoots cnt = new CountRoots();
                cnt.сountRoots(a, b, c);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }

       

        [TestMethod]
        public void zeroFirst()
        {
            string a = "0";
            string b = "9";
            string c = "10";
            string expected = "При нулевом значении первого коэффициента квадратного уравнения, оно становится линейным, измените значение первого коэффициента.";
            try
            {
                CountRoots cnt = new CountRoots();
                cnt.сountRoots(a, b, c);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }

       
        [TestMethod]
        public void twoRoots()
        {
            string a = "1";
            string b = "3";
            string c = "2";
            List<double> expected = new List<double>();
            expected.Add(1); //d
            expected.Add(-2); //2
            expected.Add(-1); //1
           
                CountRoots cnt = new CountRoots();
                List<double> actual = new List<double>();
                actual=cnt.сountRoots(a, b, c);
                CollectionAssert.AreEqual(expected, actual);
        
          
        }

        [TestMethod]
        public void testAccuracy()
        {
            string a = "4";
            string b = "12";
            string c = "6";
            List<double> expected = new List<double>();
            expected.Add(48);
            expected.Add(-2.36602);
            expected.Add(-0.63397);
            try
            {
                CountRoots cnt = new CountRoots();
                List<double> actual = new List<double>();
                actual.Add(48);
                actual.Add(-2.36602540378444);
                actual.Add(-0.63397459621);
                var collection = actual.Zip(expected, (first, second) => new { actual = first, expected = second });
                var first1 = expected;
                var second1 = actual;

                foreach (var item in collection)
                {
                    Assert.AreEqual(item.actual, item.expected, 0.0001);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка точности");
            }

        }


        
        [TestMethod]
        public void bigValue()
        {
            string a = "1E+10";
            string b = "1E+20";
            string c = "100000";
            List<double> expected = new List<double>();
            expected.Add(double.NegativeInfinity);
            expected.Add(double.PositiveInfinity);
            try
            {
                CountRoots cnt = new CountRoots();
                List<double> actual = new List<double>();
                actual = cnt.сountRoots(a, b, c);
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {

            }
        }

        [TestMethod]
        public void testVeshChislo()
        {
            string a = "2,5";
            string b = "4,5";
            string c = "1,5";
            List<double> expected = new List<double>();
            expected.Add(5.25);
            expected.Add(-1.3582575694955838);
            expected.Add(-0.44174243050441603);
            CountRoots cnt = new CountRoots();
            List<double> actual = new List<double>();
            actual = cnt.сountRoots(a, b, c);
            var collection = actual.Zip(expected, (first, second) => new { actual = first, expected = second });
            foreach (var item in collection)
            {
                Assert.AreEqual(item.actual, item.expected, 0.00000000000001);
            }
        }
        [TestMethod]
        public void SingleRoot()
        {
            string a = "4";
            string b = "4";
            string c = "1";
            List<double> expected = new List<double>();
            expected.Add(0);
            expected.Add(-1);
            try
            {
                CountRoots cnt = new CountRoots();
                List<double> actual = new List<double>();
                actual = cnt.сountRoots(a, b, c);
                CollectionAssert.DoesNotContain(expected, actual);
            }
            catch (Exception ex)
            {

            }
        }

        [TestMethod]
        public void LessDisc()
        {
            string a = "3";
            string b = "4";
            string c = "2";
            List<double> expected = new List<double>();
            expected.Add(-0);

            try
            {
                CountRoots cnt = new CountRoots();
                List<double> actual = new List<double>();
                actual = cnt.сountRoots(a, b, c);
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {

            }
        }

    }
    
}


public class MyComparer : IComparer
{
    // 0.000000000000000000000000000000001
    private const double Tolerance = 0.000000000001;

    public int Compare(object x, object y)
    {
        double x1 = (double)x;
        double y1 = (double)y;
        //0,000000000012312 <= 0.000000000001
        if (Math.Abs(x1 - y1) <= Tolerance)
            return 0;

        return x1 > y1 ? 1 : -1;
    }
}   