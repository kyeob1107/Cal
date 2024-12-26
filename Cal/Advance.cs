using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    internal class Advance
    {
        public string Reciprocal_lamda(double num) => (1 / num).ToString();
        public string Square_lamda(double num) => (num * num).ToString();
        public string SquareRoot_lamda(double num) => (Math.Sqrt(num)).ToString();
        public string SignChange_lamda(double num) => (-1 * num).ToString();
        public string Reciprocal(string strNumber)
        {
            double Number = double.Parse(strNumber);
            Number = 1 / Number;

            return Number.ToString();
        }

        public string Square(string strNumber)
        {
            double Number = double.Parse(strNumber);
            Number = Number * Number;

            return Number.ToString();
        }
        public string SquareRoot(string strNumber)
        {
            double Number = double.Parse(strNumber);
            Number = Math.Sqrt(Number);
            return Number.ToString();
        }
        public string SignChange(string strNumber)
        {
            double Number = double.Parse(strNumber);
            Number = -1 * Number;
            return Number.ToString();
        }
    }
}
