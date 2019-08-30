-- SCRIPT DE CRIÇÃO DO BANCO DE DADOS E TABELAS

-- TABELAS

CREATE TABLE CB_PESSOA(
	NOME VARCHAR(50) NOT NULL,
	CPF VARCHAR(12) NOT NULL,
	SEXO CHAR(1) NOT NULL CHECK (SEXO IN('M', 'F')),
	ID_ENDERECO INT NOT NULL,
)
GO

CREATE TABLE CB_ENDERECO(
	DESCRICAO VARCHAR(50) NOT NULL,
	LOGRADOURO VARCHAR(20) NOT NULL,
	BAIRRO VARCHAR(20) NOT NULL,
	CIDADE VARCHAR(20) NOT NULL
)
GO

-- CHAVES PRIMÁRIAS

ALTER TABLE CB_PESSOA 
ADD ID INT IDENTITY(1,1) PRIMARY KEY
GO

ALTER TABLE CB_ENDERECO
ADD ID INT IDENTITY(1,1) PRIMARY KEY
GO

-- CHAVE ESTRANGEIRA

ALTER TABLE CB_PESSOA ADD CONSTRAINT FK_PESSOA_ENDERECO 
FOREIGN KEY (ID_ENDERECO) REFERENCES CB_ENDERECO (ID)
GO