# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

# Этот этап используется при запуске из VS в быстром режиме (по умолчанию для конфигурации отладки)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Этот этап используется для сборки проекта службы
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

# Этот этап используется для публикации проекта службы, который будет скопирован на последний этап
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ExplanatoryNoteAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false



# Этот этап используется в рабочей среде или при запуске из VS в обычном режиме (по умолчанию, когда конфигурация отладки не используется)
FROM base AS final
WORKDIR /app
RUN apt-get update
RUN apt-get install -y libgdiplus wkhtmltopdf
RUN apt-get install -y libc6-dev libjpeg62 xfonts-75dpi
RUN ln -s /usr/lib/libgdiplus.so /lib/x86_64-linux-gnu/libgdiplus.so

# Проверка расположения библиотек wkhtmltopdf и создание ссылок
RUN ldconfig
RUN if [ -f /usr/local/lib/libwkhtmltox.so ]; then ln -s /usr/local/lib/libwkhtmltox.so /usr/lib/libwkhtmltox.so; fi

RUN apt-get clean && rm -rf /var/lib/apt/lists/*
COPY ["ExplanatoryNoteAPI/explanatorynote-01-05.xsl", "/"]
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExplanatoryNoteAPI.dll"]