using System.Collections.Generic;

namespace AGPBinaryExpressionTree
{
	/// <summary>
	/// Represents a Node in a boolean binary expression tree
	/// </summary>
	public abstract class Node
    {
		protected readonly List<Node> _children;

		/// <summary>
		/// Initializes a new instance of a <see cref="Node"/> class
		/// </summary>
		/// <param name="left">The left child node</param>
		/// <param name="right">The right child node</param>
		public Node(List<Node> children)
		{
			_children = children;
		}

		/// <summary>
		/// Evaluates the boolean expression to the current node
		/// </summary>
		/// <returns>the result of the boolean expression (true or false) to this point in the tree</returns>
		public abstract bool Evaluate();

		/// <summary>
		/// Add's a child to the node
		/// </summary>
		/// <param name="child">The child to add</param>
		public virtual void AddChild(Node child)
		{
			_children.Add(child);
		}
    }
}
