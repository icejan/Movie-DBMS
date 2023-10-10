CREATE TABLE department (
    department_id   NUMBER PRIMARY KEY,
    department_name VARCHAR2(50) NOT NULL,
    department_location VARCHAR2(50) NOT NULL
);

CREATE TABLE genre (
    genre_name VARCHAR2(50) PRIMARY KEY,
    genre_popularity NUMBER DEFAULT 0
);

CREATE TABLE production (
    production_id   NUMBER PRIMARY KEY,
    production_name VARCHAR2(50) NOT NULL,
    production_review NUMBER DEFAULT 0
);

CREATE TABLE director (
    director_id   NUMBER PRIMARY KEY,
    director_first_name VARCHAR2(50) NOT NULL,
    director_last_name VARCHAR2(50) NOT NULL,
    director_review NUMBER DEFAULT 0
);

CREATE TABLE actor (
    actor_id   NUMBER PRIMARY KEY,
    actor_first_name VARCHAR2(50) NOT NULL,
    actor_last_name VARCHAR2(50) NOT NULL,
    actor_review NUMBER DEFAULT 0
);

CREATE TABLE card_type(
    card_num NUMBER PRIMARY KEY,
    card_type varchar(50) NOT NULL
);

CREATE TABLE employee (
    employee_id   NUMBER,
    department_id NUMBER NOT NULL,
    work_hours    NUMBER NOT NULL,
    employee_first_name VARCHAR2(50) NOT NULL,
    employee_last_name VARCHAR2(50) NOT NULL,
    employee_gender VARCHAR2(50),
    employee_dob DATE,
    employee_province VARCHAR2(50) NOT NULL,
    employee_city VARCHAR2(50) NOT NULL, 
    employee_street VARCHAR2(50) NOT NULL,
    employee_postal_code VARCHAR2(50) NOT NULL,
    CONSTRAINT employee_id PRIMARY KEY (employee_id),
    CONSTRAINT department_fk FOREIGN KEY (department_id) REFERENCES department (department_id)
);

CREATE TABLE movie_library (
    movie_id     NUMBER,
    director_id NUMBER NOT NULL,
    movie_name   VARCHAR2(50) NOT NULL,
    movie_rating VARCHAR2(50) NOT NULL,
    movie_review NUMBER DEFAULT 0,
    movie_price  NUMBER NOT NULL,
    release_date DATE,
    synopsis     VARCHAR2(200),
    CONSTRAINT movie_pk PRIMARY KEY (movie_id),
    CONSTRAINT director_fk FOREIGN KEY (director_id) REFERENCES director (director_id)
);

CREATE TABLE genre_of (
    movie_id    NUMBER NOT NULL,
    genre_name    VARCHAR2(50) NOT NULL,
    CONSTRAINT movie_genre_fk FOREIGN KEY (movie_id) REFERENCES movie_library (movie_id),
    CONSTRAINT genre_fk FOREIGN KEY (genre_name) REFERENCES genre (genre_name)
);

CREATE TABLE produces (
    movie_id    NUMBER NOT NULL,
    production_id NUMBER NOT NULL,
    CONSTRAINT movie_produces_fk FOREIGN KEY (movie_id) REFERENCES movie_library (movie_id),
    CONSTRAINT production_fk FOREIGN KEY (production_id) REFERENCES production (production_id)
);

CREATE TABLE  appear_in (
    movie_id    NUMBER NOT NULL,
    actor_id    NUMBER NOT NULL,
    CONSTRAINT movie_actor_fk FOREIGN KEY (movie_id) REFERENCES movie_library (movie_id),
    CONSTRAINT actor_fk FOREIGN KEY (actor_id) REFERENCES actor (actor_id)
);

CREATE TABLE payment_method (
    payment_method_id NUMBER,
    customer_province VARCHAR2(50) NOT NULL,
    customer_city VARCHAR2(50) NOT NULL,
    customer_street VARCHAR2(50) NOT NULL,
    customer_postal_code VARCHAR2(50) NOT NULL,
    card_name VARCHAR2(50) NOT NULL,
    card_num NUMBER NOT NULL,
    card_cvv NUMBER NOT NULL,
    card_expire_date DATE NOT NULL,
    CONSTRAINT payment_method_pk PRIMARY KEY (payment_method_id)
);

CREATE TABLE customer (
    customer_id   NUMBER,
    payment_method_id NUMBER NOT NULL,
    customer_name VARCHAR2(50) NOT NULL,
    customer_email VARCHAR2(50) NOT NULL,
    customer_password VARCHAR2(50) NOT NULL,
    CONSTRAINT customer_pk PRIMARY KEY (customer_id),
    CONSTRAINT payment_method_fk FOREIGN KEY (payment_method_id) REFERENCES payment_method (payment_method_id)
);

CREATE TABLE customer_transaction (
    transaction_id   NUMBER,
    payment_method_id NUMBER NOT NULL,
    customer_id NUMBER NOT NULL,
    transaction_date DATE NOT NULL, 
    CONSTRAINT transaction_pk PRIMARY KEY (transaction_id),
    CONSTRAINT payment_method_id_fk FOREIGN KEY (payment_method_id) REFERENCES payment_method (payment_method_id),
    CONSTRAINT customer_id_fk FOREIGN KEY (customer_id) REFERENCES customer (customer_id)
);

CREATE TABLE access_movie (
    access_id   NUMBER,
    department_id NUMBER NOT NULL,
    transaction_id NUMBER NOT NULL,
    movie_id NUMBER NOT NULL,
    accesss_start_date DATE NOT NULL,
    access_end_date DATE,
    CONSTRAINT access_pk PRIMARY KEY (access_id),
    CONSTRAINT department_id_acc_fk FOREIGN KEY (department_id) REFERENCES department (department_id),
    CONSTRAINT transaction_acc_fk FOREIGN KEY (transaction_id) REFERENCES customer_transaction (transaction_id),
    CONSTRAINT movie_acc_fk FOREIGN KEY (movie_id) REFERENCES movie_library (movie_id)
);