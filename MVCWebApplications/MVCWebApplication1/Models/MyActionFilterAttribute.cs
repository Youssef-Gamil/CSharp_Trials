using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCWebApplication1.Models
{
    public class MyActionFilterAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
           if (context.Exception != null)
            {
                File.AppendAllText("D:\\CSharp_Trials\\MVCWebApplications\\MVCWebApplication1\\bin\\log.txt", context.Exception.ToString());
            }
        }
    }
}
