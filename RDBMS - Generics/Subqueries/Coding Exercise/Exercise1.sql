--Display account no., fist name and last name of individual customers who have maximum and minimum initial FD amounts.

alter session set current_schema=bank;
SET heading OFF;

SELECT S.ACCOUNT_NO, B.CUST_FNAME, B.CUST_LNAME
FROM BANK_FD_ACCOUNT S, BANK_CUSTOMER B
WHERE B.CUST_ID = S.CUST_ID
AND (INITIAL_AMT = (SELECT MAX(INITIAL_AMT) FROM BANK_FD_ACCOUNT GROUP BY B.CUST_FNAME)
OR INITIAL_AMT = (SELECT MIN(INITIAL_AMT) FROM BANK_FD_ACCOUNT GROUP BY B.CUST_FNAME);