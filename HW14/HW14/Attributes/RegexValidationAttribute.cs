using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW14.Attributes
{
    // temlplate - шаблон
    class RegexValidationAttribute : ValidationAttribute
    {
        private string template;

        public RegexValidationAttribute(string template)
        {
            this.template = template;
        }
        //____________
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string valueStr = value.ToString();

                Match m = Regex.Match(valueStr, template, RegexOptions.None);

                if (m.Success)
                    return true;
                else
                {
                    if(string.IsNullOrEmpty(ErrorMessage)) ErrorMessage = "Не соответствует регулярному выражению";
                }
                    
            }
            return false;
        }
    }
}
