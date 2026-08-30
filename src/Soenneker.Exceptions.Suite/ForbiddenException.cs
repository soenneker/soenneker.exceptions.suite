using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Indicates that an authenticated caller is not allowed to perform an operation.
/// </summary>
public sealed class ForbiddenException : Exception
{
    /// <summary>Initializes the exception with the default message.</summary>
    public ForbiddenException()
    {
    }

    /// <summary>Initializes the exception with a message.</summary>
    /// <param name="message">Description of the denied operation.</param>
    public ForbiddenException(string message) : base(message)
    {
    }

    /// <summary>Initializes the exception with a message and the exception that caused it.</summary>
    /// <param name="message">Description of the denied operation.</param>
    /// <param name="innerException">The underlying exception.</param>
    public ForbiddenException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
