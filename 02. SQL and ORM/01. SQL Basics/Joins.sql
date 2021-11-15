USE [ComponentsDatabase]
GO

INSERT INTO [dbo].[MOBOs]
           ([Make]
           ,[Model]
           ,[Chipset]
           ,[MemoryType])
     VALUES ('MSI', 'MPG', 'Z590', 'DDR4');
GO


INSERT INTO Procs (Make, Model, Chipset, Frequency, CoreNumber)
			VALUES ('Intel', 'i7-11700k', 'Z490', 3.8, 8),
				   ('AMD', 'Ryzen 5 5600X', 'B550', 4.0, 6),
				   ('AMD', 'Ryzen 7 5800X', 'X570', 4.2, 8);


SELECT *
FROM MOBOs as A
LEFT JOIN Procs as B
on A.Chipset = B.Chipset;

SELECT *
FROM CPUs as A
RIGHT JOIN GPUs as B
on A.Make = B.Make;

SELECT *
FROM MOBOs as A
INNER JOIN Procs as B
ON A.Chipset = B.Chipset;

SELECT *
FROM MOBOs as A
LEFT JOIN Procs as B
ON A.Chipset = B.Chipset
WHERE B.Chipset is NULL;


SELECT *
FROM Procs as A
FULL OUTER JOIN MOBOs as B
ON A.Chipset = B.Chipset;

SELECT *
FROM Procs as A
FULL OUTER JOIN MOBOs as B
ON A.Chipset = B.Chipset
WHERE A.Chipset is NULL
OR B.Chipset is NULL;
