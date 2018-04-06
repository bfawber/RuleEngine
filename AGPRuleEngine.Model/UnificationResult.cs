using System;
using System.Collections.Generic;
using System.Text;

namespace AGPRuleEngine.Model
{
    public class UnificationResult
    {
		public bool DidUnify { get; set; }

		/// <summary>
		/// TODO: Change the string to new custom object for arguments
		/// </summary>
		public Dictionary<string, string> Bindings { get; set; } = new Dictionary<string, string>();
    }
}
