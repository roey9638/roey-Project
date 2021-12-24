--1
SELECT E.first_name , E.last_name ,E.department_id , D.department_name
FROM employees E
JOIN departments D
ON E.department_id = D.department_id

--2
Select e.first_name, e.last_name , d.department_name, l.city , l.state_province from employees e
Join departments d ON d.department_id = e.department_id
Join locations l ON l.location_id = d.location_id

--3
Select e.first_name, e.last_name , e.salary , j.job_id from employees e
Join Jobs j ON E.salary BETWEEN j.min_salary AND j.max_salary -- Didn't Understand This Part

--4
Select e.first_name, e.last_name, e.department_id , d.department_name from employees e
Join departments d ON e.department_id = d.department_id
AND E.department_id IN (10,5)
ORDER BY e.department_id

--5
Select e.first_name, e.last_name , d.department_name , l.city ,l.state_province from employees e
Join departments d ON e.department_id = d.department_id
Join locations l ON d.location_id = l.location_id
WHERE e.first_name LIKE  '%j%'

--6
Select e.first_name , e.last_name from employees e
Right outer Join departments d ON e.department_id = d.department_id -- Don't Understand [Right outer Join]!!!

--7
Select e.first_name, e.last_name , e.salary from employees e
Join employees s ON e.salary < s.salary AND s.employee_id = 100

--8 Didn't Undestand this One!!!
Select e.first_name AS 'Employee Name' , m.first_name AS 'Manager' from employees e
Join employees m ON e.manager_id = m.employee_id

--9
Select d.department_name , l.city , l.state_province from departments d
Join locations l ON d.location_id = l.location_id

--10
Select e.first_name , e.last_name , d.department_id , d.department_name from employees e
LEFT OUTER JOIN departments d ON e.department_id = d.department_id  -- Don't Understand [LEFT OUTER JOIN]!!!

--11
Select e.first_name AS 'Employee Name' , m.first_name AS 'Manager' from employees e
Left Outer Join employees m ON e.manager_id = m.employee_id  -- Don't Understand [LEFT OUTER JOIN]!!!

--12
Select e.first_name , e.last_name , e.department_id from employees e
Join employees s ON e.department_id = s.department_id AND s.last_name = 'Taylor' -- I Don't Understand That

--13
-- Don't Understand!!!

--14
Select j.job_title , j.max_salary , e.first_name from employees e
Join jobs j -- Don't Understand

--15
Select department_name, AVG(salary) from departments 
Join employees USING (department_id) 
GROUP BY d.department_name -- Dosen't Work




