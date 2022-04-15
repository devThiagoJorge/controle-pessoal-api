#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["controle-pessoal-api/controle-pessoal-api.csproj", "controle-pessoal-api/"]
RUN dotnet restore "controle-pessoal-api/controle-pessoal-api.csproj"
COPY . .
WORKDIR "/src/controle-pessoal-api"
RUN dotnet build "controle-pessoal-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "controle-pessoal-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "controle-pessoal-api.dll"]