using AirlineWebApi.Utils;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace AirlineWebApi
{
    public class ex
    {
        public Type ExceptionType { get; set; }
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public bool IncludeExceptionMessage { get; set; } = true;

        private ILogger<ExceptionMapperAttribute> logger;

    }
}
