using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracClass.Interfaces
{
    internal interface ICaculate
    {
        double Divide (double num1, double num2);
        double Multiple (double num1, double num2);
        double Plus (double num1, double num2);
        double Substract (double num1, double num2);
    }
}
