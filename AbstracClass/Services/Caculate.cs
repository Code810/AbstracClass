using AbstracClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracClass.Services
{
    internal class Caculate : ICaculate
    {
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiple(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Plus(double num1, double num2)
        {
           return num1+num2;
        }

        public double Substract(double num1, double num2)
        {
            return (num1 - num2);
        }
    }
}
