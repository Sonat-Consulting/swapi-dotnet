FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base

COPY ./bin/Release/net5.0 /app

WORKDIR /app
EXPOSE 80

#ENV ASPNETCORE_URLS=http://*:5000

ENTRYPOINT ["dotnet", "swapi-dotnet.dll"]