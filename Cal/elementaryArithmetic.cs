using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    internal class elementaryArithmetic
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        public bool operatorChangeFlag = false;
        double firstOperand = 0;
        double secondOperand = 0;

        public string Result(string x)
        {
            secondOperand = Double.Parse(x);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                return firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                return firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                return firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    return "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstOperand /= secondOperand;
                    return firstOperand.ToString();
                }
            }
            return secondOperand.ToString();
        }

        public void Add(string x)
        {
            firstOperand = Double.Parse(x);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }
        public void Subtract(string x)
        {
            firstOperand = Double.Parse(x);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }
        public void Multiply(string x)
        {
            firstOperand = Double.Parse(x);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }
        public void Divide(string x)
        {
            firstOperand = Double.Parse(x);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }
    }
}
