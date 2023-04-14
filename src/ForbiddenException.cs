using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Will return a 403
/// </summary>
public class ForbiddenException : Exception
{
    public ForbiddenException()
    {
    }

    public ForbiddenException(string message) : base(message)
    {
    }

    public ForbiddenException(string message, Exception innerException) : base(message, innerException)
    {
    }
}