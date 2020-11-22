using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Sum : BinaryOperation
    {
        public override Expr LhsArg { get; }
        public override Expr RhsArg { get; }

        public Sum(Expr lhsArg, Expr rhsArg)
        {
            LhsArg = lhsArg;
            RhsArg = rhsArg;
        }

        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
             => LhsArg.Compute(variableValues) + RhsArg.Compute(variableValues);

        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => false; }
    }
}