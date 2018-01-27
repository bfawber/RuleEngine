using AGPBinaryExpressionTree.Exceptions;
using System;

namespace AGPBinaryExpressionTree
{
	/// <summary>
	/// Represents a Leaf Node in a boolean binary expression tree
	/// </summary>
	/// <typeparam name="T">The type of value the leaf node stores</typeparam>
	public class LeafNode<T> : Node
    {
		private readonly T _value;
		private readonly Func<T, bool> _evaluateValue;

		/// <summary>
		/// Initializes a new instance of a <see cref="LeafNode{T}"/> class
		/// </summary>
		/// <param name="value">The value stored by the node</param>
		/// <param name="evaluateValue">The function that turns the value stored into a true or false value</param>
		public LeafNode(T value, Func<T, bool> evaluateValue) : base(null)
		{
			this._value = value;
			this._evaluateValue = evaluateValue;
		}

		/// <summary>
		/// Evaluates the boolean expression to the current node
		/// </summary>
		/// <returns>the result of the boolean expression (true or false) to this point in the tree</returns>
		public override bool Evaluate()
		{
			return _evaluateValue(_value);
		}

		public override void AddChild(Node child)
		{
			throw new InvalidNodeOperationException(nameof(AddChild));
		}
	}
}
