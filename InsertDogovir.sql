USE [BankContext]
GO

INSERT INTO [dbo].[Dogovirs]
           ([TypeOfCredit]
           ,[AmountOfCredit]
           ,[Currency]
           ,[Rate]
           ,[DateOfGetting]
           ,[Termin]
           ,[Target]
           ,[EmployeeId]
           ,[ClientId])
     VALUES
           ('�������',
           '200000',
          'UAH',
           '0.17',
           '1998-06-18',
           '10',
           '�� ����',
           '1',
           '1')
GO


