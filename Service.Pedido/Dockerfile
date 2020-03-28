#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Service.Pedido/Service.Pedido.csproj", "Service.Pedido/"]
RUN dotnet restore "Service.Pedido/Service.Pedido.csproj"
COPY . .
WORKDIR "/src/Service.Pedido"
RUN dotnet build "Service.Pedido.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Service.Pedido.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Service.Pedido.dll"]