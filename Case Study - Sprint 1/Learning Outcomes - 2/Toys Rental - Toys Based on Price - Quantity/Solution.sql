alter session set current_schema = mt_toy;
SET heading OFF

SELECT * FROM TOY
WHERE PRICE > 145 AND QUANTITY = 5;