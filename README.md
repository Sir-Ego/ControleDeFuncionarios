# Controle de Funcionários

Este é um projeto Console Application desenvolvido em C# para o controle de cadastro de funcionários, onde é possível armazenar os dados em um banco de dados SQL Server ou em um arquivo JSON. O projeto foi construído seguindo uma arquitetura em camadas para facilitar a manutenção e a separação de responsabilidades.

## Estrutura do Projeto

O projeto está organizado nas seguintes camadas:

- **Controllers**: Responsável pelo gerenciamento do fluxo da aplicação, conectando as camadas de interface (input/output) e as operações de negócio. Aqui estão os métodos de entrada para criar funcionários.
  
- **Entities**: Contém as classes de domínio que representam os dados e objetos principais do sistema, como a classe `Funcionario`. Essas classes refletem a estrutura dos dados armazenados e são usadas em toda a aplicação.

- **Enums**: Agrupa enumeradores usados para definir constantes no projeto, como tipos de contratação de funcionário e outros identificadores categóricos para facilitar a padronização e a leitura do código.

- **Repositories**: Implementa a persistência dos dados, permitindo que os dados sejam gravados e recuperados do banco de dados SQL Server e do arquivo JSON. A interface `IFuncionarioRepository` é a responsável por essa interação.

- **Validators**: Define regras de validação para garantir a consistência dos dados antes de persistir, utilizando a biblioteca FluentValidator para validações, como campos obrigatórios e formatações.

- **Interfaces**: Contém definições de interfaces para abstrair as operações de repositórios e garantir a flexibilidade de implementação (JSON ou SQL).

## Tecnologias Utilizadas

As bibliotecas e tecnologias utilizadas no projeto são:

- **Dapper**: Biblioteca para mapeamento objeto-relacional (ORM) leve, que facilita a interação com o banco de dados SQL Server de maneira simples e performática.
  - [Documentação do Dapper](https://dapper-tutorial.net/)

- **System.Data.SqlClient**: Biblioteca padrão do .NET para conexão com SQL Server, necessária para a execução de comandos SQL e gerenciamento da conexão com o banco.
  - [Documentação do System.Data.SqlClient](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient)

- **FluentValidator**: Biblioteca para validação de dados de forma fluente, permitindo definir regras de validação diretamente nas entidades ou em classes de validação separadas.
  - [Documentação do FluentValidator](https://github.com/andrebaltieri/Flunt)

## Pré-requisitos

Para executar o projeto, você precisará:

1. **Criar o Banco de Dados**:
   - Configure um banco de dados SQL Server local e execute o script SQL contido no projeto para criar a tabela de funcionários.

2. **Alterar a String de Conexão**:
   - No arquivo `FuncionarioRepositorySql`, localize a string de conexão com o banco de dados e ajuste-a para corresponder às configurações da sua instalação local do SQL Server.

3. **Criar Pasta para Arquivos JSON**:
   - Crie uma pasta `c://temp` no seu sistema. Esta pasta será usada pelo sistema para gravar os arquivos JSON de backup dos dados dos funcionários.

## Executando o Projeto

1. Clone o repositório e abra o projeto no Visual Studio ou em outro editor compatível com C#.
2. Compile e execute o projeto para verificar se a conexão com o banco de dados está funcionando corretamente e se os arquivos JSON estão sendo gerados na pasta especificada.

### Estrutura da Tabela `Funcionario`

O script SQL para criação da tabela `Funcionario` está incluído no projeto. Execute este script no SQL Server local antes de rodar o aplicativo pela primeira vez.

---

Este projeto exemplifica o uso de C# em um Console Application organizado por camadas, com foco em boas práticas de arquitetura e facilidade de manutenção. Para mais informações sobre cada biblioteca, consulte os links de documentação fornecidos acima.
