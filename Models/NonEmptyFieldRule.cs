using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Repair_Service.Models
{
    public class NonEmptyFieldRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
            if(value == null)
            {
                return new ValidationResult(false, "The field cannot be empty!");
            }
            else if(value.GetType() == typeof(Employee))
            {
                if (((Employee)value).Name.Equals(string.Empty))
                {
                    return new ValidationResult(false, "The field cannot be empty!");
                }

            }
            else if (((string)value).Equals(string.Empty))
            {
                return new ValidationResult(false, "The field cannot be empty!");
            }
            return new ValidationResult(true, null);
        }
    }
}
