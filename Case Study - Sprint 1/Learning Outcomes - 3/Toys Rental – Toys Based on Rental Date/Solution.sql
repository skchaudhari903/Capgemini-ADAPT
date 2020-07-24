alter session set current_schema = mt_toy;
SET heading OFF

SELECT * FROM TOY_RENTAL
WHERE TO_CHAR(RENTAL_START_DATE, 'DD-MM-YY') = '20-05-20';