#!/bin/sh
#export LD_LIBRARY_PATH=/usr/lib/oracle/12.1/client64/lib
sqlplus64 "username/password@(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(Host=oracle.scs.ryerson.ca) (Port=1521))(CONNECT_DATA=(SID=orcl)))" <<EOF
--insert values in tables

--Insert values in department table (department_id,'department_name','location')
INSERT INTO department VALUES (01,'Marketing', 'Toronto');
INSERT INTO department VALUES (02,'Human Resources', 'Ottawa');

--Insert values in employee table
/*
INSERT INTO employee VALUES (
    employee_id,
    department_id,
    work_hours,
    'employee_first_name',
    'employee_last_name',
    'employee_gender',
    'employee_dob',
    'employee_province',
    'employee_city',
    'employee_street',
    'employee_postal_code'
    )
*/
INSERT INTO employee VALUES (
    00001,
    01,
    1440,
    'Igor',
    'Mathewson',
    'Male',
    '1993 - 11 - 03',
    'Ontario',
    'Toronto',
    '1637 Eglinton Avenue',
    'M4P 1A6'
    );
    
INSERT INTO employee VALUES (
    00002,
    01,
    7488,
    'Lidia',
    'Ardelean',
    'Female',
    '1974-06-24',
    'Alberta',
    'Veteran',
    '3046 Pine Street',
    'T0C 2S0'
    );
    
INSERT INTO employee VALUES (
    00003,
    02,
    12480,
    'Hilda',
    'Danell',
    'Female',
    '1975-01-06',
    'British Columbia',
    'Victoria',
    '4716 Burdett Avenue',
    'V8Y 1Y7'
    );
    
INSERT INTO employee VALUES (
    00004,
    01,
    1920,
    'Jordan',
    'Okonkwo',
    'Male',
    '2000-10-27',
    'Ontario',
    'Etobicoke',
    '267 Queen Elizabeth Boulevard',
    'M8Z 1M3'
    );
    
INSERT INTO employee VALUES (
    00005,
    01,
    3744,
    'Cadice',
    'Lambert',
    'Male',
    '1977-01-22',
    'Quebec',
    'Notre Dame De La Salette',
    '792 rue des Églises Est',
    'J0X 2L0'
    );

--Insert values in genre table

--INSERT INTO genre VALUES ('genre_name',genre_popularity)
INSERT INTO genre VALUES ('Action', 10);
INSERT INTO genre VALUES ('Adventure', 7);
INSERT INTO genre VALUES ('Fantasy', 8);
INSERT INTO genre VALUES ('Comedy', 9);
INSERT INTO genre VALUES ('Drama', 6);
INSERT INTO genre VALUES ('Romance', 5);
INSERT INTO genre VALUES ('Crime', 6);
INSERT INTO genre VALUES ('Horror', 5);
INSERT INTO genre VALUES ('Family', 6);
    
--Insert values in actor table
  --INTO actor VALUES (actor_id, 'first_name', 'last_name', actor_review) 
  
    --Actors in Docter Strange
INSERT INTO actor VALUES (000001,'Benedict', 'Cumberbatch',9);
INSERT INTO actor VALUES (000002,'Chiwetel', 'Ejiofor',8);
INSERT INTO actor VALUES (000003,'Rachel', 'McAdams',8);
    
    --Actors in Jumanji
INSERT INTO actor VALUES (000004,'Dwayne', 'Johnson',10);
INSERT INTO actor VALUES (000005,'Karen', 'Gillan',7);
INSERT INTO actor VALUES (000006,'Kevin', 'Hart',10);
    
    --Actors in Guardians of Galaxy
INSERT INTO actor VALUES (0007,'Chris', 'Pratt',9);
INSERT INTO actor VALUES (0008,'Vin', 'Diesel',7);
INSERT INTO actor VALUES (0009,'Bradley', 'Cooper',6);

    --Actors in Beauty and the Beast
INSERT INTO actor VALUES (0010,'Emma', 'Watson', 9);
INSERT INTO actor VALUES (0011,'Dan', 'Stevans', 6);
INSERT INTO actor VALUES (0012,'Luke', 'Evans', 6);

--Insert values in director table 
  --INTO director VALUES (director_id,'first_name', 'last_name')
  
    --Director for Docter Strange
INSERT INTO director VALUES (0001,'Scott', 'Derrickson',8);
    
    --Director for Jumanji
INSERT INTO director VALUES (0002,'Jake', 'Kasdan',7);
    
    --Director for Guardian of the Galaxy
INSERT INTO director VALUES (0003,'James', 'Gunn',9);
    
    --Director for Beauty and the Beast
INSERT INTO director VALUES (0004,'Bill', 'Condon',6);
    
--Insert values in production table GOOD

  --INTO production VALUES (production_id,'production_name', production_review)
  
    --Producer for Docter strange, Guardian of the Galaxy
INSERT INTO production VALUES (0001,'Marvel Studios',10);
    
    --Producers for Jumanji
INSERT INTO production VALUES (0002,'Columbia Pictures',9);
INSERT INTO production VALUES (0003,'Matt Tolmach Productions',7);
INSERT INTO production VALUES (0004,'Seven Bucks Productions',6);
INSERT INTO production VALUES (0005,'Radar Pictures',6);

    --Producer for Beauty and the Beast
INSERT INTO production VALUES (0006,'Walt Disney Pictures',10);
    
--Insert values in movie library table (Docter Strange) and genre_of and appear_in
    /*
    INTO movie_library VALUES (
    movie_id, 
    directorid,
    'movie name',
    'movie_rating',
    movie_price, 
    'release_date', 
    synopsis, 
    )
    
    INTO produces VALUES (movie_id, production_id)
    INTO genre_of VALUES (movie_id, genre_name)
    INTO appear_in VALUES (movie_id, actor_id)
    */
    
INSERT INTO movie_library VALUES (
    00001,
    0001,
    'Docter Strange',
    'PG-13',
    9,
    50,
    '2016 - 11 - 04',
    'While on a journey of physical and spiritual healing, a brilliant neurosurgeon is drawn into the world of the mystic arts.'
    );
    
INSERT INTO produces VALUES (00001, 0001);
INSERT INTO genre_of VALUES (00001, 'Action');
INSERT INTO genre_of VALUES (00001, 'Adventure');
INSERT INTO genre_of VALUES (00001, 'Fantasy');
INSERT INTO appear_in VALUES (00001, 000001);
INSERT INTO appear_in VALUES (00001, 000002);
INSERT INTO appear_in VALUES (00001, 000003);


--Insert values in movie library table (Jumanji) and genre_of and appear_in

INSERT INTO movie_library VALUES (
    00002,
    0002,
    'Jumanji: Welcome to the Jungle',
    'PG-13',
    7,
    30,
    '2017 - 12 - 20',
    'Four teenagers are sucked into a magical video game, and the only way they can escape is to work together to finish the game.'
    );
    
INSERT INTO produces VALUES (00002, 0002);
INSERT INTO produces VALUES (00002, 0003);
INSERT INTO produces VALUES (00002, 0004);
INSERT INTO genre_of VALUES (00002, 'Action');
INSERT INTO genre_of VALUES (00002, 'Adventure');
INSERT INTO genre_of VALUES (00002, 'Comedy');
INSERT INTO appear_in VALUES (00002, 000004);
INSERT INTO appear_in VALUES (00002, 000005);
INSERT INTO appear_in VALUES (00002, 000006);

--Insert values in movie library table (Guardians of Galaxy) and genre_of and appear_in 

INSERT INTO movie_library VALUES (
    00003,
    0003,
    'Guardians of the Galaxy',
    'PG-13',
    7,
    50,
    '2014 - 07 - 01',
    'A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.'
    );
    
INSERT INTO produces VALUES (00003, 0001);
INSERT INTO genre_of VALUES (00003, 'Action');
INSERT INTO genre_of VALUES (00003, 'Adventure');
INSERT INTO genre_of VALUES (00003, 'Comedy');
INSERT INTO appear_in VALUES (00003, 000007);
INSERT INTO appear_in VALUES (00003, 000008);
INSERT INTO appear_in VALUES (00003, 000009);

--Insert values in movie library table (Beauty and the Beast) and genre_of and appear_in 
INSERT INTO movie_library VALUES (
    00004,
    0004,
    'beauty and the Beast',
    'PG',
    9,
    60,
    '2017 - 03 - 17',
    'A selfish Prince is cursed to become a monster for the rest of his life, unless he learns to fall in love with a beautiful young woman he keeps prisoner.'
    );
    
INSERT INTO produces VALUES (00004, 0006);
INSERT INTO genre_of VALUES (00004, 'Adventure');
INSERT INTO genre_of VALUES (00004, 'Family');
INSERT INTO genre_of VALUES (00004, 'Fantasy');
INSERT INTO appear_in VALUES (00004, 000010);
INSERT INTO appear_in VALUES (00004, 000011);
INSERT INTO appear_in VALUES (00004, 000012);

--Insert values in payment_method table  GOOD
/*
    INTO payment_method VALUES (
    payment_method_id,
    'customer_province',
    'customer_city',
    'customer_street',
    'customer_postal_code',
    'card_name',
    'card_type',
    card_num,
    card_cvv,
    'card_expire_date')
*/
INSERT INTO payment_method VALUES (
    0001,
    'Manitoba',
    'Dauphin',
    '585 Main St',
    'R7N 2T3',
    'Ema Wallis',
    'Mastercard',
    5024007180587064,
    665,
    '2025-05-01');
    
INSERT INTO payment_method VALUES (
    0002,
    'British Columbia',
    'Vancouver',
    '1011 Tolmie St',
    'V6R 4C5',
    'Marcelino Metz',
    'Visa',
    4539613673997583,
    554,
    '2022-03-01');

--Insert values in customer table  
/*
    INTO customer VALUES (
    customer_id,
    payment_method_id,
    'customer_name',
    'customer_email',
    'customer_password',
    )
*/
INSERT INTO customer VALUES (
    00001,
    0001,
    'Ema Wallis',
    'EmaW@email.com',
    'EmaW123pw'
    );
    
INSERT INTO customer VALUES (
    00002,
    0002,
    'Marcelino Metz',
    'MarcelinoM@email.com',
    'MarcelinoM123pw'
    );

--Insert values in customer_transaction table  
/*
    INTO customer_transaction VALUES (
    transaction_id,
    payment_method_id,
    customer_id,
    'transaction_date')
*/
INSERT INTO customer_transaction VALUES (
    000001,
    0001,
    00001,
    '2015-01-16');
    
INSERT INTO customer_transaction VALUES (
    000002,
    0001,
    00001,
    '2016-12-23');
    
INSERT INTO customer_transaction VALUES (
    000003,
    0002,
    00002,
    '2020-08-06');
    
INSERT INTO customer_transaction VALUES (
    000004,
    0001,
    00001,
    '2021-08-06');
    
INSERT INTO customer_transaction VALUES (
    000005,
    0002,
    00002,
    '2022-08-06');
    

--Insert values in access_movie table  
/*
    INTO access_movie VALUES (
    access_id,
    department_id,
    transaction_id,
    movie_id,
    'access_start_date',
    'access_end_date',)
*/
    --customer 1 purchase movie 3 (guardians of galaxy)
INSERT INTO access_movie VALUES (
    000001,
    01,
    000001,
    00003,
    '2015-01-16',
    NULL);
    
    --customer 1 rent movie 1 (doc strange) for 1 month
INSERT INTO access_movie VALUES (
    000002,
    01,
    000002,
    00001,
    '2016-12-23',
    '2017-01-23');
    
    --customer 2 rent movie 2 (jumanji) for 3 month
INSERT INTO access_movie VALUES (
    000003,
    01,
    000003,
    00002,
    '2020-08-06',
    '2020-11-06');
    
    --customer 1 purchase movie 2 (jumanji) now 4
INSERT INTO access_movie VALUES (
    000004,
    01,
    000004,
    00004,
    '2021-08-06',
    NULL);
    
    --customer 2 purchase movie 3 (jumanji)
INSERT INTO access_movie VALUES (
    000005,
    01,
    000005,
    00003,
    '2021-08-06',
    NULL);
exit;
EOF