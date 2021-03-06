alter session set current_schema=bank;
SET heading OFF;

SELECT CUST_ID,
COUNT(CUST_ID)
FROM BANK_CUST_CONTACT CONTACT
WHERE CONTACT.CONTACT_TYPE = 'OFFICE'
GROUP BY CONTACT.CUST_ID
HAVING COUNT(CONTACT.CUST_PHONE) > 1;