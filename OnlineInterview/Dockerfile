FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OnlineInterview/OnlineInterview.csproj", "OnlineInterview/"]
RUN dotnet restore "OnlineInterview/OnlineInterview.csproj"
COPY . .
WORKDIR "/src/OnlineInterview"
RUN dotnet build "OnlineInterview.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineInterview.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineInterview.dll"]
