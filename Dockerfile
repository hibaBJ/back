#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for f>#image de base
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 7091
#Contruction de l'image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AxiaBackend.csproj", "."]
RUN dotnet restore "./AxiaBackend.csproj"
#Install node.js and npm
RUN apt-get update && apt-get install -y curl
RUN curl -sL https://deb.nodesource.com/setup_16.x |bash -
Run apt-get install -y nodejs

COPY . .
WORKDIR "/src/."
RUN dotnet build "AxiaBackend.csproj" -c Release -o /app/build
#publication de l'application
FROM build AS publish
RUN dotnet publish "AxiaBackend.csproj" -c Release -o /app/publish /p:UseAppHost=false
#copie des fichiers publi�s dans l'image de base
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443
EXPOSE 7091
ENTRYPOINT ["dotnet", "AxiaBackend.dll"]
