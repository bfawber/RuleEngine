using System;

namespace AGPBinaryExpressionTree.Exceptions
{
	/// <summary>
	/// Thrown when an <see cref="Operators.Operator"/> is used innappropriately
	/// </summary>
	public class InvalidUseOfOperatorException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidUseOfOperatorException"/> class.
		/// </summary>
		/// <param name="operatorType">The type of operator that was used incorrectly</param>
		public InvalidUseOfOperatorException(Type operatorType) : base($"Invalid use of the {operatorType.Name} operator") { }
    }
}
