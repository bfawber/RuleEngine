using Xunit;
using AGPBinaryExpressionTree.Operators;
using System.Collections.Generic;

namespace AGPBinaryExpressionTree.Test
{
	public class EvaluationTests
    {
        [Fact]
        public void CanCreateLeafNode()
        {
			LeafNode<int> node = new LeafNode<int>(0, (i) => { return true; });
        }

		[Fact]
		public void CanCreateAndOperator()
		{
			Operator andOperator = new AndOperator();
		}

		[Fact]
		public void CanCreateOrOperator()
		{
			Operator orOperator = new OrOperator();
		}

		[Fact]
		public void CanCreateOperatorNode()
		{
			Operator op = new AndOperator();
			OperatorNode opNode = new OperatorNode(null, op);
		}

		/// <summary>
		/// A * B
		/// </summary>
		[Fact]
		public void CanPerformSimpleAndTree()
		{
			List<Node> children = new List<Node>
			{
				new LeafNode<int>(0, SimpleValueExpressionFunction),
				new LeafNode<int>(0, SimpleValueExpressionFunction)
			};

			Operator op = new AndOperator();
			OperatorNode opNode00 = new OperatorNode(children, op);

			children = new List<Node>
			{
				new LeafNode<int>(0, SimpleValueExpressionFunction),
				new LeafNode<int>(1, SimpleValueExpressionFunction)
			};
			OperatorNode opNode01 = new OperatorNode(children, op);

			children = new List<Node>
			{
				new LeafNode<int>(1, SimpleValueExpressionFunction),
				new LeafNode<int>(0, SimpleValueExpressionFunction)
			};
			OperatorNode opNode10 = new OperatorNode(children, op);

			children = new List<Node>
			{
				new LeafNode<int>(1, SimpleValueExpressionFunction),
				new LeafNode<int>(1, SimpleValueExpressionFunction)
			};
			OperatorNode opNode11 = new OperatorNode(children, op);

			Assert.False(opNode00.Evaluate());
			Assert.False(opNode01.Evaluate());
			Assert.False(opNode10.Evaluate());
			Assert.True(opNode11.Evaluate());
		}

		/// <summary>
		/// A + B
		/// </summary>
		[Fact]
		public void CanPerformSimpleOrTree()
		{
			List<Node> children = new List<Node>
			{
				new LeafNode<int>(0, SimpleValueExpressionFunction),
				new LeafNode<int>(0, SimpleValueExpressionFunction)
			};

			Operator op = new OrOperator();
			OperatorNode opNode00 = new OperatorNode(children, op);

			children = new List<Node>
			{
				new LeafNode<int>(0, SimpleValueExpressionFunction),
				new LeafNode<int>(1, SimpleValueExpressionFunction)
			};
			OperatorNode opNode01 = new OperatorNode(children, op);

			children = new List<Node>
			{
				new LeafNode<int>(1, SimpleValueExpressionFunction),
				new LeafNode<int>(0, SimpleValueExpressionFunction)
			};
			OperatorNode opNode10 = new OperatorNode(children, op);

			children = new List<Node>
			{
				new LeafNode<int>(1, SimpleValueExpressionFunction),
				new LeafNode<int>(1, SimpleValueExpressionFunction)
			};
			OperatorNode opNode11 = new OperatorNode(children, op);

			Assert.False(opNode00.Evaluate());
			Assert.True(opNode01.Evaluate());
			Assert.True(opNode10.Evaluate());
			Assert.True(opNode11.Evaluate());
		}

		/// <summary>
		/// A + B * C + D
		/// 
		/// A | B | C | D | R |  
		/// 0 | 0 | 0 | 0 | 0 |  1
		/// 1 | 0 | 0 | 0 | 0 |  2
		/// 0 | 1 | 0 | 0 | 0 |  3
		/// 0 | 0 | 1 | 0 | 0 |  4
		/// 0 | 0 | 0 | 1 | 1 |  5
		/// 1 | 1 | 0 | 0 | 0 |  6
		/// 1 | 0 | 1 | 0 | 1 |  7
		/// 1 | 0 | 0 | 1 | 1 |  8
		/// 0 | 1 | 1 | 0 | 1 |  9
		/// 0 | 1 | 0 | 1 | 1 |  10
		/// 0 | 0 | 1 | 1 | 1 |  11
		/// 1 | 1 | 1 | 0 | 1 |  12
		/// 0 | 1 | 1 | 1 | 1 |  13
		/// 1 | 1 | 0 | 1 | 1 |  14
		/// 1 | 0 | 1 | 1 | 1 |  15
		/// 1 | 1 | 1 | 1 | 1 |  16
		/// </summary>
		[Theory]
		[InlineData(0, 0, 0, 0)]
		[InlineData(1, 0, 0, 0)]
		[InlineData(0, 1, 0, 0)]
		[InlineData(0, 0, 1, 0)]
		[InlineData(0, 0, 0, 1)]
		[InlineData(1, 1, 0, 0)]
		[InlineData(1, 0, 1, 0)]
		[InlineData(1, 0, 0, 1)]
		[InlineData(0, 1, 1, 0)]
		[InlineData(0, 1, 0, 1)]
		[InlineData(0, 0, 1, 1)]
		[InlineData(1, 1, 1, 0)]
		[InlineData(0, 1, 1, 1)]
		[InlineData(1, 1, 0, 1)]
		[InlineData(1, 0, 1, 1)]
		[InlineData(1, 1, 1, 1)]
		public void CanPerformMultiOperationalExpression(int a, int b, int c, int d)
		{
			Dictionary<string, bool> expectedAnswersMap = new Dictionary<string, bool>
			{
				{"0000", false },
				{"1000", false },
				{"0100", false },
				{"0010", false },
				{"0001", true },
				{"1100", false },
				{"1010", true },
				{"1001", true },
				{"0110", true },
				{"0101", true },
				{"0011", true },
				{"1110", true },
				{"0111", true },
				{"1101", true },
				{"1011", true },
				{"1111", true },
			};
			LeafNode<int> A = new LeafNode<int>(a, SimpleValueExpressionFunction);
			LeafNode<int> B = new LeafNode<int>(b, SimpleValueExpressionFunction);
			LeafNode<int> C = new LeafNode<int>(c, SimpleValueExpressionFunction);
			LeafNode<int> D = new LeafNode<int>(d, SimpleValueExpressionFunction);
			List<Node> firstOrChildren = new List<Node>
			{
				A,
				B
			};
			List<Node> middleAndChildren = new List<Node>();
			List<Node> lastOrChildren = new List<Node>();
			Operator andOp = new AndOperator();
			Operator orOp = new OrOperator();

			OperatorNode firstOr = new OperatorNode(firstOrChildren, orOp);

			middleAndChildren.Add(firstOr);
			middleAndChildren.Add(C);
			OperatorNode middleAnd = new OperatorNode(middleAndChildren, andOp);

			lastOrChildren.Add(middleAnd);
			lastOrChildren.Add(D);
			OperatorNode lastOr = new OperatorNode(lastOrChildren, orOp);

			Assert.Equal(lastOr.Evaluate(), expectedAnswersMap[$"{a}{b}{c}{d}"]);
		}

		/// <summary>
		/// !(A * B)
		/// </summary>
		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, 0)]
		[InlineData(0, 1)]
		[InlineData(1, 1)]
		public void CanEvaluateSimpleNandGate(int a, int b)
		{
			Dictionary<string, bool> expectedAnswersMap = new Dictionary<string, bool>
			{
				{"00", true },
				{"10", true },
				{"01", true },
				{"11", false }
			};
			List<Node> andChildren = new List<Node>
			{
				new LeafNode<int>(a, SimpleValueExpressionFunction),
				new LeafNode<int>(b, SimpleValueExpressionFunction)
			};

			OperatorNode opNode = new OperatorNode(andChildren, new AndOperator());

			List<Node> notChild = new List<Node>
			{
				opNode
			};
			OperatorNode notOp = new OperatorNode(notChild, new NotOperator());

			Assert.Equal(notOp.Evaluate(), expectedAnswersMap[$"{a}{b}"]);
		}


		public bool SimpleValueExpressionFunction(int x)
		{
			if(x == 1)
			{
				return true;
			}
			return false;
		}
	}
}
