--Display bank employee designation, id, name and gender of those employees who have a manager, sorted in descending order of designation and ascending order of employee name.

SELECT DESIGNATION, BANK_EMP_ID, EMP_NAME, EMP_SEX
FROM BANK_EMPLOYEE
WHERE MANAGER_ID IS NOT NULLORDER BY DESIGNATION DESC, EMP_NAME ASC;  