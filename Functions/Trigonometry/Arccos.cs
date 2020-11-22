using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Arccos : Function
    {
        public override Expr Arg { get; }

        public Arccos(Expr arg) => Arg = arg;
        public Arccos(double arg) => Arg = new Constant(arg);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            var arg = Arg.Compute(variableValues);
            return Math.Acos(arg);
        }
    }
}