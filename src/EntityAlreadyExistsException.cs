﻿using System;

namespace Soenneker.Exceptions.Suite;

public sealed class EntityAlreadyExistsException : Exception
{
    public EntityAlreadyExistsException()
    {
    }

    public EntityAlreadyExistsException(string message) : base(message)
    {
    }

    public EntityAlreadyExistsException(string message, Exception inner) : base(message, inner)
    {
    }
}