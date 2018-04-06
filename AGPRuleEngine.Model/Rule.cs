using System;
using System.Collections.Generic;
using System.Text;

namespace AGPRuleEngine.Model
{
    public class Rule
    {
		private List<Term> _pattern;

		private Action<KnowledgeBase> _effect;

		public Rule(List<Term> pattern, Action<KnowledgeBase> effect)
		{
			_pattern = pattern;
			_effect = effect;
		}
    }
}
