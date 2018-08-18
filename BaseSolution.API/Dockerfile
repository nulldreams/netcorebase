FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY BaseSolution.API/BaseSolution.API.csproj BaseSolution.API/
RUN dotnet restore BaseSolution.API/BaseSolution.API.csproj
COPY . .
WORKDIR /src/BaseSolution.API
RUN dotnet build BaseSolution.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish BaseSolution.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BaseSolution.API.dll"]
