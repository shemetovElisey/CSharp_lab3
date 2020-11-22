using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Coth : Function
    {
        public override Expr Arg { get; }

        public Coth(Expr argument) => Arg = argument;
        public Coth(double argument) => Arg = new Constant(argument);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            var arg = Arg.Compute(variableValues);
            return 1 / Math.Tanh(arg);
        }
    }
}