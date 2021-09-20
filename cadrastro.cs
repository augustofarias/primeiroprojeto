USE [Cadastro]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nchar](100) NULL,
	[endereco] [nchar](200) NULL,
	[celular] [nchar](15) NULL,
	[telefone] [nchar](15) NULL,
	[email] [nchar](100) NULL,
 CONSTRAINT [PK_Contatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, 
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO