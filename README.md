# Student Management API

A simple ASP.NET Core Web API for managing students, built for learning purposes.

## Key Features

- Implements CQRS (Command Query Responsibility Segregation):
  - Write operations (Create, Update, Delete) are handled by Commands and their Handlers.
  - Read operations (Get, GetAll) are handled by Queries and their Handlers.
- Uses the Mediator pattern via MediatR to decouple controllers from business logic.
- All data is stored in-memory for simplicity.

## How CQRS and Mediator Are Used

- Commands and Queries are separated into their own folders and classes.
- Each Command/Query has a corresponding Handler that processes the request.
- MediatR is used to dispatch requests from controllers to the appropriate handler.

## Getting Started

1. Restore dependencies: `dotnet restore`
2. Build the project: `dotnet build`
3. Run the API: `dotnet run`

API will be available at:
- HTTP: `http://localhost:5052`
- HTTPS: `https://localhost:7107`

Swagger UI: `https://localhost:7107/swagger`

---

This project is for educational purposes.
