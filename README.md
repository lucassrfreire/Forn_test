# FORNECEDOR API - Challenge

Projeto dispõe API com Endpoints para manipulação de registros de fornecedores

## O que é?


App Service e Banco de Dados hospedados e gerenciados via Microsoft Azure.

API PUBLICADA está disponível para testes: https://fornecedor-api.azurewebsites.net/api/fornecedor/

```bash
▪ GET /api/fornecedores: Retorna todos os fornecedores.

▪ GET /api/fornecedores/{id}: Retorna um fornecedor específico pelo ID.

▪ POST /api/fornecedores: Adiciona um novo fornecedor.

▪ PUT /api/fornecedores/{id}: Atualiza um fornecedor existente pelo ID.

▪ DELETE /api/fornecedores/{id}: Remove um fornecedor pelo ID
```



## Como utilizar?

- Para teste dos endpoints **publicados** basta fazer a chamada de cada um dos métodos propostos na API publicada ou executar localmente em sua máquina após clonas o repositório.


### Pré-requisitos

- .NET Core SDK
- Visual Studio (ou VS Code) ou outro editor de código

## Configuração
### Configuração da Aplicação
- Clone o repositório.
- Abra o projeto no Visual Studio (ou VS Code).
- Configure o projeto para rodar localmente.

### Configuração do Banco de Dados

- Utilizei o SQL Server como banco de dados.
- Configure a string de conexão no projeto via User Secrets ou no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=fornecedor;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}

```

- Execute o comando para criação inicial da base de dados já com registros para teste inclusos na primeira migration:
`dotnet ef database update`

### Exemplos do padrão de retorno esperado:
```json
{
  "sucesso": true,
  "dados": {
    "id": "0015161f-d1b9-45e5-88c0-9a50874a4a3c",
    "nome": "Octavius Mcneil",
    "email": "mauris@protonmail.edu",
    "ativo": true
  }
}
```
```json
{
  "sucesso": false,
  "erros": "Fornecedor ainda não foi cadastrado!"
}
```


## Métodos Utilizados
- Padrão MVC para estruturação do projeto.
- AutoMapper: para mapeamento de entidades.
- Swagger: descrição e documentação da API Rest.
- Entity Framework Core: acesso ao banco de dados (mapeador relacional de objeto).
- Injeção de Dependência para gerenciamento de dependências.
- Utilização de Guid para IDs de entidades: garantir identificadores únicos e retirar a responsabilidade do banco de dados gerenciar identificadores sequenciais, evitando assim possíveis inconsistências ou concorrências.
- Banco de dados SQL Server
- Microsoft Azure: APP Services + SQL DataBase + SQL Servers (API publicada / testes)
- CI/CD: usando GitHubAction como Build provider.
- Data Seed: Insert de dados fictícios para teste na criação da base de dados 


## License

[MIT](https://choosealicense.com/licenses/mit/)
