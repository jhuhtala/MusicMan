--USE master;
--GO
--ALTER DATABASE MusicMan SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--GO

--DROP DATABASE MusicMan;

--GO

CREATE DATABASE MusicMan;

GO

Use MusicMan;

Go

Create table Users
(
	UserID int IDENTITY(1, 1) PRIMARY KEY,
	Email varchar(50) ,
	PasswordHash varchar(65) NOT NULL,
	CompanyName varchar(50) ,
	PayPalEmail varchar(50) ,
	VenmoUser varchar(50) ,
    TwilioAccountSid varchar(50) ,
	TwilioAuthToken varchar(50) ,
	TwilioPhoneNumber varchar(10) ,
)


CREATE TABLE Person  
(  
	PersonID int IDENTITY(1, 1) PRIMARY KEY, 
	FirstName varchar(50)  ,
	LastName varchar(50)  ,
	Email varchar(50)  ,
	Phone varchar(10) ,
	Rate int,
	IsActive bit,
	IsParent bit,
	InvoiceDay int,
	IsPaypal bit,
	IsVenmo bit,
)

Create Table BillingDetail
(
	BillingDetailID int IDENTITY(1, 1) PRIMARY KEY, 
	PersonID int,
	Amount Decimal(6,2),
	IsInvoiced bit,
	IsPaid bit,
	BilledDate datetime,
	PaidDate datetime,
    BillMonth datetime,
	CONSTRAINT FK_PersonBillingDetail FOREIGN KEY (PersonID)
    REFERENCES Person(PersonID)
)

Create Table Relationship
(
	RelationshipID int IDENTITY(1, 1) PRIMARY KEY, 
	ParentID int,
	ChildID int,
	CONSTRAINT FK_ParentRelationship FOREIGN KEY (ParentID)
    REFERENCES Person(PersonID),
	CONSTRAINT FK_ChildRelationship FOREIGN KEY (ChildID)
    REFERENCES Person(PersonID)
)

Create Table Note
(
	NoteID int IDENTITY(1, 1) PRIMARY KEY,
	PersonID int,
	Date DateTime,
	Note varchar(max),
    IsSent bit,
	CONSTRAINT FK_PersonNote FOREIGN KEY (PersonID)
    REFERENCES Person(PersonID)
)

Create Table Schedule
(
	ScheduleID  int IDENTITY(1, 1) PRIMARY KEY,
	PersonID int,
	DayOfTheWeek int,
	TimeOfDay Time(0),
	CONSTRAINT FK_PersonSchedule FOREIGN KEY (PersonID)
    REFERENCES Person(PersonID)
)

