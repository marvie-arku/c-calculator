# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
EXPOSE 5001

# Copy the compiled application from build stage
COPY --from=build /app/publish .

# Set environment to listen on port 5001
ENV ASPNETCORE_URLS="http://0.0.0.0:5001"

ENTRYPOINT ["dotnet", "Calculator.API.dll"]
