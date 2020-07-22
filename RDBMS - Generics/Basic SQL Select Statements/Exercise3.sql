--Display bank employee designation, id, name and gender of those employees who have a manager, sorted in descending order of designation and ascending order of employee name.

alter session set current_schema=bank;
SET heading OFF;

SELECT DESIGNATION, BANK_EMP_ID, EMP_NAME, EMP_SEX
FROM BANK_EMPLOYEE
WHERE MANAGER_ID IS NOT NULL
ORDER BY DESIGNATION DESC, EMP_NAME ASC;  