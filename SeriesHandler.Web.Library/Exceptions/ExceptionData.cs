using System;
using System.Net;
using System.Web.ModelBinding;
using ServerLibrary.Utils;

namespace ServerLibrary.Exceptions
{
    public class ExceptionData
    {
        public ExceptionData()
        {
        }
        public Exception Exception { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }
        public string InnerMessage { get; set; }
        public Utilities.ExceptionType Type { get; set; }
        public HttpStatusCode Code { get; set; }
        public object[] Arguments { get; set; }
        public ModelStateDictionary ModelState { get; set; }
    }
}