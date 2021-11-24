FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build-env
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY FiapChallange.Lunai.WebApp/*.csproj ./FiapChallange.Lunai.WebApp/
COPY FiapChallange.Lunai.Service/*.csproj ./FiapChallange.Lunai.Service/
COPY FiapChallange.Lunai.InfraData/*.csproj ./FiapChallange.Lunai.InfraData/
COPY FiapChallange.Lunai.Domain/*.csproj ./FiapChallange.Lunai.Domain/

RUN dotnet restore ./FiapChallange.Lunai.WebApp/FiapChallange.Lunai.csproj

# Build da aplicacao
COPY . ./
RUN dotnet build -c Release -o out ./FiapChallange.Lunai.WebApp/FiapChallange.Lunai.csproj

# Build da imagem
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "FiapChallange.Lunai.WebApp.dll"] 