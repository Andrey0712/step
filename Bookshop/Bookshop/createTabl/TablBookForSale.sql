IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[BookForSale]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE BookForSale (
Id INT NOT NULL  PRIMARY KEY,
CONSTRAINT FK_BookForSale_Id FOREIGN KEY (Id)  REFERENCES BOOK (Id),
Prise MONEY NOT NULL CHECK(LEN(Prise)>0) DEFAULT 0,
Publish DATE NOT NULL CHECK(Publish< GetDate()) ,
Amount INT NOT NULL CHECK(Amount >= 0)
)'