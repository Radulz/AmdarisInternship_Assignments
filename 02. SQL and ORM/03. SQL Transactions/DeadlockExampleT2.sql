BEGIN TRAN

UPDATE CPUs
SET Frequency = 4.2
WHERE Frequency >= 5;

UPDATE MOBOs
SET MemoryType = 'DDR5'
WHERE Make = 'MSI';

ROLLBACK TRAN

--Msg 1205, Level 13, State 51, Line 7
--Transaction (Process ID 56) was deadlocked on lock resources with another process and has been chosen as the deadlock victim. Rerun the transaction.
