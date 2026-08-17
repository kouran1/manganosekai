# Mangá no Sekai — Sistema Desktop

Sistema desktop desenvolvido por **Ruan Sousa** como parte do projeto de conclusão do curso **Técnico em TI**.

O aplicativo foi criado em C# com Windows Forms para administrar a loja Mangá no Sekai. Ele compartilha o mesmo banco de dados MySQL utilizado pela [plataforma web](https://github.com/kouran1/manga-no-sekai), mantendo os cadastros, o estoque e as vendas integrados entre os dois sistemas.

## Funcionalidades

- autenticação com níveis de acesso comum e administrador;
- cadastro e consulta de produtos, autores, editoras e categorias;
- gerenciamento de clientes, funcionários e cargos;
- controle de estoque;
- registro de vendas com diferentes formas de pagamento;
- cálculo de valores, descontos e troco;
- relatórios de clientes, funcionários, produtos e vendas;
- consulta de endereço por CEP;
- integração com o mesmo banco de dados da loja virtual.

## Tecnologias

- C#
- Windows Forms
- .NET Framework 4.7.2
- MySQL / MariaDB
- MySql.Data
- Microsoft ReportViewer
- Newtonsoft.Json
- API ViaCEP

## Arquitetura do projeto

```text
manganosekai/
├── class*.cs            regras de negócio e acesso a dados
├── fmc*.cs              telas de cadastro e menu principal
├── fmcons*.cs           telas de consulta
├── formRel*.cs          relatórios do sistema
├── formVenda52.cs       fluxo de vendas
├── login.cs             autenticação
├── Program.cs           ponto de entrada
└── manganosekai.csproj  configuração do projeto
```

## Como executar

### Requisitos

- Windows;
- Visual Studio com a carga de trabalho **Desenvolvimento para desktop com .NET**;
- .NET Framework 4.7.2 Developer Pack;
- MySQL ou MariaDB;
- XAMPP opcional para executar o banco e a aplicação web em conjunto.

### Configuração

1. Clone este repositório:

   ```bash
   git clone https://github.com/kouran1/manganosekai.git
   ```

2. Importe o banco demonstrativo disponibilizado no repositório da aplicação web, nesta ordem:

   1. [`database/schema.sql`](https://github.com/kouran1/manga-no-sekai/blob/main/database/schema.sql)
   2. [`database/sample-data.sql`](https://github.com/kouran1/manga-no-sekai/blob/main/database/sample-data.sql)
   3. [`database/demo-user.sql`](https://github.com/kouran1/manga-no-sekai/blob/main/database/demo-user.sql)

3. Confira a conexão local em `manganosekai/classConexao.cs`. A configuração padrão utiliza:

   ```text
   Servidor: localhost
   Banco: manganosekai
   Usuário: root
   Senha: vazia
   ```

4. Abra `manganosekai.sln` no Visual Studio.
5. Restaure os pacotes NuGet e compile a solução.
6. Execute o projeto.

Credenciais locais de demonstração, quando o banco de exemplo for utilizado:

```text
Usuário: admin.demo
Senha: demo1234
```

> A conta demonstrativa deve ser utilizada somente em ambiente local.

## Projeto web integrado

A interface pública da loja, o catálogo, o carrinho e o painel web estão disponíveis em:

**[github.com/kouran1/manga-no-sekai](https://github.com/kouran1/manga-no-sekai)**

## Observação

Este é um projeto acadêmico e de portfólio. Antes do uso em produção, recomenda-se substituir as consultas SQL montadas por texto por comandos parametrizados, armazenar senhas com hash e mover a configuração do banco para um mecanismo seguro de configuração.

## Autor

Desenvolvido por **Ruan Sousa** como projeto de conclusão do curso Técnico em TI.

