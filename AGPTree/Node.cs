namespace AGPBinaryExpressionTree
{
	public abstract class Node
    {
		protected readonly Node _left;
		protected readonly Node _right;

		public Node(Node left, Node right)
		{
			_left = left;
			_right = right;
		}

		public abstract bool Evaluate();
    }
}
