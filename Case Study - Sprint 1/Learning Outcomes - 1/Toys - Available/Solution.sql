alter session set current_schema = mt_toy;
SET heading OFF

SELECT TOY_ID, TOY_NAME, TOY_TYPE, MIN_AGE, MAX_AGE, PRICE,
QUANTITY, RENTAL_AMOUNT FROM TOY; 