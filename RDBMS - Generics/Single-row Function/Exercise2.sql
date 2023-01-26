--Show transaction date, first 20 characters of transaction description (change the column heading to "trans_desc") and amounts of all 'Credit' transactions done during June, 2010.

alter session set current_schema=bank;
SET heading OFF;
select trans_dt,substr(trans_desc,1,20) as TRANS_DESC, trans_amt
from bank_transaction
where trans_type='CR' and to_char(trans_dt,'Mon-YYYY')='Jun-2010';

