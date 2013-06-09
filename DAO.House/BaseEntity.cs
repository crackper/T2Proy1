using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAO.House
{
    public class BaseEntity
    {
        public bool Validate(out string mErrors)
        {
            var errors = DataValidator.Validate(this);
            StringBuilder message = new StringBuilder();
            var isValid = true;
            mErrors = "";

            if (errors.Any())
            {
                isValid = false;

                foreach (var item in errors)
                {
                    message.AppendLine(item.Message);
                }

                mErrors = message.ToString();
            }           

            return isValid;
        }
    }
}
