using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

#pragma warning disable 1591

namespace ServerLibrary.Exceptions
{
    public sealed class CustomExceptionLogger : ExceptionLogger
    {
        public override Task LogAsync(ExceptionLoggerContext context,
                                    CancellationToken cancellationToken)
        {
            return LogAsyncCore(context, cancellationToken);
        }
        private static Regex _authExtractor = new Regex(@"(.*)Authorization: \w+ (\w+.*?) (.*)");
        private Task LogAsyncCore(ExceptionLoggerContext context,
                                    CancellationToken cancellationToken)
        {
            return new Task(new Action(() => { }));
            //try
            //{
            //    if (context.Exception is ResponseException)
            //    {
            //        var ex = (ResponseException)context.Exception;
            //        using (var db = new Entities())
            //        {
            //            db.LogException(ex.ExceptionData, context);
            //        }
            //    }
            //    else
            //    {
            //        var request = context.RequestContext.Url.Request.ToString();
            //        var matches = _authExtractor.Match(request);
            //        string contextString;
            //        if (matches.Success)
            //        {
            //            var match1 = _authExtractor.Match(request).Groups[0];
            //            //var match2 = _authExtractor.Match(request).Groups[1];
            //            var match3 = _authExtractor.Match(request).Groups[2];
            //            var caller =
            //                context.Request.GetOwinContext()
            //                    .Authentication.User.Claims.First(x => x.Type.Equals(ClaimTypes.Name));
            //            contextString =
            //                $"{match1}{caller}{match3}";

            //        }
            //        else
            //        {
            //            contextString = request;
            //        }
            //        return Task.Factory.StartNew(() =>
            //        {
            //            var db = new probowkiSQL();
            //            db.LogException(context.Exception.GetType().ToString(),
            //                Utilities.GetServerTime(),
            //                context.Exception.Message,
            //                contextString,
            //                context.ToString(), context.Exception.InnerException?.Message);
            //            db.Dispose();
            //        }, cancellationToken);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Trace.TraceError("Exception was not saved in datebase! Reason: " + e.Message + "\n");
            //    Trace.Flush();
            //}
            //return Task.FromResult(0);
        }
    }
}

