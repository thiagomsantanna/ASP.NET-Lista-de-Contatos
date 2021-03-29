USE [PhoneBook]
GO


DECLARE @95 int,@i int
SET @95 = 95
SET @i=1

WHILE @i<@95
BEGIN
    INSERT Clientes(ClienteId) SELECT @i
    SET @i=@i+1
END

SELECT * FROM Clientes
SET IDENTITY_INSERT Clientes OFF;

INSERT INTO `Clientes` (`ClienteId`, `Nome`, `Cpf`, `Email`,`TelefoneCelular`,`TelefoneComercial`, `Endereco`,) VALUES (6,`Juliano`,`999.999.999-99`,`juliano@gmail.com`,`(17) 99999-9999`,`(17) 3333-3333`,`R. Vc Sabe Onde, 123`);

GO

