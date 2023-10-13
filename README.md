# Online Movie DBMS
<a name="readme-top"></a>

## Table of Contents
* [Introduction](#introduction)
* [Technologies](#technologies)
* [Prerequisites](#prerequisites)
* [Installation](#installation)
* [Usage](#usage)
* [Features](#features)
* [Credits](#credits)

## Introduction
This program aids a movie store owner in managing their inventory of movies online to sell or rent to customers 24/7. Relational techniques were learnt and used to optimize the database by reducing tables while keeping the functionalities.

## Technologies
The project is created with:
* SQL
* Oracle DBMS Developer
* Unix Shell Scripting
* .NET C#

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Prerequisites
To run the application on your own computer, first make sure the local system is connected through the TMU VPN (vpn.scs.ryerson.ca).

To run the unix shell, connect to the moon server through MobaXterm or from mac terminal
Open terminal and type below command

`ssh username@moon.cs.ryerson.ca`

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Installation
Clone the repo:

`git clone https://github.com/icejan/Movie-DBMS.git`

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Usage
### Unix Shell
To run the unix shell menu, use command in MobaXterm or from mac terminal

`bash menu.sh`

You can input your choices from the listed options detailed in the menu to change or manage the database.

### GUI
To run the GUI, run the executable “Movie Store.exe" to launch the application.
You can explore the database system, allowing for records to be added, modified, or deleted. An example video is shown below.

https://github.com/icejan/Movie-DBMS/assets/97641242/ab4c2a43-4791-4ff3-b451-e01d047a9c63

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Features
* Allows customers to search for their favorite movies with multiple filtering options based on genres, year released, director, and other criteria. 
* The online store will enable people to buy or rent movies. 
* The employee can add, remove, and modify the digital movie entries, as well as customer table entries. 
* The employee can add, remove or manage its movie metadata specifically genres, release date, actors, directors, etc.
* A customer will have attributes like email, password, billing address, and payment info. They can search the database for movies they might be interested in purchasing by specifying a title, genre, or associated performers and directors. Upon selection of a desired movie title, the price will be displayed. 
* Payment will be completed by charging the saved credit card on file before the user has access to the movie. Upon successful payment, a timestamp will be added to the customer’s film to keep track of both purchase history and remaining rental time left if applicable.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Credits
* Dalton Crowe - https://www.linkedin.com/in/daltoncrowe/
* Fadi Al-Shabi
