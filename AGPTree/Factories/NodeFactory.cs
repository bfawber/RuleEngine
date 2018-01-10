using AGPBinaryExpressionTree.Operators;
using System;

namespace AGPBinaryExpressionTree.Factories
{
	public static class NodeFactory
    {
		public static Node CreateNode<T>(T value, Func<T,bool> evalFunc)
		{
			return new LeafNode<T>(value, evalFunc);
		}

		public static Node CreateNode(Operator oprtr, OperatorKind operatorKind, Node left, Node right)
		{
			switch (operatorKind)
			{
				case OperatorKind.AND:
					return new OperatorNode(left, right, new AndOperator());
					break;
				case OperatorKind.OR:
					return new OperatorNode(left, right, new OrOperator());
					break;
			}

			throw new ArgumentException("Operator kind unkown!");
		}
    }
}
