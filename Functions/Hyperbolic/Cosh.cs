using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Cosh : Function
    {
        public override Expr Arg { get; }

        public Cosh(Expr argument) => Arg = argument;
        public Cosh(double argument) => Arg = new Constant(argument);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            var arg = Arg.Compute(variableValues);
            return Math.Cosh(arg);
        }
    }
}