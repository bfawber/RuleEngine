namespace AGPBinaryExpressionTree
{
	/// <summary>
	/// Represents a Node in a boolean binary expression tree
	/// </summary>
	public abstract class Node
    {
		protected readonly Node _left;
		protected readonly Node _right;

		/// <summary>
		/// Initializes a new instance of a <see cref="Node"/> class
		/// </summary>
		/// <param name="left">The left child node</param>
		/// <param name="right">The right child node</param>
		public Node(Node left, Node right)
		{
			_left = left;
			_right = right;
		}

		/// <summary>
		/// Evaluates the boolean expression to the current node
		/// </summary>
		/// <returns>the result of the boolean expression (true or false) to this point in the tree</returns>
		public abstract bool Evaluate();
    }
}
