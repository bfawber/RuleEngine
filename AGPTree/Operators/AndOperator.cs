namespace AGPBinaryExpressionTree.Operators
{
	public class AndOperator : Operator
	{
		public override bool Operate(Node left, Node right)
		{
			return left.Evaluate() && right.Evaluate();
		}
	}
}
