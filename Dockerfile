# Usar la imagen base de .NET 9 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Setear el directorio de trabajo
WORKDIR /src

# Copiar los archivos del proyecto
COPY ["UserApi/UserApi.csproj", "UserApi/"]

# Restaurar las dependencias
RUN dotnet restore "UserApi/UserApi.csproj"

# Copiar el resto del código fuente
COPY . .

# Publicar la aplicación
RUN dotnet publish "UserApi/UserApi.csproj" -c Release -o /app/publish

# Crear la imagen final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
COPY --from=build /app/publish .

# Exponer el puerto de la aplicación
EXPOSE 80

# Ejecutar la aplicación
ENTRYPOINT ["dotnet", "UserApi.dll"]

