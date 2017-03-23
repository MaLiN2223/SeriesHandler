CREATE TABLE UserPermissions(
	id			TINYINT PRIMARY KEY IDENTITY (1,1),
	name		NVARCHAR(100) UNIQUE,
);
CREATE TABLE Users (
	id            INT PRIMARY KEY IDENTITY (1, 1),
	username      NVARCHAR(100) UNIQUE NOT NULL,
	password      VARBINARY(20)       NOT NULL,
	password_salt CHAR(25)            NOT NULL,
	permission    TINYINT FOREIGN KEY REFERENCES UserPermissions (id),
	name          NVARCHAR(64)        NOT NULL,
	surname       NVARCHAR(64)        NOT NULL,
	email		  NVARCHAR(150) UNIQUE NOT NULL
); 

CREATE TABLE Series(
	id			INT PRIMARY KEY IDENTITY (1,1),
	startDate	DATETIME NOT NULL,
	endDate		DATETIME,
	title VARCHAR(150),
	description VARCHAR(MAX)
); 

CREATE TABLE InternalErrors (
  id            INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
  error_name    NVARCHAR(64)        NOT NULL,
  error_time    DATETIME            NOT NULL,
  message       NVARCHAR(3000),
  stack_trace   NVARCHAR(1000)      NOT NULL,
  context       NVARCHAR(900)       NOT NULL,
  inner_message NVARCHAR(400),
);

