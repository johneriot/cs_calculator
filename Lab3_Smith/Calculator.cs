using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Smith
{
    public class Calculator
    {

        //instance variables
        private double currentValue;
        private double operand1;
        private double operand2;

        //operator enumeration
        private enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            None
        }
        private Operator op = new Operator();

        //param-less constructor 
        public Calculator()
        {
            operand1 = 0;
            operand2 = 0;
            op = Operator.None;
        }

        //constructor with params
        public Calculator(double operand1, double operand2) 
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            op = Operator.None;
        }

        //getter for currentValue
        public double CurrentValue()
        {
            return currentValue;
        }

        //methods for Operator enumeration
        public void Add(double displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = Operator.Add;
        }

        public void Subtract(double displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = Operator.Subtract;
        }

        public void Multiply(double displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = Operator.Multiply;
        }

        public void Divide(double displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = Operator.Divide;
        }

        //equals methods that use the define functionality of Operator enumerations.
        public void Equals()
        {
            if(op == Operator.Add)
            {
                operand1 = currentValue + operand2;
            }
            else if(op == Operator.Divide)
            {
                operand1 = currentValue / operand2;         
            }
            else if(op == Operator.Multiply)
            {
                operand1 = currentValue * operand2;
            }
            else if(op == Operator.Subtract)
            {
                operand1 = currentValue - operand2;
            }
        }

        public double Equals(double displayValue)
        {
            operand2 = displayValue;

            if (op == Operator.Add)
            {
                currentValue = operand1 + operand2;
                
            }
            else if (op == Operator.Divide)
            {
                currentValue = operand1 / operand2;
                
            }
            else if (op == Operator.Multiply)
            {
                currentValue = operand1 * operand2;
                
            }
            else if (op == Operator.Subtract)
            {
                currentValue = operand1 - operand2;
            }
            return currentValue;
        }

        //method to clear textbox
        public void Clear()
        {
            operand1 = this.operand1;
            operand2 = this.operand2;
            op = Operator.None;
        }
    
    }

}
