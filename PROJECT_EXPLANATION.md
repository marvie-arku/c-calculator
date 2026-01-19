# Calculator Project - Technical Explanation

## Overview
I built a full-stack calculator application using C# ASP.NET Core Web API for the backend and a modern HTML/CSS/JavaScript frontend. The application performs basic arithmetic operations (add, subtract, multiply, divide) with calculations handled on both the client-side UI and the backend API.

## Architecture

### Backend (ASP.NET Core Web API)
- **Framework**: .NET 10.0
- **Pattern**: RESTful API with Service Layer pattern
- **Dependency Injection**: Used for service management

### Frontend
- **Technology**: Vanilla HTML, CSS, and JavaScript
- **Communication**: REST API calls using Fetch API
- **Styling**: Modern CSS with gradient backgrounds and responsive design

## Project Structure

```
Calculator/
├── Calculator.API/
│   ├── Controllers/
│   │   └── CalculatorController.cs    # API endpoints
│   ├── Services/
│   │   ├── ICalculatorService.cs      # Service interface
│   │   └── CalculatorService.cs       # Business logic
│   ├── wwwroot/
│   │   └── index.html                 # Frontend UI
│   ├── Program.cs                      # Application configuration
│   └── Calculator.API.csproj          # Project file
└── Calculator.sln                      # Solution file
```

## Key Components

### 1. CalculatorService (Backend Logic)
- **Location**: `Calculator.API/Services/CalculatorService.cs`
- **Purpose**: Contains the core calculation logic
- **Methods**:
  - `Add(double a, double b)` - Addition
  - `Subtract(double a, double b)` - Subtraction
  - `Multiply(double a, double b)` - Multiplication
  - `Divide(double a, double b)` - Division with zero-division protection

### 2. CalculatorController (API Endpoints)
- **Location**: `Calculator.API/Controllers/CalculatorController.cs`
- **Purpose**: Exposes REST API endpoints for calculator operations
- **Endpoints**:
  - `POST /api/calculator/add`
  - `POST /api/calculator/subtract`
  - `POST /api/calculator/multiply`
  - `POST /api/calculator/divide`
- **Request Format**: JSON with `{ "a": number, "b": number }`
- **Response Format**: JSON with `{ "result": number }` or `{ "error": "message" }`

### 3. Frontend UI
- **Location**: `Calculator.API/wwwroot/index.html`
- **Features**:
  - Input validation
  - Real-time API communication
  - Error handling and display
  - Loading states
  - Responsive design

## How It Works

### Request Flow
1. User enters two numbers in the frontend
2. User clicks an operation button (Add, Subtract, Multiply, Divide)
3. JavaScript validates inputs and sends POST request to API
4. API Controller receives request and calls CalculatorService
5. CalculatorService performs the calculation
6. Result is returned to Controller
7. Controller sends JSON response back to frontend
8. Frontend displays result in the display area

### Error Handling
- **Division by Zero**: Backend throws `DivideByZeroException`, caught and returned as error response
- **Invalid Input**: Frontend validates before sending request
- **Network Errors**: Frontend catches fetch errors and displays user-friendly messages

## Technical Decisions

1. **Service Layer Pattern**: Separated business logic (CalculatorService) from API layer (Controller) for better testability and maintainability
2. **Dependency Injection**: Used ASP.NET Core's built-in DI to inject CalculatorService into Controller
3. **CORS Configuration**: Enabled CORS to allow frontend to communicate with API
4. **Static File Serving**: Configured to serve the HTML frontend from wwwroot folder
5. **Middleware Order**: Properly ordered middleware (DefaultFiles → StaticFiles → Authorization → Controllers)

## Features Implemented

✅ Basic arithmetic operations (Add, Subtract, Multiply, Divide)
✅ Backend API with RESTful endpoints
✅ Frontend UI with modern design
✅ Input validation
✅ Error handling (division by zero, invalid inputs, network errors)
✅ Loading states during API calls
✅ Responsive design
✅ CORS support for cross-origin requests

## Running the Application

1. Navigate to project directory: `cd Calculator.API`
2. Restore dependencies: `dotnet restore`
3. Run application: `dotnet run`
4. Access in browser: `http://localhost:5000` or `https://localhost:5001`

## Technologies Used

- **Backend**: C# (.NET 10.0), ASP.NET Core Web API
- **Frontend**: HTML5, CSS3, JavaScript (ES6+)
- **Architecture**: RESTful API, Service Layer Pattern
- **Tools**: .NET CLI, Visual Studio Solution

## Future Enhancements (Potential)

- Additional operations (square root, power, etc.)
- Calculation history
- Unit tests for CalculatorService
- Swagger/OpenAPI documentation
- More advanced UI features (keyboard support, history panel)
