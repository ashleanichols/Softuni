USE TableRelations

CREATE TABLE Students(
	PersonID INT NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[Salary] DECIMAL(15,2),
	[PassportID] INT
)

CREATE TABLE Passports(
 PassportsId INT NOT NULL,
 PassportNumber VARCHAR(50)
)

INSERT INTO Students VALUES
(1,'Roberto',43300.00,102),
(2,'Tom',56100.00,103),
(3,'Yana',60200.00,101)

INSERT INTO Passports VALUES 
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

SELECT * FROM Students
SELECT * FROM Passports

ALTER TABLE Students
ADD CONSTRAINT PK_PersonID
PRIMARY KEY(PersonID)

ALTER TABLE Passports
ADD CONSTRAINT PK_PassportsId
PRIMARY KEY(PassportsId)

ALTER TABLE Students
ADD CONSTRAINT FK_StudentsPassport
FOREIGN KEY(PassportID) REFERENCES Passports(PassportsId)