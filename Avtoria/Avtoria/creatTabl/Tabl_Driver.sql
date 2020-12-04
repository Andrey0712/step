IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Driver]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE Driver (
Id INT NOT NULL IDENTITY PRIMARY KEY ,
Name NVARCHAR(MAX) NOT NULL CHECK(LEN(Name)>0),
Address NVARCHAR(MAX) NOT NULL CHECK(LEN(Address) > 0)
)'