FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hackerrank.com/Hackerrank.com.csproj", "Hackerrank.com/"]
RUN dotnet restore "Hackerrank.com/Hackerrank.com.csproj"
COPY . .
WORKDIR "/src/Hackerrank.com"
RUN dotnet build "Hackerrank.com.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hackerrank.com.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hackerrank.com.dll"]
