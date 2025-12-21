# Этап отладки быстрый режим
FROM ubuntu:noble AS base

# Установка .NET Runtime
RUN apt-get update && apt-get install -y --no-install-recommends \
    aspnetcore-runtime-10.0 \
    ca-certificates \
    libgdiplus \
    wkhtmltopdf \
    libc6-dev \
    libjpeg62 \
    xfonts-75dpi \
    fontconfig
RUN if [ -f /usr/local/lib/libwkhtmltox.so.1 ]; then \
    ln -sf /usr/local/lib/libwkhtmltox.so.1 /usr/lib/libwkhtmltox.so; fi
ARG APP_UID=1654
RUN groupadd --gid $APP_UID appuser && useradd --uid $APP_UID --gid $APP_UID appuser

USER appuser
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ExplanatoryNoteAPI/ExplanatoryNoteAPI.csproj", "ExplanatoryNoteAPI/"]
COPY ["ExplanatoryNoteAPI.Application/ExplanatoryNoteAPI.Application.csproj", "ExplanatoryNoteAPI.Application/"]
COPY ["ExplanatoryNoteAPI.Core/ExplanatoryNoteAPI.Core.csproj", "ExplanatoryNoteAPI.Core/"]
COPY ["ExplanatoryNoteAPI.Database/ExplanatoryNoteAPI.Database.csproj", "ExplanatoryNoteAPI.Database/"]
COPY ["ExplanatoryNoteAPI.Utilities/ExplanatoryNoteAPI.Utilities.csproj", "ExplanatoryNoteAPI.Utilities/"]
RUN dotnet restore "./ExplanatoryNoteAPI/ExplanatoryNoteAPI.csproj"
COPY . .
WORKDIR "/src/ExplanatoryNoteAPI"
RUN dotnet build "./ExplanatoryNoteAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этап публикации
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ExplanatoryNoteAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Финальный этап - рабочая среда
FROM base AS final
WORKDIR /app
COPY ["ExplanatoryNoteAPI/explanatorynote-01-05.xsl", "/"]
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExplanatoryNoteAPI.dll"]
