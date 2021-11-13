SELECT
COUNT(*) AS Count
FROM CPUs;

SELECT Make
FROM CPUs
GROUP BY Make;

SELECT Make, Model,
MAX(Frequency) as Frequency
FROM CPUs
GROUP BY Make, Model
HAVING MAX(Frequency) >= 4.5;

INSERT INTO CPUs(Make, Model, Frequency, CoreNumber)
VALUES('Intel', 'i5-12600K', 5.1, 6),
	  ('Intel', 'i3-10300K', 4.5, 4),
	  ('AMD', 'Ryzen 5 5600G', 4.0, 6);


SELECT Make, Model, Frequency, CoreNumber
INTO MyCPUs
FROM CPUs
WHERE Make = 'Intel';

SELECT *
FROM MyCPUs

TRUNCATE TABLE MyCPUs;

UPDATE CPUs
SET Frequency = 4.35
WHERE Frequency = 4.3;


SELECT A.Make, A.Model
INTO Manufactures
FROM CPUs as A
INNER JOIN GPUs as B
ON A.Make = B.Make
UPDATE Manufactures
SET Make = 'Intel Inside'
WHERE Make='Intel';

SELECT *
FROM Manufactures

DELETE 
FROM Manufactures
WHERE Make='Intel Inside';

SELECT Make, Model,
(SELECT
	MAX(Frequency)
 FROM CPUs
 WHERE Make = 'AMD') as MAXFrequency
 FROM GPUs

SELECT Make, Model
FROM GPUs
WHERE
	Frequency > (SELECT 
					MAX(Frequency)
					FROM CPUs);

SELECT Make, Model, Frequency
FROM CPUs
GROUP BY Make, Model, Frequency
HAVING Frequency > (SELECT 
					MAX(Frequency)
					FROM GPUs);


SELECT Make, Model, Frequency
FROM GPUs
WHERE Make IN 
			  (SELECT Make
				 FROM CPUs
				 WHERE (Model LIKE 'R%'));


SELECT Make, Model
FROM GPUs
WHERE EXISTS (SELECT Make 
			  FROM CPUs
			  WHERE GPUs.Make = CPUs.Make);

SELECT Make, Model, Frequency,
CASE Make
WHEN 'AMD' then Frequency/2
WHEN 'Intel' then Frequency*2
END as "New Frequencies"
FROM CPUs;