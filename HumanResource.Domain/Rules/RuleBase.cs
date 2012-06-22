using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Domain.Rules
{
    public abstract class RuleBase : IRule 
    {
        protected string description;

        public RuleBase(string expression, string description)
        {
            this.expression = expression;
            this.description = description;
        }

        public RuleBase(string expression) : this(expression, "")
        { }

        private string expression;
        public string Expression
        {
            get { return this.expression; }
        }

        public abstract bool IsValid();

        public string Description
        {
            get { return this.description; }
        }

    }
}
