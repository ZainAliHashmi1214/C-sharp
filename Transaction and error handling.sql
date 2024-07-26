CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    AccountHolderName NVARCHAR(100),
    Balance DECIMAL(18, 2)
);


INSERT INTO Accounts (AccountID, AccountHolderName, Balance) VALUES (1, 'Zain', 1000.00);
INSERT INTO Accounts (AccountID, AccountHolderName, Balance) VALUES (2, 'Ali', 500.00);

DECLARE @FromAccountID INT = 1;
DECLARE @ToAccountID INT = 2;
DECLARE @TransferAmount DECIMAL(18, 2) = 100.00;

BEGIN TRY
    
    BEGIN TRANSACTION;

       IF (SELECT Balance FROM Accounts WHERE AccountID = @FromAccountID) < @TransferAmount
    BEGIN
        THROW 50000, 'Insufficient balance in the FromAccount.', 1;
    END

        UPDATE Accounts
    SET Balance = Balance - @TransferAmount
    WHERE AccountID = @FromAccountID;

    UPDATE Accounts
    SET Balance = Balance + @TransferAmount
    WHERE AccountID = @ToAccountID;


    COMMIT TRANSACTION;
    PRINT 'Transaction completed successfully.';

END TRY
BEGIN CATCH
  ROLLBACK TRANSACTION;

    
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;

    SELECT 
        @ErrorMessage = ERROR_MESSAGE(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE();

   
    PRINT 'Error occurred: ' + @ErrorMessage;

  
END CATCH;
