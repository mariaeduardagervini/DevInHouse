# BASE DA IMAGEM
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Configurar o diretório de trabalho do container.
WORKDIR /app

# Migração dos arquivos da app para a imagem
COPY publisher.csproj .
RUN dotnet restore

# Build
COPY . /app
RUN dotnet publish -c Release -o out

# Camada de Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Configurar o diretório de trabalho do container
WORKDIR /app

# Transferência da build para o ambiente runtime
COPY --from=build /app/out .

# Entrypoint do nosso app
ENTRYPOINT [ "dotnet", "publisher.dll" ]