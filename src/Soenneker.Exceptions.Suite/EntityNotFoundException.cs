using System;
using System.Runtime.CompilerServices;

namespace Soenneker.Exceptions.Suite;

/// <summary>
/// Indicates that a requested entity could not be found.
/// </summary>
public sealed class EntityNotFoundException : Exception
{
    /// <summary>Initializes the exception with a message.</summary>
    /// <param name="message">Description of the missing entity.</param>
    public EntityNotFoundException(string message)
        : base(message)
    {
    }

    /// <summary>Initializes the exception with a message and the exception that caused it.</summary>
    /// <param name="message">Description of the missing entity.</param>
    /// <param name="innerException">The underlying exception.</param>
    public EntityNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>Initializes the exception with an entity name and optional key.</summary>
    /// <param name="name">The entity type or category name.</param>
    /// <param name="key">The missing entity key to include in the message, or <see langword="null"/>.</param>
    public EntityNotFoundException(string name, object? key)
        : base(CreateMessage(name, key))
    {
    }

    /// <summary>Initializes the exception with an entity type and optional key.</summary>
    /// <param name="type">The missing entity type.</param>
    /// <param name="key">The missing entity key to include in the message, or <see langword="null"/>.</param>
    public EntityNotFoundException(Type type, object? key)
        : this(type.FullName ?? type.Name, key)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string CreateMessage(string name, object? key)
    {
        return key is null
            ? $"Entity \"{name}\" was not found."
            : $"Entity \"{name}\" ({key}) was not found.";
    }
}
