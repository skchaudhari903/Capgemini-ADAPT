alter session set current_schema = mt_toy;
SET heading OFF

SELECT * FROM TOY
WHERE QUANTITY BETWEEN 20 AND 50;