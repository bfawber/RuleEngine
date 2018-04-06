using AGPRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGPRuleEngine.Unification
{
    public interface IUnificationEngine
    {
		UnificationResult Unification(Term term1, Term term2, KnowledgeBase knowledgeBase);
    }
}
