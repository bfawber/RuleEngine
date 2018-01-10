namespace AGPBinaryExpressionTree.Operators
{
	public class OrOperator : Operator
	{
		public override bool Operate(Node left, Node right)
		{
			return left.Evaluate() || right.Evaluate();
		}
	}
}
