using System;
using System.Collections.Generic;

using static System.Math;

namespace CSharp_Lab_3
{
   public class Pow : Function
   {
      public Pow(Expr x, double power) : base(x)
      {
            Power = power;
      }

      private double Power;

      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => false; }

      public override double Compute(IReadOnlyDictionary<string, double> variableValues)
      {
         return Pow(_operand.Compute(variableValues), Power);
      } 
   }  
}