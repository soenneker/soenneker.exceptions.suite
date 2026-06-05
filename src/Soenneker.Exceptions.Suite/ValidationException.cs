using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Represents the validation exception.
/// </summary>
public sealed class ValidationException : Exception
{
    public ValidationException()
    {
    }

    public ValidationException(string message) : base(message)
    {
    }

    public ValidationException(string message, Exception innerException) : base(message, innerException)
    {
    }
}