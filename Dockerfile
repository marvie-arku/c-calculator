# Base image with .NET 8 SDK
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

# Copy published app
COPY ./ /app

# Entry point
ENTRYPOINT ["dotnet", "Calculator.API.dll"]
