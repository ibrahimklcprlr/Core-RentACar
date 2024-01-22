using Core.CrossCuttingConserns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Exceptions.HttpProblemDetails
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public IEnumerable<ValidationExceptionModel> Errors { get; set; }

        public ValidationProblemDetails(IEnumerable<ValidationExceptionModel> errors)
        {
            Title = "Validation Errors";
            Detail = "One or More validation Error Occurred";
            Errors = errors;
            Status = StatusCodes.Status400BadRequest;
            Type = "http://example.com/probs/validation";

        }
    }
}
