--Auto Commit transactions
SELECT *
FROM MOBOs

INSERT INTO MOBOs (Make, Model, Chipset, MemoryType)
VALUES ('Asus', 'ROG B550-F', 'B550', 'DDR4');

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

--Implicit Transaction

SET IMPLICIT_TRANSACTIONS ON

INSERT INTO MOBOs (Make, Model, Chipset, MemoryType)
VALUES ('Asus', 'ROG B550-E', 'B550', 'DDR4');

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

ROLLBACK TRAN

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';


--Explicit transaction

BEGIN TRAN

INSERT INTO MOBOs (Make, Model, Chipset, MemoryType)
VALUES ('Asus', 'ROG B550-E', 'B550', 'DDR4');

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

COMMIT TRAN

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

--Nested Transaction

BEGIN TRAN T1

INSERT INTO MOBOs (Make, Model, Chipset, MemoryType)
VALUES ('Asus', 'ROG X570-E', 'X570', 'DDR4');

BEGIN TRAN T2

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

INSERT INTO MOBOs (Make, Model, Chipset, MemoryType)
VALUES ('Asus', 'ROG X570-F', 'X570', 'DDR4');

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

COMMIT TRAN T2

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';

COMMIT TRAN T1  

SELECT *
FROM MOBOs
WHERE Make LIKE 'A%';