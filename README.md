[![](https://img.shields.io/nuget/v/Soenneker.Exceptions.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Exceptions.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.exceptions.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.exceptions.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Exceptions.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Exceptions.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.exceptions.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.exceptions.suite/actions/workflows/codeql.yml)

# Soenneker.Exceptions.Suite

A small set of application-layer exception types for entity conflicts, missing entities, authentication, authorization, and validation failures.

## Install

```bash
dotnet add package Soenneker.Exceptions.Suite
```

## Exception types

| Exception | Intended condition | Common HTTP mapping |
| --- | --- | ---: |
| `EntityAlreadyExistsException` | Creation conflicts with an existing entity | `409 Conflict` |
| `EntityNotFoundException` | A requested entity does not exist | `404 Not Found` |
| `UnauthorizedException` | Authentication is missing or failed | `401 Unauthorized` |
| `ForbiddenException` | An authenticated caller lacks permission | `403 Forbidden` |
| `ValidationException` | Supplied data fails application validation | `400 Bad Request` |

The HTTP statuses are suggested application mappings. Throwing one of these exceptions does not create an HTTP response, log the error, roll back work, or register middleware.

## Usage

```csharp
using Soenneker.Exceptions.Suite;

if (await repository.Exists(id))
    throw new EntityAlreadyExistsException($"Widget '{id}' already exists.");

Widget? widget = await repository.Find(id);

if (widget is null)
    throw new EntityNotFoundException(typeof(Widget), id);
```

Map exceptions at the application boundary rather than catching and translating them throughout domain code. For example, ASP.NET Core middleware or an exception handler can translate known types to `ProblemDetails`, while unexpected exceptions remain server errors.

`EntityNotFoundException` has constructors that build a message from an entity name/type and optional key:

```csharp
throw new EntityNotFoundException("Widget", "widget-123");
// Entity "Widget" (widget-123) was not found.
```

The key is included in `Message` through `ToString()`. Do not pass secrets or sensitive identifiers if exception messages may be logged or returned to clients. In general, expose stable client-safe problem details and keep internal exception messages out of production responses.

`ValidationException` carries only the standard exception message and inner exception; it does not provide a structured field-error collection. Its name can conflict with validation exceptions from other namespaces, so use a namespace alias or the fully qualified name when both are referenced.
