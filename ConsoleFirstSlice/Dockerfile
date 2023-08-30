FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ConsoleFirstSlice/ConsoleFirstSlice.csproj", "ConsoleFirstSlice/"]
RUN dotnet restore "ConsoleFirstSlice/ConsoleFirstSlice.csproj"
COPY . .
WORKDIR "/src/ConsoleFirstSlice"
RUN dotnet build "ConsoleFirstSlice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleFirstSlice.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleFirstSlice.dll"]
