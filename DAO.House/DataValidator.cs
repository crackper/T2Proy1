using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAO.House
{
    public class DataValidator
    {
        public class ErrorInfo
        {
            public ErrorInfo(string property, string message)
            {
                this.Property = property;
                this.Message = message;
            }

            public ErrorInfo(string label,string property, string message)
            {
                this.Property = property;
                this.Message = message;
                this.Label = label; 
            }

            public string Label;
            public string Message;
            public string Property;
        }

        public static IEnumerable<ErrorInfo> Validate(object instance)
        {
            return from prop in instance.GetType().GetProperties()
                   from attribute in prop.GetCustomAttributes(typeof(ValidationAttribute), true).OfType<ValidationAttribute>()
                   //from display in prop.GetCustomAttributes(typeof(DisplayAttribute), true).OfType<DisplayAttribute>()
                   where !attribute.IsValid(prop.GetValue(instance, null))
                   select new ErrorInfo(attribute.ErrorMessageResourceName, prop.Name, attribute.FormatErrorMessage(string.Empty));
        }
    }

}
