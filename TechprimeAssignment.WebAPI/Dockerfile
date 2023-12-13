FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TruckLotParking.WebAPI/TruckLotParking.WebAPI.csproj", "TruckLotParking.WebAPI/"]
RUN dotnet restore "TruckLotParking.WebAPI/TruckLotParking.WebAPI.csproj"
COPY . .
WORKDIR "/src/TruckLotParking.WebAPI"
RUN dotnet build "TruckLotParking.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TruckLotParking.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TruckLotParking.WebAPI.dll"]
