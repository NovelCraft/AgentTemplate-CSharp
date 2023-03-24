FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

COPY . .
RUN dotnet publish "src/Agent.csproj" -c Release -o build

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS runtime-env
WORKDIR /app

COPY --from=build-env /app/build .

ENTRYPOINT ["/app/Agent"]
