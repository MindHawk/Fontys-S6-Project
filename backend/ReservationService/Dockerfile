﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ReservationService/ReservationService.csproj", "ReservationService/"]
RUN dotnet restore "ReservationService/ReservationService.csproj"
COPY . .
WORKDIR "/src/ReservationService"
RUN dotnet build "ReservationService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReservationService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReservationService.dll"]
