alter session set current_schema = mt_toy;
SET heading OFF

SELECT * FROM TOY_RENTAL
WHERE TOY_ID IN
(SELECT TOY_ID FROM TOY
WHERE TOY_NAME = 'PlayStix');