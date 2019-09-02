Repositório para demonstração de projeto da disciplina de Arquitetura de Software - INF/UFG

Cadastro Básico
Montagem do Ambiente de Desenvolvimento

1 - Objetivo
O Objetivo deste documento é fornecer um passo-a-passo para a montagem do ambiente
de desenvolvimento.

2 - Passos

2.1 - Baixar e instalar as ferramentas de desenvolvimento:

- Visual Studio 2019 (Comunity) :
- https://visualstudio.microsoft.com/vs/

- SQL Server 2017 (Developer) :
https://www.microsoft.com/pt-br/sql-server/sql-server-downloads

- SQL Server Management Studio 18 :
- https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017

2.2 - Baixar o repositório do projeto no GitHub:

- Repositório : 
https://github.com/tmarco783/MT.CadastroBasico

2.3 - Criar o banco de dados e definir as tabelas:

- Abra o SQL Server Management Studio e crie um novo banco chamado
“CadastroBasico”.

- Com o banco “CadastroBasico” selecionado, abra o script de criação das tabelas
disponível em: “Projeto > Banco > SQL Server” e tecle F5 para executá-lo.

2.4 - Abrir o projeto utilizando o Visual Studio 2019:

- Com o arquivo do projeto descompactado, abra a pasta do projeto e navegue para
“Codigo > MT.CadastroBasico” e execute o arquivo “MT.CadastroBasico.sln”.

- Após isso, procure pela classe “ConstantesBD” e altere a constante
“STRING_DE_CONEXAO” para o valor correspondente à string de conexão da
instância do SQL Server instalada em sua máquina.
( Exemplo: @"Server=<MeuServidor\MinhaInstancia>;Database=<CadastroBasico>;User Id=<usuario> ;Password=<senha>").
  
- Salve o projeto.

- Execute o projeto teclando F5.
