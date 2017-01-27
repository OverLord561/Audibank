USE [BankContext]
GO

INSERT INTO [dbo].[Clients]
           ([SecondName]
           ,[Name]
           ,[SurName]
           ,[PlaceOfJob]
           ,[Position]
           ,[Telephone]
           ,[AmountOfIncome]
           ,[Passport]
           ,[DateOfPassport]
           ,[PassportIssuedBy]
           ,[Identification]
           ,[DateOfBirth]
           ,[Sex])
     VALUES
           ('Petrow',
           'Roman',
          'Victorovich',
           'AmconSoft',
           'Administrator',
           '095-33-93-612',
           '5250',
          'CE458789',
           '2012-06-18',
           'Калуським МВ УМВС в ІВАНО-ФРАНКІВСЬКІЙ області',
           '123456789',
           '1998-06-18',
           'male')
GO


