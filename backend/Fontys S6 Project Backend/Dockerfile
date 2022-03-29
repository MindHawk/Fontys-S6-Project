FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Fontys S6 Project Backend.csproj", "Fontys S6 Project Backend/"]
WORKDIR "/src/Fontys S6 Project Backend"
RUN dotnet restore "Fontys S6 Project Backend.csproj"
COPY . .
RUN dotnet build "Fontys S6 Project Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fontys S6 Project Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fontys S6 Project Backend.dll"]
