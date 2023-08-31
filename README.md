# Gestão de Feedbacks de Clientes com Minimal API e ASP.NET Razor Pages

Este é um projeto de aplicação web desenvolvido com a Minimal API do .NET Core, projetado para permitir a gestão de feedbacks deixados por clientes sobre um serviço ou produto específico. A aplicação oferece funcionalidades completas, incluindo cadastro, consulta, atualização e exclusão de feedbacks. Os dados são armazenados temporariamente em uma coleção em memória.

## Comandos Importantes

Certos comandos são essenciais para configurar e executar este projeto. Certifique-se de executá-los no terminal, na raiz do projeto:

1. **Executar a Aplicação:**
Use `dotnet watch run`
Este comando inicia a aplicação, permitindo que você visualize e interaja com a interface por meio do navegador.

2. **Adicionar Pacotes Necessários:**
Use `dotnet add package Microsoft.EntityFrameworkCore.Sqlite` e `dotnet add package Microsoft.EntityFrameworkCore.Design` para adicionar os pacotes necessários.
Utilize esses comandos para adicionar os pacotes do Entity Framework Core, necessários para a persistência de dados.

3. **Instalar a Ferramenta do Entity Framework:**
Use `dotnet tool install --global dotnet-ef`
Essa ferramenta é fundamental para a criação e gerenciamento de migrações e do banco de dados.

4. **Adicionar Migração Inicial:**
Use `dotnet ef migrations add CreateDatabase`
Esse comando cria uma migração inicial com base no modelo de feedback, preparando o banco de dados para receber os dados.

5. **Atualizar o Banco de Dados:**
Use `dotnet ef database update`
Execute este comando para aplicar a migração ao banco de dados, criando as tabelas necessárias.

## Tema e Descrição

**Tema:** Gestão de Feedbacks de Clientes com Minimal API e ASP.NET Razor Pages

**Descrição:** Este projeto consiste em uma aplicação web que permite aos usuários deixar feedbacks sobre serviços ou produtos específicos. A aplicação utiliza a abordagem minimalista da API do .NET Core e se integra perfeitamente com ASP.NET Razor Pages. Os dados dos feedbacks são armazenados temporariamente em memória.

Cada feedback inclui as seguintes propriedades:

- **IdFeedback:** Número inteiro que identifica exclusivamente cada feedback.
- **NomeCliente:** Nome do cliente que está fornecendo o feedback.
- **EmailCliente:** Endereço de e-mail do cliente (opcional).
- **DataFeedback:** Data e hora em que o feedback foi registrado.
- **Comentário:** O próprio feedback ou comentário detalhado.
- **Avaliação:** Avaliação numérica em uma escala de 1 a 5, onde 1 representa "Muito insatisfeito" e 5 representa "Muito satisfeito".

A aplicação permite que os usuários adicionem seus feedbacks por meio de um formulário simples. Além disso, oferece a funcionalidade de visualização de todos os feedbacks em formato de lista, permitindo também a edição ou exclusão de feedbacks específicos. Isso torna a aplicação uma ferramenta valiosa para a gestão e melhoria contínua da qualidade dos serviços ou produtos oferecidos.
