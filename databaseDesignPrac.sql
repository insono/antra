--Database Design Practice

--1
use master
create database companyProject
use companyProject

create table Office (
	Name varchar(30),
	City varchar(30),
	Country varchar(30),
	Address varchar(30),
	phoneNum varchar(30),
	Director varchar(30),
	projectCode int,
	
	primary key (Name),
	foreign key (City) references City(Name),
	foreign key (projectCode) references Project(projectCode));

create table Project (
	projectCode int,
	Title varchar(30),
	startDate datetime,
	endDate datetime,
	Budget decimal(19,4),
	personInCharge varchar(30),
	
	primary key (projectCode) );

create table City (
	Name varchar(30),
	Country varchar(30),
	numOfInhabitants int,
	
	primary key (Name));

--2
use master
create database lendingCompany
use lendingCompany

create table lenders (
	id int,
	name varchar(30),
	avaliableMoney decimal(19,4),

	primary key(id) );

create table borrowers (
	id int,
	name varchar(30),
	riskValue int,

	primary key(id) );

create table loan (
	loanCode int,
	totalAmount decimal(19,4),
	refundDeadline datetime,
	interestRate decimal(19,4),
	purpose varchar(30),
	lenderID int,
	borrowerID int,

	primary key(loanCode),
	foreign key(lenderID) references lenders(id),
	foreign key(borrowerID) references borrowers(id) );

--3
use master
create database restaurant
use restaurant

create table course (
	name varchar(30),
	description varchar(30),
	photo image,
	price decimal(19,4),
	employeeInCharge varchar(30),
	recipeID int,

	primary key(name),
	foreign key(recipeID) references recipe(id) );

create table recipe (
	id int,
	ingredient varchar(30),
	amount varchar(30),
	unit varchar(30),
	currAmount int,

	primary key(id) );
