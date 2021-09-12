using System;

namespace HW14.Attributes
{
    class RegexAttribute : Attribute
    {
        public string Template { get; set; }

        public RegexAttribute(string template)
        {
            Template = template;
        }
    }
}
