--Display account no., customer id, initial amount in terms of lakhs (rounded off to 2 decimals) [change the column heading to 'INITIALAMTIN_LAKHS'], amount category(amt < 50000 show as 'Low', amt > 50 lakhs as 'High', otherwise, 'Medium') [change the column heading to "AMOUNT_CATEGORY"], start date, maturity date (use term in months to calculate it) [change the column heading to "MATURITY_DATE"] of all 'ACTIVE' (upper case) FD accounts which were started after year 2004.

alter session set current_schema=bank;
SET heading OFF;

SELECT ACCOUNT_NO, CUST_ID, ROUND(INITIAL_AMT/100000, 2) AS "INITIALAMTIN_LAKHS"
CASE
	WHEN INITIAL_AMT < 50000 THEN 'Low'
	WHEN INITIAL_AMT > 5000000 THEN 'High'
	ELSE 'Medium'
END AS "AMOUNT_CATEGORY",
START_DT, ADD_MONTHS(START_DT, FD_TERM_MNTH) AS "MATURITY_DATE"
FROM BANK_FD_ACCOUNT
WHERE UPPER(ACC_STATUS) = 'ACTIVE' AND TO_CHAR(START_DT, 'YYYY') > 2004;