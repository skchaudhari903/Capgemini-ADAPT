alter session set current_schema = mt_toy;
SET heading OFF

SELECT CITY, COUNT(*) AS TOTAL
FROM CUSTOMER
GROUP BY CITY;