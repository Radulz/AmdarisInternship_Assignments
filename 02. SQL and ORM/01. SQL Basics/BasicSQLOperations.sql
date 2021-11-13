USE [ComponentsDatabase]
GO

INSERT INTO [dbo].[CPUs]
           ([Make]
           ,[Model]
           ,[Frequency]
           ,[CoreNumber])
     VALUES
           ('AMD',
		   'Ryzen 9 5950X',
           '4.0',
           '8');
GO

SELECT Frequency,
	   Make,
	   Model
FROM CPUs
WHERE Frequency > 4.2;

UPDATE CPUs
	SET CoreNumber = 6
	WHERE CoreNumber = 5;

DELETE CPUs
WHERE Make = 'AMD';

SELECT Make, Model
FROM CPUs
GROUP BY Make, Model
HAVING Make = 'AMD';

SELECT *
FROM CPUs
WHERE Make is NULL;



