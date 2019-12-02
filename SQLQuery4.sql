CREATE TRIGGER [dbo].[PINS]
	ON [dbo].[acoffee]
	INSTEAD OF INSERT
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
			   INSERT INTO acoffee VALUES(@Id,@name,@type,@price)

			   END 
END


