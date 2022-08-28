#build back-end
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-back
WORKDIR /app

ARG src="3rd Sprint/ONGWebAPI"

# Copy csproj and restore as distinct layers
COPY ${src}/ONGWebAPI.csproj ./
RUN dotnet restore
    
# Copy everything else and build
COPY ${src} ./
RUN dotnet publish -c Release -o out

#build front-end
FROM node:lts-alpine AS build-front

# faz da pasta 'app' o diretório atual de trabalho
WORKDIR /app

ARG src="5th Sprint/associacao-das-patinhas-front"

# copia os arquivos 'package.json' e 'package-lock.json' (se disponível)
COPY ${src}/package*.json ./

# instala dependências do projeto
RUN npm install

# copia arquivos e pastas para o diretório atual de trabalho (pasta 'app')
COPY ${src} ./

# compila a aplicação de produção com minificação
RUN npm run build

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS patinhas

WORKDIR /app

COPY --from=build-back /app/out .
COPY --from=build-front /app/dist ./wwwroot

ENV UsarBancoEmMemoria=true

ENTRYPOINT ["dotnet", "ONGWebAPI.dll"]