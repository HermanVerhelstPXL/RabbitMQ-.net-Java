#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Test/Test.API/Test.API.csproj", "Services/Test/Test.API/"]
COPY ["BuildingBlocks/Api/Api.csproj", "BuildingBlocks/Api/"]
COPY ["BuildingBlocks/Domain/Domain.csproj", "BuildingBlocks/Domain/"]
COPY ["BuildingBlocks/Infrastructure/Infrastructure.csproj", "BuildingBlocks/Infrastructure/"]
COPY ["BuildingBlocks/Logic/Logic.csproj", "BuildingBlocks/Logic/"]
RUN dotnet restore "Services/Test/Test.API/Test.API.csproj"
COPY . .
WORKDIR "/src/Services/Test/Test.API"
RUN dotnet build "Test.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Test.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Test.API.dll"]