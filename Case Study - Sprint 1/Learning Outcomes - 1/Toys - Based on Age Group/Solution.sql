alter session set current_schema = mt_toy;
SET heading OFF

SELECT * FROM TOY
WHERE MIN_AGE < 4 OR MAX_AGE < 4;