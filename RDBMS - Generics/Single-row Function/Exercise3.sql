--Write a query to show transaction date, account no., description, amount and transaction type (show 'Credit' for 'CR' and 'Debit' for 'DB') [change the column heading to "trans_type"] for all transaction amounts > 10000 other than RD installments, in the ascending order of transaction type and descending order of transaction date

alter session set current_schema=bank;
SET heading OFF;

SELECT TRANS_DT, TRANS_ACC_NO, TRANS_DESC, TRANS_AMT,
CASE 
	WHEN TRANS_TYPE = 'CR' THEN 'Credit'
	ELSE 'Debit'
END AS "TRANS_TYPE"
FROM BANK_TRANSACTION
WHERE TRANS_DESC NOT LIKE 'RD INST%' AND TRANS_AMT > 10000
ORDER BY TRANS_TYPE ASC, TRANS_DT DESC;