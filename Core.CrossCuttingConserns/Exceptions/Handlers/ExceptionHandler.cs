﻿using Core.CrossCuttingConserns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Exceptions.Handlers;

public abstract class ExceptionHandler
{
    public Task HandlerExceptionAsync(Exception exception) =>
        exception switch
        {
            BusinessException businessException => HandleException(businessException),
            ValidationException validationException => HandleException(validationException),
            _ => HandlerExceptionAsync(exception)
        };
    protected abstract Task HandleException(BusinessException businessException);
    protected abstract Task HandleException(ValidationException validationException);
    protected abstract Task HandleException(Exception exception);
}
