using AGPBinaryExpressionTree.Exceptions;
using System.Collections.Generic;
using System.Linq;

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
		public override bool Operate(List<Node> children)
		{
			if(children.Count != 1)
			{
				throw new InvalidUseOfOperatorException(typeof(NotOperator));
			}

			return !children.First().Evaluate();
		}
	}
}
