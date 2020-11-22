using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Arcsin : Function
    {
        public override Expr Arg { get; }

        public Arcsin(Expr argument) => Arg = argument;
        public Arcsin(double argument) => Arg = new Constant(argument);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            var arg = Arg.Compute(variableValues);
            return Math.Asin(arg);
        }
    }
}