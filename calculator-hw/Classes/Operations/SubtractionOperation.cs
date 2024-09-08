﻿using calculator_hw.Interfaces;

namespace calculator_hw.Classes.Operations
{
    public class SubtractionOperation : IOperation
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            return leftOperand -= rightOperand;
        }
    }
}