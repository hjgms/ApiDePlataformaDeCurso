# API .NET 10 com Swagger

Este projeto é uma API construída em **.NET 10** com documentação
interativa usando **Swagger**.\

------------------------------------------------------------------------

## Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

-   **.NET SDK 10**
-   **Git** (opcional, caso vá clonar o repositório)
-   Editor recomendado: **Visual Studio Code** ou **Visual Studio 2022**

Para verificar a versão instalada do .NET:

``` bash
dotnet --version
```

------------------------------------------------------------------------

## Clonando o projeto

``` bash
git clone https://github.com/hjgms/ApiDePlataformaDeCurso.git
cd ApiDePlataformaDeCurso
```

------------------------------------------------------------------------

## Rodando o projeto

Execute o seguinte comando na raiz do projeto:

``` bash
dotnet run
```

Ou, se preferir compilar antes:

``` bash
dotnet build
dotnet run
```

A API iniciará normalmente em:

-   http://localhost:5177

*(As portas podem variar dependendo do arquivo `launchSettings.json`.)*

------------------------------------------------------------------------

## Acessando o Swagger

Após rodar o projeto, acesse a documentação da API:

    https://localhost:7000/swagger

ou

    http://localhost:5000/swagger

A interface do Swagger permitirá visualizar endpoints, enviar
requisições e explorar os modelos da API.

------------------------------------------------------------------------

## Tecnologias Utilizadas

-   .NET 10
-   ASP.NET Core
-   Swagger
-   C#

------------------------------------------------------------------------
