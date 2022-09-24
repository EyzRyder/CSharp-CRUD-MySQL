CREATE DATABASE nossobanco;
USE nossobanco;

create table user(
id bigint(5) primary Key not null auto_increment,
first_name varchar(50) not null,
last_name varchar(50) not null,
address varchar(250) 
);

create table admin(
id bigint primary Key not null auto_increment,
user_name varchar(30) not null,
user_password int(8) not null
);
