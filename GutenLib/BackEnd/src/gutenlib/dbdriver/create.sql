-- SQL Queries to make all tables --

CREATE TABLE books(
bookid int primary key,
title varchar(250),
author varchar(250),
subject varchar(250),
viewlink varchar(250)
);

CREATE TABLE users(
userid int primary key,
username varchar(30) unique,
pwd varchar(50)
);

CREATE TABLE userbooks(
userid integer references users(userid),
bookid integer references books(bookid),
lastread text,
constraint pk_userbooks primary key(userid,bookid)
);