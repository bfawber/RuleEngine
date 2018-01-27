using System;
using System.Collections.Generic;
using System.Text;

namespace AGPBinaryExpressionTree.Exceptions
{
    public class InvalidNodeOperationException : Exception
    {
		public InvalidNodeOperationException(string action) : base($"A {action} cannot be performed on this node!")
		{
		}
    }
}
