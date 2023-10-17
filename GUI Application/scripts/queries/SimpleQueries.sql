---List hours worked
SELECT employee_first_name, SUM (work_hours)
FROM employee
GROUP BY employee_first_name;

---List all employees in marketing by seniority (most hours)
SELECT employee_first_name, employee_last_name, work_hours as seniority_in_marketing_dep
FROM employee
WHERE department_id = 1
ORDER BY work_hours DESC;

---List all movies and their release date
SELECT movie_name, 'released on:', release_date
FROM movie_library;

---List all movies accessed
SELECT access_id, transaction_id, movie_id, accesss_start_date, access_end_date
FROM access_movie
WHERE accesss_start_date <= '2020-12-01'
ORDER BY accesss_start_date DESC;

---List customers in alphabetical order
SELECT *
FROM customer
ORDER BY customer_name;

---List all actors from highest review
SELECT *
FROM actor
ORDER BY actor_review DESC;

---List all movies and with a price of 50 
SELECT *
FROM movie_library
WHERE movie_price >= 50;

---List all movies with a review of 8 or more, order by descending
SELECT *
FROM movie_library
WHERE movie_review >= 8
ORDER BY movie_review DESC;

---List only movie id and actor id
SELECT movie_id, actor_id
FROM appear_in
ORDER BY movie_id DESC, actor_id asc;

--(sort the output in ascending order by name)
---List all employees in marketing department
SELECT employee_first_name as employees_in_marketing
FROM employee
WHERE department_id = 001
ORDER BY employee_first_name;

---List all movie (movie name and rating) of a director
SELECT movie_name, movie_rating
FROM movie_library
WHERE movie_rating = 'PG-13'
    AND director_id = 001;

---List all movies (movie name and review only) in movie rating PG-13 with a review of 9 or more or PG with eview of 5 or more
SELECT movie_name, movie_review
FROM movie_library
WHERE (movie_review >= 9
    AND movie_rating = 'PG-13')
    OR
    (movie_review >= 5
    AND movie_rating = 'PG');

---Q8: List all movies (name and director) who are not PG-13
SELECT movie_name, director_id
FROM movie_library
WHERE movie_rating <> 'PG-13';