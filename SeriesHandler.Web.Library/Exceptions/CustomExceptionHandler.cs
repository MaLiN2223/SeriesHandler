using System.Net.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace ServerLibrary.Exceptions
{
    public sealed class CustomExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception as ResponseException;
            if (exception == null) return;
            var exc = exception;

            context.Result = new ResponseMessageResult(
                context.Request.CreateResponse(
                    exc.ExceptionData.Code, "Reason: " + exc.ExceptionData.Reason +
                                            (exc.ExceptionData.Reason.Contains("inner") ?
                                                " Inner : " + exc.ExceptionData.InnerMessage : ""
                                                ))
                );
        }
    }
}