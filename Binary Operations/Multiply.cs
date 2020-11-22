using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Multiply : BinaryOperation
    {
        public override Expr LhsArg { get; }
        public override Expr RhsArg { get; }

        public Multiply(Expr lhsVal, Expr rhsVal)
        {
            LhsArg = lhsVal;
            RhsArg = rhsVal;
        }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
            => LhsArg.Compute(variableValues) * RhsArg.Compute(variableValues);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }
    }
}