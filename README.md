# Simple Calculator

A simple calculator application built with C# ASP.NET Core Web API and a modern HTML/JavaScript frontend.

## Features

- **Backend API**: RESTful API with endpoints for basic arithmetic operations
- **Frontend UI**: Beautiful, responsive calculator interface
- **Operations**: Add, Subtract, Multiply, and Divide

## Project Structure

```
Calculator/
├── Calculator.API/
│   ├── Controllers/
│   │   └── CalculatorController.cs
│   ├── Services/
│   │   ├── ICalculatorService.cs
│   │   └── CalculatorService.cs
│   ├── wwwroot/
│   │   └── index.html
│   ├── Program.cs
│   └── Calculator.API.csproj
└── Calculator.sln
```

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later

### Running the Application

1. Navigate to the Calculator.API directory:
   ```bash
   cd Calculator.API
   ```

2. Restore dependencies and run the application:
   ```bash
   dotnet restore
   dotnet run
   ```

3. Open your browser and navigate to:
   ```
   http://localhost:5000
   ```
   or
   ```
   https://localhost:5001
   ```

### API Endpoints

The calculator API provides the following endpoints:

- `POST /api/calculator/add` - Add two numbers
- `POST /api/calculator/subtract` - Subtract two numbers
- `POST /api/calculator/multiply` - Multiply two numbers
- `POST /api/calculator/divide` - Divide two numbers

All endpoints accept a JSON body:
```json
{
  "a": 10,
  "b": 5
}
```

And return:
```json
{
  "result": 15
}
```

## Development

This project uses:
- ASP.NET Core 8.0
- Dependency Injection for service management
- CORS enabled for frontend communication
- Static file serving for the HTML frontend
