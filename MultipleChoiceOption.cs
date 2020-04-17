using System;
using System.Collections.Generic;
using System.Text;

namespace MDIXTemplateSelector
{
    public class MultiplChoiceOption : Option
    {
        public IList<string> Options { get; }

        public MultiplChoiceOption(string text, string type, IList<string> options) : base(text, type)
        {
            Options = options;
        }
    }
}
