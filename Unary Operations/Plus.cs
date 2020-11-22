using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Plus : UnaryOperation
    {
        public Plus(Expr arg) => Arg = arg;
        public Plus(double arg) => Arg = new Constant(arg);

        public override Expr Arg { get; }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
           => Arg.Compute(variableValues);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }
    }
}