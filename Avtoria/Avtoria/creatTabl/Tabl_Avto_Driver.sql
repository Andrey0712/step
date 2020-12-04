IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Avto_driver]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE Avto_driver (
Id INT NOT NULL IDENTITY PRIMARY KEY,
AvtoId INT NOT NULL FOREIGN KEY (AvtoId) REFERENCES Avto(Id),
DriverId INT NOT NULL FOREIGN KEY (DriverId) REFERENCES Driver(Id)
)'