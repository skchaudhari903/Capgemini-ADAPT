--display all the columns of bank employees other than 'Attender' who were not involved in any type of bank transaction.

alter session set current_schema=bank;
SET heading OFF;

SELECT * 
FROM BANK_EMPLOYEE E
WHERE NOT EXISTS (SELECT BANK_EMP_ID FROM BANK_TRANSACTION T 
WHERE E.BANK_EMP_ID = T.BANK_EMP_ID AND T.TRANS_DESC IS NOT NULL)
AND (DESIGNATION <> 'ATTENDER');