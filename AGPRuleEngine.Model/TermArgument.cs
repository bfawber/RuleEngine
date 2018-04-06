using System;
using System.Collections.Generic;
using System.Text;

namespace AGPRuleEngine.Model
{
    public class TermArgument
    {
		public Guid Id { get; set; }

		public string Name { get; }

		public bool IsVariable { get; }

		public TermArgument(string name, bool isVariable)
		{
			Id = Guid.NewGuid();
			Name = name;
			IsVariable = isVariable;
		}
    }
}
