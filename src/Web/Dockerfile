# Use a Debian-based image with ASP.NET runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Web/LightCleanArchitecture.WebApi.csproj", "src/Web/"]
COPY ["src/Application/LightCleanArchitecture.Application.csproj", "src/Application/"]
COPY ["src/Domain/LightCleanArchitecture.Domain.csproj", "src/Domain/"]
COPY ["src/Infrastructure/LightCleanArchitecture.Infrastructure.csproj", "src/Infrastructure/"]
RUN dotnet restore "./src/Web/./LightCleanArchitecture.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Web"
RUN dotnet build "./LightCleanArchitecture.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./LightCleanArchitecture.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "LightCleanArchitecture.WebApi.dll"]