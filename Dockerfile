#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["API_.NET.csproj", "."]
RUN dotnet restore "./API_.NET.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "API_.NET.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API_.NET.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API_.NET.dll"]