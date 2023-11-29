using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Reg_Login_Page.CommonFile
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
           DateTime dateTime = Convert.ToDateTime(value);

           if (dateTime == DateTime.Now)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}