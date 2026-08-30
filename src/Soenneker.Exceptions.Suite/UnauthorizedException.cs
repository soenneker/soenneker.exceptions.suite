using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Indicates that authentication is required or has failed.
/// </summary>
public sealed class UnauthorizedException : Exception
{
    /// <summary>Initializes the exception with the default message.</summary>
    public UnauthorizedException()
    {
    }

    /// <summary>Initializes the exception with a message.</summary>
    /// <param name="message">Description of the authentication failure.</param>
    public UnauthorizedException(string message) : base(message)
    {
    }

    /// <summary>Initializes the exception with a message and the exception that caused it.</summary>
    /// <param name="message">Description of the authentication failure.</param>
    /// <param name="innerException">The underlying exception.</param>
    public UnauthorizedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
