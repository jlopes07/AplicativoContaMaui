# Aplicativo de Controle de Transações Financeiras (.NET MAUI)
===========================================================

Este projeto é um aplicativo multiplataforma desenvolvido com .NET MAUI para controle de transações financeiras, permitindo registrar, listar e categorizar entradas e saídas.

## Funcionalidades
---------------
- Registrar transações: Adicione novas transações informando descrição, valor, tipo (entrada/saída) e categoria.
- Listar transações: Visualize todas as transações cadastradas.
- Validação de dados: Garante que apenas tipos válidos de transação sejam aceitos.
- Testes unitários: Cobertura de testes para os principais fluxos de negócio.

## Estrutura do Projeto
--------------------
- Entities/Transacao.cs: Entidade principal de transação.
- ValueObject/Descricao.cs: Value Object para descrição da transação.
- Enums/TipoTransacao.cs: Enum para tipos de transação (Entrada/Saída).
- Service/TransacaoService.cs: Lógica de negócio para manipulação de transações.
- Interfaces/TransacaoRepository.cs: Implementação do repositório em memória.
- Components/Pages/RegistrarTransacao.razor: Página para registrar transações.
- Components/Pages/ListarTransacao.razor: Página para listar transações.
- TestProject1/UnitTest1.cs: Testes unitários utilizando xUnit e Moq.

## Como Executar
-------------
1. Pré-requisitos:
   - .NET 8 SDK
   - Visual Studio 2022 ou superior com suporte ao .NET MAUI

2. Clone o repositório:
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio/MauiApp1

3. Restaure os pacotes e execute o projeto:
   dotnet restore
   dotnet build
   dotnet maui run

4. Executar os testes:
   cd ../TestProject1
   dotnet test

## Testes
------
Os testes estão localizados em TestProject1/UnitTest1.cs e cobrem:
- Registro de transações válidas.
- Validação de tipos de transação inválidos.

## Observações
-----------
- O repositório de transações é implementado em memória para fins de demonstração.
- O projeto utiliza componentes Razor para as páginas.

## Licença
-------
Este projeto está licenciado sob a MIT License.

Desenvolvido com .NET MAUI.
