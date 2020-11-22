using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Artanh : Function
    {
        public override Expr Arg { get; }

        public Artanh(Expr arg) => Arg = arg;
        public Artanh(double arg) => Arg = new Constant(arg);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            var arg = Arg.Compute(variableValues);
            return (Math.Log(1 + arg) - Math.Log(1 - arg)) / 2;
        }
    }
}