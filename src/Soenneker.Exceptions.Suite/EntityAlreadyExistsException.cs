using System;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Indicates that an operation cannot create an entity because it already exists.
/// </summary>
public sealed class EntityAlreadyExistsException : Exception
{
    /// <summary>Initializes the exception with the default message.</summary>
    public EntityAlreadyExistsException()
    {
    }

    /// <summary>Initializes the exception with a message.</summary>
    /// <param name="message">Description of the conflict.</param>
    public EntityAlreadyExistsException(string message) : base(message)
    {
    }

    /// <summary>Initializes the exception with a message and the exception that caused it.</summary>
    /// <param name="message">Description of the conflict.</param>
    /// <param name="inner">The underlying exception.</param>
    public EntityAlreadyExistsException(string message, Exception inner) : base(message, inner)
    {
    }
}
