using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Negate : UnaryOperation
    {
        public Negate(Expr arg) => Arg = arg;
        public Negate(double arg) => Arg = new Constant(arg);

        public override Expr Arg { get; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
           => -Arg.Compute(variableValues);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }
    }
}