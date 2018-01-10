using System;

namespace AGPBinaryExpressionTree
{
	public class LeafNode<T> : Node
    {
		private readonly T _value;
		private readonly Func<T, bool> _evaluateValue;

		public LeafNode(T value, Func<T, bool> evaluateValue) : base(null, null)
		{
			this._value = value;
			this._evaluateValue = evaluateValue;
		}

		public override bool Evaluate()
		{
			return _evaluateValue(_value);
		}
	}
}
