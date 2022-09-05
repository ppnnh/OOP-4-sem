using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class PassportAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string str = value.ToString();
                try
                {
                    Convert.ToInt32(str.Substring(2));

                    if (str[0] < 'A' || str[0] > 'Z' || str[1] < 'A' || str[1] > 'Z' || str.Length != 9)
                    {
                        
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    
                }
            }

            ErrorMessage = "Неверный формат паспорта";
            return false;
        }
    }
}
