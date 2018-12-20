-- Insert compensation
CREATE OR ALTER PROCEDURE insert_compensation
	@title		NVARCHAR(32),
	@employee	INT
AS
BEGIN

	INSERT INTO VolaCompensation (title, employee) OUTPUT INSERTED.ID VALUES
	(@title, @employee);

END
GO

-- Insert travel compensation
CREATE OR ALTER PROCEDURE insert_travel_compensation
	@title			NVARCHAR(32),
	@employee		INT,
	@departuredate	DATETIME2,
	@returndate		DATETIME2,
	@overnightstay	BIT,
	@credit			FLOAT
AS
BEGIN

	EXEC insert_compensation @title, @employee;

	INSERT INTO VolaTravel (compensation, departuredate, returndate, overnightstay, credit) VALUES
	(IDENT_CURRENT('VolaCompensation'), @departuredate, @returndate, @overnightstay, @credit);

END
GO

-- Insert driving compensation
CREATE OR ALTER PROCEDURE insert_driving_compensation
	@title			NVARCHAR(32),
	@employee		INT,
	@numberplate	NVARCHAR(32)
AS
BEGIN

	EXEC insert_compensation @title, @employee;

	INSERT INTO VolaDriving (compensation, numberplate) VALUES
	(IDENT_CURRENT('VolaCompensation'), @numberplate);

END
GO

-- Insert appendix
CREATE OR ALTER PROCEDURE insert_appendix
	@title	NVARCHAR(32)
AS
BEGIN

	INSERT INTO VolaAppendix(title) OUTPUT INSERTED.ID VALUES
	(@title);

END
GO

-- Insert expenditure appendix
CREATE OR ALTER PROCEDURE insert_expenditure_appendix
	@title			NVARCHAR(32),
	@expensetype	INT,
	@cash			BIT,
	@date			DATETIME2,
	@amount			FLOAT,
	@travel			INT
AS
BEGIN

	EXEC insert_appendix @title;

	INSERT INTO VolaExpenditure (appendix, expensetype, cash, [date], amount, travel) VALUES
	(IDENT_CURRENT('VolaAppendix'), @expensetype, @cash, @date, @amount, @travel);

END
GO

-- Insert trip appendix
CREATE OR ALTER PROCEDURE insert_trip_appendix
	@title					NVARCHAR(32),
	@departuredestination	NVARCHAR(64),
	@departuredate			DATETIME2,
	@arrivaldestination		NVARCHAR(64),
	@arrivaldate			DATETIME2,
	@distance				INT,
	@driving				INT
AS
BEGIN

	EXEC insert_appendix @title;

	INSERT INTO VolaTrip (appendix, departuredestination, departuredate, arrivaldestination, arrivaldate, distance, driving) VALUES
	(IDENT_CURRENT('VolaAppendix'), @departuredestination, @departuredate, @arrivaldestination, @arrivaldate, @distance, @driving);

END
GO

-- Get Employee by id
CREATE OR ALTER PROCEDURE GetEmployeeById
	@id	INT
AS
BEGIN

	SELECT fullname, department
	FROM VolaEmployee
	WHERE id = @id;

END
GO

-- Get Department by id
CREATE OR ALTER PROCEDURE GetDepartmentById
	@id	INT
AS
BEGIN

	SELECT id, boss
	FROM VolaDepartment
	WHERE id = @id;

END
GO

-- Get all Travel
CREATE OR ALTER PROCEDURE GetTravelById
	@employee	INT
AS
BEGIN

	SELECT id, title, employee, departuredate, returndate, overnightstay, credit
	FROM VolaTravel
	LEFT JOIN VolaCompensation
	ON VolaCompensation.id = VolaTravel.compensation
	WHERE employee = @employee;

END
GO

-- Get all Driving
CREATE OR ALTER PROCEDURE GetDrivingById
	@employee	INT
AS
BEGIN

	SELECT id, title, employee, numberplate
	FROM VolaDriving
	LEFT JOIN VolaCompensation
	ON VolaCompensation.id = VolaDriving.compensation
	WHERE employee = @employee;

END
GO

CREATE OR ALTER PROCEDURE GetExpenditureByTravel
	@travel	INT
AS
BEGIN

	SELECT id, title, expensetype, cash, [date], amount
	FROM VolaExpenditure
	LEFT JOIN VolaAppendix
	ON VolaAppendix.id = VolaExpenditure.appendix
	WHERE travel = @travel;

END
GO

CREATE OR ALTER PROCEDURE GetTripByDriving
	@driving	INT
AS
BEGIN

	SELECT id, title, departuredestination, departuredate, arrivaldestination, arrivaldate, distance
	FROM VolaTrip
	LEFT JOIN VolaAppendix
	ON VolaAppendix.id = VolaTrip.appendix
	WHERE driving = @driving;

END
GO