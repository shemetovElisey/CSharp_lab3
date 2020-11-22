using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Variable : Expr
    {
        private string var;
        public Variable(string Var) => var = Var;
        public override bool IsConstant { get => false; }
        public override bool IsPolynom { get => true; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => variableValues[var];
    }
}