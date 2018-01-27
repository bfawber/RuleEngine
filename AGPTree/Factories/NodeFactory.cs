using AGPBinaryExpressionTree.Operators;
using System;
using System.Collections.Generic;

namespace AGPBinaryExpressionTree.Factories
{
	/// <summary>
	/// For constructing specific <see cref="Node"/> types
	/// </summary>
	public static class NodeFactory
    {
		/// <summary>
		/// Creates a <see cref="LeafNode{T}"/>
		/// </summary>
		/// <typeparam name="T">The type of value the leaf node stores</typeparam>
		/// <param name="value">the value the leaf node should store</param>
		/// <param name="evalFunc">the function that should be used to determine whether the value
		/// is a truthy or falsey value</param>
		/// <returns>A new leaf node based on the given parameters</returns>
		public static Node CreateNode<T>(T value, Func<T,bool> evalFunc)
		{
			return new LeafNode<T>(value, evalFunc);
		}

		/// <summary>
		/// Creates a <see cref="OperatorNode"/>
		/// </summary>
		/// <param name="oprtr">The operator used by the operator node</param>
		/// <param name="left">the left child of the operator node</param>
		/// <param name="right">the right child of the operator node</param>
		/// <returns>A new operator node based on the given parameters</returns>
		public static Node CreateNode(Operator oprtr, List<Node> children)
		{
			return new OperatorNode(children, oprtr);
		}
    }
}
