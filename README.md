# Hello World Microservice

A simple .NET microservice template with a Hello World API endpoint.

## Features

- Minimal .NET Web API
- Dynamic greeting endpoint with personalized responses
- Variety of random greetings (Hello, Hi, Hey, Greetings, Welcome, Howdy, Good day)
- OpenAPI documentation support
- .NET 10.0 target framework

## Getting Started

### Prerequisites

- .NET SDK 10.0 or later

### Running the API

1. Navigate to the HelloWorldApi directory:
   ```bash
   cd HelloWorldApi
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. The API will be available at `https://localhost:7253` (or `http://localhost:5185`)

### Endpoints

- **GET /hello?name={name}** - Returns a dynamic greeting
  - **Query Parameters:**
    - `name` (optional): The name to greet. If not provided, defaults to "World"
  - **Example:** `/hello?name=John` returns a random greeting like "Hi, John!" or "Welcome, John!"
- **GET /openapi/v1.json** - OpenAPI specification (available in development mode)

### Testing the API

You can test the Hello World endpoint using curl:

```bash
# Default greeting
curl http://localhost:5185/hello

# Personalized greeting
curl "http://localhost:5185/hello?name=John"
```

Expected responses (greetings vary randomly):
```
Hello, World!
Hi, John!
Welcome, John!
```

### Building the Project

```bash
cd HelloWorldApi
dotnet build
```

## Project Structure

```
HelloWorldApi/
├── Program.cs              # Main application entry point with API endpoints
├── HelloWorldApi.csproj    # Project configuration
├── appsettings.json        # Application settings
└── appsettings.Development.json  # Development-specific settings
```
