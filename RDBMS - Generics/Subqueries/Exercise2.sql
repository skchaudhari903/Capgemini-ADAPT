--List full details of all types of RD account transactions made by all accounts of customers who are from 'Tamilnadu'. (Use subquery)

alter session set current_schema=bank;
SET heading OFF;

SELECT * FROM BANK_TRANSACTION
WHERE TRANS_ACC_NO IN
(SELECT ACCOUNT_NO FROM BANK_RD_ACCOUNT
JOIN BANK_CUSTOMER
ON BANK_RD_ACCOUNT.RD_CUST_ID = BANK_CUSTOMER.CUST_ID
JOIN BANK_CUST_CONTACT
ON BANK_CUSTOMER.CUST_ID = BANK_CUST_CONTACT.CUST_ID
WHERE CUST_STATE = 'Tamilnadu');