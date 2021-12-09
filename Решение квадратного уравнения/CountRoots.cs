using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Решение_квадратного_уравнения
{
    public class CountRoots
    {
        private Boolean checkEmpty(string text)
        {
            if (text == "")
            {
                return true;
            }
            return false;
        }

        private Boolean checkSymbol(string text)
        {
            double num = 0.0;
            if (double.TryParse(text, out num))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean checkZero(string text)
        {
            double num = 0.0;
            double.TryParse(text, out num);
            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void checkValues(string a,string b,string c)
        {
            if (checkEmpty(a))
            {
                throw new Exception("Ошибка ввода ПЕРВОГО коэффициента: введите значение в поле ввода первого коэффициента.");
            }
            if (checkEmpty(b))
            {
                throw new Exception("Ошибка ввода ВТОРОГО коэффициента: введите значение в поле ввода первого коэффициента.");
            }
            if (checkEmpty(c))
            {
                throw new Exception("Ошибка ввода ТРЕТЬЕГО коэффициента: введите значение в поле ввода первого коэффициента.");
            }
            if (checkSymbol(a))
            {
                throw new Exception("Ошибка ввода ПЕРВОГО коэффициента: коэффициент должен иметь числовое значение.");
            }
            if (checkSymbol(b))
            {
                throw new Exception("Ошибка ввода ВТОРОГО коэффициента: коэффициент должен иметь числовое значение.");
            }
            if (checkSymbol(c))
            {
                throw new Exception("Ошибка ввода ТРЕТЬЕГО коэффициента: коэффициент должен иметь числовое значение.");
            }
            
            if (checkZero(a) && !checkZero(b))
            {
                throw new Exception("При нулевом значении первого коэффициента квадратного уравнения, оно становится линейным, измените значение первого коэффициента.");
            }
            if (checkZero(a) && checkZero(b))
            {
                throw new Exception("Ошибка, уравнение выраждено.");
            }
        }

        public List<double> сountRoots(string astr,string bstr,string cstr)
        {
            checkValues(astr, bstr, cstr);
            double A = 0.0, B = 0.0, C = 0.0;
            double x1 = 0.0, x2 = 0.0;
            List<double> result = new List<double>();
            double.TryParse(astr, out A);
            double.TryParse(bstr, out B);
            double.TryParse(cstr, out C);
            double disc = 0.0;

                disc = Math.Pow(B, 2) - 4 * A * C;
                if (disc < 0)
                {
                    throw new Exception("Данное квадратное уравнение не имеет вещественных(действительных) решений.");
                result.Add(-0);
                }
                else if (disc == 0)
                {
                    
                    x1 = ((B * -1) + Math.Sqrt(disc)) / (2 * A);
                result.Add(disc);
                result.Add(x1);
                }
                else
                {
                   
                    x1 = ((B * -1) - Math.Sqrt(disc)) / (2 * A);
                    x2 = ((B * -1) + Math.Sqrt(disc)) / (2 * A);
                result.Add(disc);
                result.Add(x1);
                result.Add(x2);
            }
            return result;
            }
        
    }
}
