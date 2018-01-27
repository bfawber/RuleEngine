using System.Collections.Generic;

namespace AGPBinaryExpressionTree.Operators
{
	public class OrOperator : Operator
	{
		/// <summary>
		/// Performs an operation on the results from the left and right child nodes
		/// </summary>
		/// <param name="left">the left childe node</param>
		/// <param name="right">the right child node</param>
		/// <returns>the result of applying the operator to the left and right child nodes</returns>
		public override bool Operate(List<Node> children)
		{
			for(int i = 0; i < children.Count; i++)
			{
				if(children[i].Evaluate())
				{
					return true;
				}
			}

			return false;
		}
	}
}
