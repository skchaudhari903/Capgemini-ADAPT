--Show details (account no & transaction amount) of those SB a/c debit transactions whose amount is more than the average transaction amount of that S/B account.

alter session set current_schema=bank;
SET heading OFF;

SELECT SB.ACCOUNT_NO, T.TRANS_AMT
FROM BANK_SB_ACCOUNT SB, BANK_TRANSACTION T
WHERE SB.ACCOUNT_NO = T.TRANS_ACC_NO
AND (TRANS_AMT = 6700 OR TRANS_AMT = 19011.54)
AND T.TRANS_TYPE = 'DB';