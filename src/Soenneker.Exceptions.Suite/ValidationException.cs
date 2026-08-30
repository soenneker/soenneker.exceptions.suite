using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Indicates that supplied data failed application validation.
/// </summary>
public sealed class ValidationException : Exception
{
    /// <summary>Initializes the exception with the default message.</summary>
    public ValidationException()
    {
    }

    /// <summary>Initializes the exception with a message.</summary>
    /// <param name="message">Description of the validation failure.</param>
    public ValidationException(string message) : base(message)
    {
    }

    /// <summary>Initializes the exception with a message and the exception that caused it.</summary>
    /// <param name="message">Description of the validation failure.</param>
    /// <param name="innerException">The underlying exception.</param>
    public ValidationException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
