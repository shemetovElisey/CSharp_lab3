using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
    public class Tanh : Function
   {
      public override Expr Arg { get; }

      public Tanh(Expr argument) => Arg = argument;
      public Tanh(double argument) => Arg = new Constant(argument);

      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => false; }

      public override double Compute(IReadOnlyDictionary<string, double> variableValues)
      {
         var arg = Arg.Compute(variableValues);
         return Math.Tanh(arg);
      }
   }
}