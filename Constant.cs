using System.Collections.Generic;

namespace CSharp_Lab_3
{
    class Constant : Expr
    {
        private double constant;
        public Constant(double constant) => this.constant = constant;
        public override bool IsConstant { get => true; }
        public override bool IsPolynom { get => false; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => constant;
    }
}
