alter session set current_schema = mt_toy;
SET heading OFF

SELECT TOY_NAME FROM TOY
WHERE TOY_NAME = 'Musical Horn' OR TOY_NAME = 'Lego Ferrai Racer'
ORDER BY TOY_NAME DESC;