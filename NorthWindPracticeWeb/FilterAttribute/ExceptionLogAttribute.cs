using System.Web.Mvc;

namespace NorthWindPracticeWeb.FilterAttribute
{
    public sealed class ExceptionLogAttribute : System.Web.Mvc.FilterAttribute, IExceptionFilter
    {
        public string ErrorMessage { get; set; } = "錯誤。處理您的要求時發生錯誤。";

        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            var errorMessage = filterContext.Exception.Message;
            //todo Log將錯誤訊息接住並記錄下來
            filterContext.ExceptionHandled = true;
            filterContext.Controller.ViewData["ErrorMessage"] = ErrorMessage;
            filterContext.Result = new ViewResult { MasterName = "", ViewName = "Error" };
        }
    }
}