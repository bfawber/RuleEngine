namespace AGPBinaryExpressionTree.Operators
{
	/// <summary>
	/// Handles the AND gate operation
	/// </summary>
	public class AndOperator : Operator
	{
		/// <summary>
		/// Performs an operation on the results from the left and right child nodes
		/// </summary>
		/// <param name="left">the left childe node</param>
		/// <param name="right">the right child node</param>
		/// <returns>the result of applying the operator to the left and right child nodes</returns>
		public override bool Operate(Node left, Node right)
		{
			return left.Evaluate() && right.Evaluate();
		}
	}
}
