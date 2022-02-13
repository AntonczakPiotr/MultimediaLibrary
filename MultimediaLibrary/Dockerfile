
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MultimediaLibrary/MultimediaLibrary.csproj", "MultimediaLibrary/"]
RUN dotnet restore "MultimediaLibrary/MultimediaLibrary.csproj"
COPY . .
WORKDIR "/src/MultimediaLibrary"
RUN dotnet build "MultimediaLibrary.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MultimediaLibrary.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MultimediaLibrary.dll"]
