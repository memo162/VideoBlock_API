using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Models.Exceptions;

namespace VideoBlock_API.Filters
{
    public class ExceptionHandlerFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<ExceptionHandlerFilter> _logger;

        public ExceptionHandlerFilter(IWebHostEnvironment webHostEnvironment,
            ILogger<ExceptionHandlerFilter> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var exceptionReturnMessage = $"Internal Error at { _webHostEnvironment.ApplicationName } " +
                    $"type: { context.Exception.GetType() } ";

            if (context.Exception is NotFoundDBException)
            {
                context.Result = new JsonResult(exceptionReturnMessage + context.Exception.Message);
            }
            else 
            {
                context.Result = new JsonResult(exceptionReturnMessage);
                _logger.LogError(0, context.Exception, exceptionReturnMessage);
            }
        }
    }
}
