FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ConsoleAllSteps/ConsoleAllSteps.csproj", "ConsoleAllSteps/"]
RUN dotnet restore "ConsoleAllSteps/ConsoleAllSteps.csproj"
COPY . .
WORKDIR "/src/ConsoleAllSteps"
RUN dotnet build "ConsoleAllSteps.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleAllSteps.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleAllSteps.dll"]
