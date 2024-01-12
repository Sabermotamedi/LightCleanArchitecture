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

# Install additional dependencies, including libgssapi_krb5.so.2
RUN apt-get update && apt-get install -y \
    libgssapi-krb5-3

# Copy the library into the application directory
COPY --from=base /usr/lib/x86_64-linux-gnu/libgssapi_krb5.so.2 /app

# Set the library path to include the application directory
ENV LD_LIBRARY_PATH=/app

ENTRYPOINT ["dotnet", "LightCleanArchitecture.WebApi.dll"]
