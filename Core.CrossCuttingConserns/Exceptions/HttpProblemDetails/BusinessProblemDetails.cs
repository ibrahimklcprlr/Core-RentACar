﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Exceptions.HttpProblemDetails
{
    public class BusinessProblemDetails:ProblemDetails
    {
        public BusinessProblemDetails(string detail)
        {
            Title = "Rule violation";
            Detail=detail;
            Status = StatusCodes.Status400BadRequest;
            Type = "http://example.com/probs/business";

        }
    }
}
