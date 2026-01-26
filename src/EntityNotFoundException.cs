using System;
using System.Runtime.CompilerServices;

namespace Soenneker.Exceptions.Suite;

public sealed class EntityNotFoundException : Exception
{
    public EntityNotFoundException(string message)
        : base(message)
    {
    }

    public EntityNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Preferred ctor (use nameof()).
    /// </summary>
    public EntityNotFoundException(string name, object? key)
        : base(CreateMessage(name, key))
    {
    }

    /// <summary>
    /// For when the type is only known at runtime.
    /// </summary>
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
