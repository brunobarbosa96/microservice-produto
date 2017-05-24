IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ListarProduto')
DROP PROCEDURE ListarProduto
GO

CREATE PROCEDURE ListarProduto
AS 
BEGIN 

	/*
		Documenta��o:
		Arquivo: procedures_produto
		Descri��o: Lista produtos
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
		Documenta��o:
		Arquivo: procedures_produto
		Descri��o: Seleciona produto por id
		Autor: Bruno Barbosa
		EXEC SelecionarProduto 1
	*/

	SELECT	id,
			nome,
			preco
		FROM Produto WITH(NOLOCK)
		WHERE id = @id
END 