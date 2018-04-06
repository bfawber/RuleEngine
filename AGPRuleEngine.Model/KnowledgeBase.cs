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
		/// The things that are known about the state
		/// </summary>
		public List<Term> Perception { get; set; }

		/// <summary>
		/// The internal state of the AI. May not be used in cases where not a game
		/// </summary>
		public List<Term> InternalState { get; set; }

		/// <summary>
		/// Information obtained by firing rules. TODO: Probably need a custom object that
		/// tells whether this info is stale or not.
		/// </summary>
		public List<Term> Inferences { get; set; }
    }
}
