using AGPBinaryExpressionTree.Operators;

namespace AGPBinaryExpressionTree
{
	public class OperatorNode : Node
	{
		private readonly Operator _operator;

		public OperatorNode(Node left, Node right, Operator oprtr) : base(left, right)
		{
			_operator = oprtr;
		}

		public override bool Evaluate()
		{
			return _operator.Operate(_left, _right);
		}
	}
}
