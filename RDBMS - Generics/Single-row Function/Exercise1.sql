--Show customer id, capitalized first & last names, day & month (DD-Mon format) of date of birth and change the alias name "DOB" of female customers.

alter session set current_schema=bank;
SET heading OFF;

SELECT CUST_ID, UPPER(CUST_FNAME), UPPER(CUST_LNAME), TO_CHAR(CUST_DOB, 'DD-Mon') AS DOB
FROM BANK_CUSTOMER
WHERE CUST_SEX = 'F';