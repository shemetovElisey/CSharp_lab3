using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public abstract class Expr
    {
        public abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
        public abstract bool IsConstant { get; }
        public abstract bool IsPolynom { get; }

        public static Expr operator +(Expr Arg) => new Plus(Arg);
        public static Expr operator -(Expr Arg) => new Negate(Arg);

        public static Expr operator +(Expr LhsArg, Expr RhsArg) => new Sum(LhsArg, RhsArg);
        public static Expr operator +(Expr LhsArg, double RhsArg) => new Sum(LhsArg, new Constant(RhsArg));
        public static Expr operator +(double LhsArg, Expr RhsArg) => new Sum(RhsArg, new Constant(LhsArg));

        public static Expr operator -(Expr LhsArg, Expr RhsArg) => new Subtract(LhsArg, RhsArg);
        public static Expr operator -(Expr LhsArg, double RhsArg) => new Subtract(LhsArg, new Constant(RhsArg));
        public static Expr operator -(double LhsArg, Expr RhsArg) => new Subtract(RhsArg, new Constant(LhsArg));

        public static Expr operator *(Expr LhsArg, Expr RhsArg) => new Multiply(LhsArg, RhsArg);
        public static Expr operator *(Expr LhsArg, double RhsArg) => new Multiply(LhsArg, new Constant(RhsArg));
        public static Expr operator *(double LhsArg, Expr RhsArg) => new Multiply(RhsArg, new Constant(LhsArg));

        public static Expr operator /(Expr LhsArg, Expr RhsArg) => new Divide(LhsArg, RhsArg);
        public static Expr operator /(Expr LhsArg, double RhsArg) => new Divide(LhsArg, new Constant(RhsArg));
        public static Expr operator /(double LhsArg, Expr RhsArg) => new Divide(RhsArg, new Constant(LhsArg));
    }
}
