# TesteProdutos

TesteProdutos é uma aplicação web simples desenvolvida com .NET 8, que permite cadastrar, editar e consultar produtos. Cada produto tem um nome, uma descrição e um preço.

## Funcionalidades

- **Cadastrar Produto**: Adicione um novo produto com nome, descrição e preço.
- **Editar Produto**: Edite os detalhes de um produto existente.
- **Consultar Produtos**: Veja todos os produtos cadastrados em formato de blocos.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para criação de APIs e aplicações web.
- **Entity Framework Core**: ORM para interagir com o banco de dados.
- **SQLite**: Banco de dados simples e leve para armazenar os produtos.
- **HTML/CSS/Bootstrap/JavaScript**: Para o front-end da aplicação.

## Como Rodar o Projeto

### Pré-requisitos

- **.NET 8 SDK**: Para rodar a aplicação no seu ambiente local.
- **Visual Studio** ou **VS Code**: Ferramentas recomendadas para desenvolvimento.

### Passos para Rodar

1. Clone o repositório para sua máquina local:

   ```bash
   git clone https://github.com/netovski/TesteProdutos.git
   ```
2. Abra a solução no Visual Studio ou no VS Code:

Se você estiver usando o Visual Studio, basta abrir a pasta do projeto. No VS Code, use:

  ```bash
  code .
  ```
3. Restaure as dependências:

Antes de rodar o projeto, restaure as dependências necessárias:

  ```bash
  dotnet restore
  ```
4. Aplicar as migrações do banco de dados:

O projeto utiliza Entity Framework Core para persistir os produtos. A primeira vez que você rodar o projeto, você precisa aplicar as migrações ao banco de dados:

  ```bash
  dotnet ef database update
  ```
5. Rodar a aplicação:

Agora você pode rodar a aplicação:

  ```bash
  dotnet run
  ```
O aplicativo estará disponível no seu navegador em http://localhost:5000.

## Como Usar

1. **Cadastrar Produto:**

Acesse a página "Novo Produto" e insira o nome, a descrição e o preço do produto. Clique em "Salvar" para cadastrar o produto.

2. **Editar Produto:**

Acesse a lista de produtos e clique em "Editar" ao lado do produto que você deseja modificar. Alterar os detalhes e salvar as alterações.

3. **Consultar Produtos:**

Na página principal, você verá uma lista com todos os produtos cadastrados, incluindo nome, descrição e preço. Você pode editar qualquer produto a partir dessa lista.

## Estrutura de Pastas

Controllers/: Contém os controladores da aplicação que gerenciam a lógica de negócios.

Data/: Contém a configuração do banco de dados e o contexto do Entity Framework.

Models/: Contém as classes que representam os dados da aplicação, como o produto.

Views/: Contém os arquivos de interface do usuário (HTML e Razor Pages).

wwwroot/: Contém arquivos estáticos, como imagens e arquivos CSS/JS.

