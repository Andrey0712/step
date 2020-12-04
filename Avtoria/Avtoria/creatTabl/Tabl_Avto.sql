IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblAvto]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE Avto(
Id INT NOT NULL IDENTITY  PRIMARY KEY,
Name NVARCHAR(MAX) NOT NULL CHECK(LEN(Name)>0), 
Namber NVARCHAR(10) NOT NULL CHECK(LEN(Namber)>0)
)'