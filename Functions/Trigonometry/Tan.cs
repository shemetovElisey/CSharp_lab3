using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Tan : Function
    {
        public override Expr Arg { get; }

        public Tan(Expr arg) => Arg = arg;
        public Tan(double arg) => Arg = new Constant(arg);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            var arg = Arg.Compute(variableValues);
            return Math.Tan(arg);
        }
    }
}