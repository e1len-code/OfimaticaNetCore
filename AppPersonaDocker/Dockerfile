#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AppPersonaDocker/AppPersonaDocker.csproj", "AppPersonaDocker/"]
RUN dotnet restore "AppPersonaDocker/AppPersonaDocker.csproj"
COPY . .
WORKDIR "/src/AppPersonaDocker"
RUN dotnet build "AppPersonaDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppPersonaDocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppPersonaDocker.dll"]