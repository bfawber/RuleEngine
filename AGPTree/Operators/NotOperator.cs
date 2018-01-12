using AGPBinaryExpressionTree.Exceptions;

namespace AGPBinaryExpressionTree.Operators
{
	public class NotOperator : Operator
	{
		/// <summary>
		/// Performs an operation on the results from the left and right child nodes
		/// </summary>
		/// <param name="left">the left childe node</param>
		/// <param name="right">the right child node</param>
		/// <returns>the result of applying the operator to the left and right child nodes</returns>
		public override bool Operate(Node left, Node right)
		{
			if(right != null)
			{
				throw new InvalidUseOfOperatorException(typeof(NotOperator));
			}

			return !left.Evaluate();
		}
	}
}
