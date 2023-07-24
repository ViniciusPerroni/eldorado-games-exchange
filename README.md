# GamesExchange

## Sobre

Foi desenvolvida uma solução utilizando ASP.NET MVC e EF Core com code first.
A solução é dividida em 3 camadas, Bussines, Infrastructure, Interface.

## Run

Para rodar o projeto primeiro precisa rodar o container do banco de dados:

    docker build -t sql-server-container .
    docker run -p 1433:1433 -d sql-server-container

Após executar o projeto pelo Visual Studio(src/GamesExchange/GamesExchange.sln)
E acessar com os dados de acesso do usuário padrão:

**Username**: admin
**Senha**: 123456