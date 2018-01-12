using AGPBinaryExpressionTree.Operators;

namespace AGPBinaryExpressionTree
{
	/// <summary>
	/// Represents an operator in a boolean binary expression tree
	/// </summary>
	public class OperatorNode : Node
	{
		private readonly Operator _operator;

		/// <summary>
		/// Initializes a new instance of a <see cref="OperatorNode"/> class
		/// </summary>
		/// <param name="left">The left child node</param>
		/// <param name="right">The right childe node</param>
		/// <param name="oprtr">The operator this node represents</param>
		public OperatorNode(Node left, Node right, Operator oprtr) : base(left, right)
		{
			_operator = oprtr;
		}

		/// <summary>
		/// Evaluates the boolean expression to the current node
		/// </summary>
		/// <returns>the result of the boolean expression (true or false) to this point in the tree</returns>
		public override bool Evaluate()
		{
			return _operator.Operate(_left, _right);
		}
	}
}
