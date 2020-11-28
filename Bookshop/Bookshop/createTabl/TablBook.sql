IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblBOOK]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE BOOK(
Id INT NOT NULL IDENTITY  PRIMARY KEY,
Name NVARCHAR(MAX) NOT NULL CHECK(LEN(Name)>0), 
Description NVARCHAR(MAX) NOT NULL CHECK(LEN(Description)>0)
)'