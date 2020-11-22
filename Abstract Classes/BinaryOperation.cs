namespace CSharp_Lab_3
{
   abstract public class BinaryOperation : Expr
   {
      abstract public Expr LhsArg { get; }
      abstract public Expr RhsArg { get; }
   }
}