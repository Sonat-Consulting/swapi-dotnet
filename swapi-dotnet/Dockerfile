FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

COPY ./bin/Release/net6.0/publish /app

WORKDIR /app
EXPOSE 80

#ENV ASPNETCORE_URLS=http://*:5000

ENTRYPOINT ["dotnet", "swapi-dotnet.dll"]