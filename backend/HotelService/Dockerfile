FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HotelService/HotelService.csproj", "HotelService/"]
COPY ["HotelModels/HotelModels.csproj", "HotelModels/"]
COPY ["HotelServiceDAL/HotelServiceDAL.csproj", "HotelServiceDAL/"]
COPY ["HotelServiceLogic/HotelServiceLogic.csproj", "HotelServiceLogic/"]
WORKDIR "/src/HotelService"
RUN dotnet restore "HotelService.csproj"
WORKDIR /src
COPY "./HotelService" "HotelService"
COPY "./HotelModels" "HotelModels"
COPY "./HotelServiceDAL" "HotelServiceDAL"
COPY "./HotelServiceLogic" "HotelServiceLogic"
WORKDIR "/src/HotelService"
RUN dotnet build "HotelService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotelService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotelService.dll"]
