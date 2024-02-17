using System.ComponentModel.DataAnnotations;

namespace SchoolProject_MVC.ValidationAttributtes
{
    public class NotInFuture:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime?) //if value is datetime or nullable datetime
            {
                var v = value as DateTime?; //to cast the value to dateTime so I can access the values of date and time.
                if (v.Value <  DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
