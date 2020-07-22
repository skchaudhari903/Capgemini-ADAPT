--Which individual customer(s) have not provided their home phone no.? Display their cust id and first name. Hint: Customer Type should be "IND" and Contact Type should be "OFFICE"

alter session set current_schema=bank;
SET heading OFF;

SELECT CUST_ID, CUST_FNAME
FROM BANK_CUSTOMER B
WHERE NOT EXISTS
(SELECT CUST_ID, CUST_FNAME
FROM BANK_CUST_CONTACT C
WHERE B.CUST_ID = C.CUST_ID AND C.CONTACT_TYPE = 'OFFICE') AND B.CUST_TYPE = 'IND'; 