--(view of one table) view of actors of high rating who are potential for awards
CREATE VIEW potential_awarded (ActorID, First_Name, Last_Name, Review) AS
(SELECT actor_id, actor_first_name, actor_last_name, actor_review
FROM actor
WHERE actor_review > 8) WITH READ ONLY;

--(view with multiple tables) view of customer id, customer name and payment card type
CREATE VIEW customer_card_type (customer_id, customer_name, card_type, card_expire_date) AS
(SELECT customer_id, customer_name, payment_method.card_type, payment_method.card_expire_date
FROM customer, payment_method
WHERE customer.payment_method_id = payment_method.payment_method_id);

--(view with multiple tables) view of movie name and director name
CREATE VIEW directed_by (movie_name, director_first_name, director_last_name) AS
(SELECT movie_name, director.director_first_name, director.director_last_name
FROM movie_library, director
WHERE movie_library.director_id = director.director_id);
