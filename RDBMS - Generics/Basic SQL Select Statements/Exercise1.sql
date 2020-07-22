--Write a query to show customer id, phone no, customer address line1, customer address line2, city, state, pincode of customers who live either in 'Karnataka' or 'Tamilnadu'. Also check whether the contact type is 'HOME'

alter session set current_schema=bank;
SET heading OFF;

SELECT CUST_ID, CUST_PHONE, CUST_ADDR_LINE1, CUST_ADDR_LINE2, CUST_CITY, CUST_STATE, CUST_PIN
FROM BANK_CUST_CONTACT
WHERE CONTACT_TYPE = 'HOME'
AND CUST_STATE IN('Karnataka', 'Tamilnadu'); 