namespace CSharp_Lab_3
{
    abstract public class UnaryOperation : Expr
    {
        abstract public Expr Arg { get; }
    }
}