# Student Management API

A simple ASP.NET Core Web API for managing student data, built as part of my C# learning journey.

## How I've implemented CQRS & Mediator

- Commands and Queries are separated into their own folders and classes.
- Each Command/Query has a corresponding Handler that processes the request.
- MediatR is used to dispatch requests from controllers to the appropriate handler.

## Setup

1. Restore dependencies: `dotnet restore`
2. Build the project: `dotnet build`
3. Run the API: `dotnet run`

API will be available at:

- HTTP: `http://localhost:5052`
- HTTPS: `https://localhost:7107`

## Documentation

Swagger UI: `https://localhost:7107/swagger`

---
