IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ListarProduto')
DROP PROCEDURE ListarProduto
GO

CREATE PROCEDURE ListarProduto
AS 
BEGIN 

	/*
		Documentação:
		Arquivo: procedures_produto
		Descrição: Lista produtos
		Autor: Bruno Barbosa
		EXEC ListarProduto
	*/

	SELECT	id,
			nome,
			preco
		FROM Produto WITH(NOLOCK)

END 
GO 

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SelecionarProduto')
DROP PROCEDURE SelecionarProduto
GO

CREATE PROCEDURE SelecionarProduto
	@id int
AS 
BEGIN 

	/*
		Documentação:
		Arquivo: procedures_produto
		Descrição: Seleciona produto por id
		Autor: Bruno Barbosa
		EXEC SelecionarProduto 1
	*/

	SELECT	id,
			nome,
			preco
		FROM Produto WITH(NOLOCK)
		WHERE id = @id
END 