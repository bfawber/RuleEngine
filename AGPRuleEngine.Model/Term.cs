using System;
using System.Collections.Generic;
using System.Text;

namespace AGPRuleEngine.Model
{
	/// <summary>
	/// Represents a state
	/// </summary>
    public class Term
    {
		/// <summary>
		/// The Term's 'Action'
		/// </summary>
		public string Functor { get; set; }

		/// <summary>
		/// The things involved in the Term's 'Action'
		/// </summary>
		public List<string> Arguments { get; set; }
    }
}
