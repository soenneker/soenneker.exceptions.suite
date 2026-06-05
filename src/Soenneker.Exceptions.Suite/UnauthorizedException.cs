using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Represents the unauthorized exception.
/// </summary>
public sealed class UnauthorizedException : Exception
{
    public UnauthorizedException()
    {
    }

    public UnauthorizedException(string message) : base(message)
    {
    }

    public UnauthorizedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}