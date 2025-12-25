# Documentação do Projeto: SalesManager

## 1. Arquitetura Adotada

O sistema foi desenvolvido seguindo os princípios do **DDD (Domain-Driven Design)** e a separação de responsabilidades através de **CQRS (Command Query Responsibility Segregation)**. A solução está organizada em quatro camadas principais:

- **Domain:** Contém as entidades de negócio (`Client`, `Product`, `Sale`), validações de estado (Invariantes) e as interfaces dos repositórios.

- **Application:** Orquestra os casos de uso através de Commands (escrita) e Queries (leitura), garantindo que a UI não manipule entidades de domínio diretamente.

- **Contracts:** Obtem os DTO (Data Transfer Object) e interfaces de repositórios de leitura.

- **Infrastructure:** Implementa a persistência de dados utilizando Entity Framework Core e PostgreSQL, além de gerenciar as configurações do banco via Fluent API.

- **Presentation (WinForms):** Camada de interface com o usuário, responsável apenas pela exibição e captura de dados, consumindo a camada de Application via Injeção de Dependência.

## 2. Decisões Técnicas

- **Entity Framework Core + Npgsql**: Escolhido para agilizar o mapeamento objeto-relacional e garantir a integração nativa com o PostgreSQL.

- **Atomicidade nas Vendas:** A lógica de venda utiliza o método `ExecuteTransactionAsync` no repositório. Isso garante que, se o débito de estoque falhar ou um item for inválido, o `rollback` seja automático, mantendo a integridade dos dados conforme exigido.

- **Validação no Domínio:** As entidades protegem seu próprio estado (ex: `Product.DebitStock` valida estoque antes de subtrair), impedindo que o sistema entre em um estado inconsistente.

**ReportViewer:** Utilizado para a geração de relatórios por sua capacidade de processamento client-side (RDLC), permitindo agrupamentos complexos por cliente e cálculos de totais diretamente no componente.

## 3. Como configurar o banco:
1. Certifique-se de ter o **PostgreSQL (versão 15 ou superior)** instalado.
2. Crie um banco de dados chamado `SalesManagerDb`.
3. No projeto `SalesManager.Presentation.WinForms`, localize o arquivo de configuração `appsettings.json` e atualize a Connection String `DefaultConnection`:
    - `Host=localhost;Database=SalesManagerDb;Username=seu_usuario;Password=sua_senha`
4. Execute as **Migrations** via Terminal no Visual Studio (Package Manager Console):
    ```
    Update-Database -StartupProject SalesManager.Presentation.WinForms -Project SalesManager.Infrastructure
    ```
    Isso criará automaticamente as tabelas, índices e constraints (Unique para e-mail e Check para preço/estoque).
5. Ou copie o script .sql do arquivo `script.sql` dentro do projeto, cole e execute no banco `SalesManagerDb`. 

## 4. Como executar o projeto
1. Abra a solução `SalesManager.sln` no **Visual Studio 2022**.
2. Restaure os pacotes NuGet.
3. Defina o projeto SalesManager.Presentation.WinForms como o projeto de inicialização (Startup Project).
4. Pressione F5 para compilar e rodar a aplicação.

## 5. Diagrama da Arquitetura
![alt text](<Diagrama da arquitetura.png>)

## 6. Tecnoligas e Estrutura de pastas

### Tecnologias usadas:
- C# .NET
- PostgreSql com EntityFramework
- Windows Forms

### Estrutura de pasta de todo o projeto
```
SalesManager.sln (Solution)
│
├── 1 - Presentation
│   └── SalesManager.Presentation.WinForms
│       ├── Forms/ (Clientes, Produtos, Vendas, Relatório)
│       ├── Reports/ (SalesSummary.rdlc)
│       ├── Program.cs (Configuração de DI e Host)
│       └── DataSets/ (SalesDataSet.xsd para o ReportViewer)
│
├── 2 - Application
│   └── SalesManager.Application
│       ├── Commands/ (Client, Product, Sale e Validation)
│       │   └── Handlers/ (Lógica dos processos)
│       ├── Queries/ (Client, Product, Sale)
│       │   └── Handlers/ (Consumindo o IReadRepository)
│       ├── Common/
│       │   ├── Mediator/ (Interfaces IRequest, IRequestHandlers, etc)
│       │   ├── CQRS/ (Interfaces ICommand, IQuery, etc)
│       │   └── Exceptions/ (BusinessException, ValidationException)
│       └── ServiceCollectionExtensions.cs
│
├── 3 - Domain
│   └── SalesManager.Domain
│       ├── Entities/ (Client, Product, Sale, SaleItem)
│       └── Interfaces/
│           └── Repositories/ (IBaseRepository, IClientRepository, etc)
│
├── 4 - Contracts
│   └── SalesManager.Contracts
│       ├── DTOs/ (ClientDto, ProductDto, SaleDto, SalesReportDto)
│       └── Interfaces/
│           └── ReadRepositories/ (IClientReadRepository, ISaleReadRepository)
│
├── 5 - Infrastructure
│   └── SalesManager.Infrastructure
│       └── Data/
│           └── PostgreSql/
│               ├── Context/ (SalesManagerDbContext)
│               ├── Mappings/ (Fluent API - Client, Product, Sale)
│               ├── Migrations/
│               └── Repositories/ (Implementação de Domain e Contracts)
│
└── 6 - Tests
    ├── Unit/
    │   ├── SalesManager.Domain.Unit.Tests
    │   └── SalesManager.Application.Unit.Tests
    └── Integration/
        └── SalesManager.Application.Integration.Tests
```
