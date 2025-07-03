using System;

namespace Soenneker.Exceptions.Suite;

public sealed class EntityNotFoundException : Exception
{
    public override string Message { get; }

    public EntityNotFoundException(string message)
    {
        Message = message;
    }

    public EntityNotFoundException(string message, Exception innerException) : base(message, innerException)
    {
        Message = message;
    }

    /// <summary>
    /// This is the preferred method, with nameof() for types.
    /// </summary>
    public EntityNotFoundException(string name, object? key)
    {
        if (key == null)
            Message = $"Entity \"{name}\" was not found.";
        else
            Message = $"Entity \"{name}\" ({key}) was not found.";
    }

    /// <summary>
    /// Not the preferred ctor! This is used when the type is unknown until runtime
    /// </summary>
    public EntityNotFoundException(Type type, object? key) : this(type.ToString(), key)
    {
    }
}