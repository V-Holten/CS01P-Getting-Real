-- Link
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'VolaDepartment')
BEGIN
	ALTER TABLE VolaDepartment
	DROP CONSTRAINT FK_DEPARTMENT_EMPLOYEE; 
END;
-- Appendix
DROP TABLE IF EXISTS VolaTrip;
DROP TABLE IF EXISTS VolaExpenditure;
DROP TABLE IF EXISTS VolaAppendix;
-- Compensation
DROP TABLE IF EXISTS VolaDriving;
DROP TABLE IF EXISTS VolaTravel;
DROP TABLE IF EXISTS VolaCompensation;
-- Employee
DROP TABLE IF EXISTS VolaEmployee;
-- Department
DROP TABLE IF EXISTS VolaDepartment;



-- Tables

CREATE TABLE VolaDepartment (
	id		INT				NOT NULL PRIMARY KEY,
	boss	INT				NULL
);

CREATE TABLE VolaEmployee (
	id							INT				NOT NULL PRIMARY KEY,
	fullname					NVARCHAR(64)	NOT NULL,
	department					INT				NOT NULL,

	CONSTRAINT FK_EMPLOYEE_DEPARTMENT FOREIGN KEY (department)
	REFERENCES VolaDepartment (id)
);

ALTER TABLE VolaDepartment
ADD CONSTRAINT FK_DEPARTMENT_EMPLOYEE FOREIGN KEY (boss) REFERENCES VolaEmployee(id);

CREATE TABLE VolaCompensation (
	id			INT				NOT NULL PRIMARY KEY IDENTITY,
	title		NVARCHAR(32)	NOT NULL,
	employee	INT				NOT NULL,

	CONSTRAINT FK_COMPENSATION_EMPLOYEE FOREIGN KEY (employee)
	REFERENCES VolaEmployee (id)
);

CREATE TABLE VolaTravel (
	compensation	INT			NOT NULL PRIMARY KEY,
	departuredate	DATETIME2	NOT NULL,
	returndate		DATETIME2	NOT NULL,
	overnightstay	BIT			NOT NULL,
	credit			FLOAT		NOT NULL,

	CONSTRAINT FK_TRAVEL_COMPENSATION FOREIGN KEY (compensation)
	REFERENCES VolaCompensation (id)
);

CREATE TABLE VolaDriving (
	compensation	INT				NOT NULL PRIMARY KEY,
	numberplate		NVARCHAR(32)	NOT NULL,

	CONSTRAINT FK_DRIVING_COMPENSATION FOREIGN KEY (compensation)
	REFERENCES VolaCompensation (id)
);

CREATE TABLE VolaAppendix (
	id		INT				NOT NULL PRIMARY KEY IDENTITY,
	title	NVARCHAR(32)	NOT NULL
);

CREATE TABLE VolaExpenditure (
	appendix	INT			NOT NULL PRIMARY KEY,
	expensetype	INT			NOT NULL,
	cash		BIT			NOT NULL,
	[date]		DATETIME2	NOT NULL,
	amount		float		NOT NULL,
	travel		INT			NOT NULL,

	CONSTRAINT FK_EXPENDITURE_APPENDIX FOREIGN KEY (appendix)
	REFERENCES VolaAppendix (id),

	CONSTRAINT FK_EXPENDITURE_TRAVEL FOREIGN KEY (travel)
	REFERENCES VolaTravel (compensation)
);

CREATE TABLE VolaTrip (
	appendix				INT				NOT NULL,
	departuredestination	NVARCHAR(64)	NOT NULL,
	departuredate			DATETIME2		NOT NULL,
	arrivaldestination		NVARCHAR(64)	NOT NULL,
	arrivaldate				DATETIME2		NOT NULL,
	distance				INT				NOT NULL,
	driving					INT				NOT NULL,

	CONSTRAINT FK_TRIP_APPENDIX FOREIGN KEY (appendix)
	REFERENCES VolaAppendix (id),

	CONSTRAINT FK_EXPENDITURE_DRIVING FOREIGN KEY (driving)
	REFERENCES VolaDriving (compensation)
);
