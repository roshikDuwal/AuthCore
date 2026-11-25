# AuthCore

Reusable identity service: user registration, login and JWT issuing.


## Architecture
Clean Architecture + CQRS (MediatR).
Api → Application → Domain; Persistence and Infrastructure → Application.

## Run locally
    dotnet run --project src/AuthCore.Api
    # GET http://localhost:5267/health → Healthy

## Test
    dotnet test