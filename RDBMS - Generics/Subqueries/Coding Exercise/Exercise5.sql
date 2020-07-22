--List the SB account no.(s) on which no transactions have been made so far (Use NOT EXISTS clause in the query)

alter session set current_schema=bank;
SET heading OFF;

SELECT ACCOUNT_NO FROM BANK_SB_ACCOUNT SB
WHERE NOT EXISTS
(SELECT TRANS_NO FROM BANK_TRANSACTION T WHERE SB.ACCOUNT_NO = T.TRANS_ACC_NO);