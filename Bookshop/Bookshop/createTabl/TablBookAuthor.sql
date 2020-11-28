IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[BookAuthor]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE BookAuthor (
Id INT NOT NULL IDENTITY PRIMARY KEY,
BookId INT NOT NULL FOREIGN KEY (BookId) REFERENCES Book(Id),
AuthorId INT NOT NULL FOREIGN KEY (AuthorId) REFERENCES Author(Id)
)'