---lists num of movies for each genre with popularity more than 7
SELECT genre_name, COUNT(movie_id) AS num_movies
FROM genre_of
WHERE EXISTS (
    SELECT genre_popularity 
    FROM genre 
    WHERE genre_of.genre_name = genre.genre_name 
    AND genre_popularity > 7)
GROUP BY genre_name
HAVING COUNT(movie_id) > 0;

---list for each movie, the number of transactions on a movie before december 1st 2020
SELECT movie_id, COUNT(transaction_id) AS num_transactions
FROM access_movie
WHERE EXISTS (SELECT transaction_id 
                FROM customer_transaction 
                WHERE customer_transaction.transaction_id = access_movie.transaction_id 
                AND transaction_date < '2020-12-01') 
GROUP BY movie_id;

--this MINUS returns all movie_id values that are in the movie_library table
--group by statement groups the rows that have same values into summary rows

---list number of departments who did not access start dates before 2020-10-01
SELECT COUNT(department_id) AS num_departments
FROM (
    SELECT department_id
    FROM department
    MINUS
    SELECT department_id
    FROM access_movie
    WHERE accesss_start_date < '2020-10-01')
GROUP BY (department_id);

--the UNION operator is used to combine the result-set of two or more SELECT statements

---list a count of everyone (employees and customers) in each province 
SELECT employee_province, COUNT(*) AS total_num_people
FROM (
    SELECT employee_id, employee_province
    FROM employee
    UNION
    SELECT payment_method_id, customer_province
    FROM payment_method
)
GROUP BY employee_province;

---lists all movies by id with num of actors with a review more than 8
SELECT movie_id, COUNT(actor_id) AS num_actors
FROM appear_in
WHERE EXISTS (SELECT actor_id
                FROM actor 
                WHERE actor.actor_id = appear_in.actor_id
                AND actor_review > 8) 
GROUP BY movie_id
ORDER BY movie_id;