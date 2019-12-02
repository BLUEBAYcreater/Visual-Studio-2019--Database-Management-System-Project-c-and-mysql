CREATE TRIGGER [dbo].[PINS1]
	ON [dbo].[acoffee]
	INSTEAD OF UPDATE
	AS
	BEGIN
		SET NOCOUNT ON;

		DECLARE  @Id int, @name nvarchar(50),@type nvarchar(50), @price int
		DECLARE @MESSAGE VARCHAR(100)

		SELECT @Id = INSERTED.Id,
		       @name = INSERTED.name,
			   @type = INSERTED.type,
			   @price = INSERTED.price
			   FROM INSERTED

			   IF(@price<0)
			   BEGIN
			   SET @MESSAGE = 'INVALID PRICE'
			   RAISERROR(@MESSAGE,16,1)
			   END
			   ELSE
			   BEGIN
			   UPDATE acoffee SET name=@name,type=@type,price=@price where Id=@Id

			   END 
END



UPDATE acoffee set PRICE=100 WHERE Id=3