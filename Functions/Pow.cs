using System;
using System.Collections.Generic;

namespace CSharp_Lab_3
{
   public class Pow : Function
   {
      public Pow(Expr arg, double pow)
      {
         Power = pow;
         Arg = arg;
      }

      private double Power;

      public override Expr Arg { get; }

      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => false; }

      public override double Compute(IReadOnlyDictionary<string, double> variableValues)
      {
         var arg = Arg.Compute(variableValues);
         return Math.Pow(arg, Power);
      } 
   }  
}