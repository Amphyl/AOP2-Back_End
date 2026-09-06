# Sistema de Consultas Médicas 

Aplicação Web desenvolvida em C# utilizando o framework ASP.NET Core MVC para o gerenciamento de usuários e agendamento de consultas. O projeto aplica conceitos fundamentais de persistência de dados, separação de responsabilidades (SoC) e segurança de rotas com autenticação.

## Tecnologias Utilizadas
* **C# / .NET 8**
* **ASP.NET Core MVC** (Model-View-Controller)
* **Entity Framework Core** (Abordagem Code-First)
* **SQL Server Express** (Banco de Dados)
* **HTML/CSS + Bootstrap** (Interface de Usuário)

## Pré-requisitos
Para executar este projeto localmente, certifique-se de ter instalado em sua máquina:
* [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior.
* [SQL Server Express](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) configurado para aceitar conexões locais.

## Configuração e Execução do Banco de Dados
O sistema utiliza o Entity Framework Core para gerenciar as tabelas e relacionamentos de forma automatizada. Siga os passos abaixo para preparar o banco de dados:

1. Abra o terminal na pasta raiz do projeto.
2. Certifique-se de que o pacote de ferramentas globais do EF está instalado (`dotnet tool install --global dotnet-ef`).
3. Crie o banco de dados físico rodando o comando obrigatório de atualização:
   ```bash
   dotnet ef database update
4. Inicie a aplicação com o comando:
   ```bash
   dotnet run

## Demonstração do Sistema
Assista ao vídeo abaixo para ver o sistema em pleno funcionamento. A gravação demonstra o fluxo completo exigido: cadastro de um novo usuário, autenticação no sistema e o CRUD de registro de consultas médicas.

[https://www.youtube.com/watch?v=926C63dZ3m4]

## Desenvolvedores
*Adler Costa
*Gustavo Li
