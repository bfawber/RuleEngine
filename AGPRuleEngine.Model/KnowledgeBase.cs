using System;
using System.Collections.Generic;
using System.Text;

namespace AGPRuleEngine.Model
{
	/// <summary>
	/// Contains all known information
	/// </summary>
    public class KnowledgeBase
    {
		/// <summary>
		/// A list of the known <see cref="Term"/>s
		/// </summary>
		public List<Term> Knowledge { get; set; }
    }
}
