--Display details (account no, primary customer id, current balance and a/c start date) of active SB accounts in the order of latest start date (first) to earliest start date (last).

alter session set current_schema=bank;
SET heading OFF;

SELECT ACCOUNT_NO, PRIMARY_CUST_ID, CURR_BAL_AMT, START_DATE
FROM BANK_SB_ACCOUNT
WHERE ACC_STATUS = 'Active'
ORDER BY START_DATE;