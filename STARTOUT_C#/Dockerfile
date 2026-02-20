# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["STARTOUT_C#/STARTOUT_C#.csproj", "STARTOUT_C#/"]
RUN dotnet restore "./STARTOUT_C#/STARTOUT_C#.csproj"
COPY . .
WORKDIR "/src/STARTOUT_C#"
RUN dotnet build "./STARTOUT_C#.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./STARTOUT_C#.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "STARTOUT_C#.dll"]

# DEVELOPMENT - INTERACTIVE MODE
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
# Use ENTRYPOINT with interactive support for console input
#ENTRYPOINT ["dotnet", "STARTOUT_C#.dll"]
# Note: Run with 'docker run -it' to enable interactive console input