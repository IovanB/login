#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Login/Login.API.csproj", "Login/"]
COPY ["Login.Application/Login.Application.csproj", "Login.Application/"]
COPY ["Login.Domain/Login.Domain.csproj", "Login.Domain/"]
COPY ["Login.Infrastructure/Login.Infrastructure.csproj", "Login.Infrastructure/"]
RUN dotnet restore "Login/Login.API.csproj"
COPY . .
WORKDIR "/src/Login"
RUN dotnet build "Login.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Login.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Login.API.dll"]