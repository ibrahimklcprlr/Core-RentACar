using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Exceptions.Extensions
{
    public static class ProblemDetailsExtensions
    {
        public static string AsJson<T>(this T details) where T:ProblemDetails=>JsonSerializer.Serialize(details);
    }
}
