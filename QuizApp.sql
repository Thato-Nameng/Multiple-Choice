CREATE DATABASE QuizApp
GO

USE QuizApp;
GO

CREATE TABLE Questions(
Id INT IDENTITY(1,1) PRIMARY KEY,
Subjects VARCHAR(250) NOT NULL,
Test_Type VARCHAR(250) NOT NULL,
Question_No VARCHAR(250) NOT NULL,
Question VARCHAR(350) NOT NULL,
OptionA VARCHAR(250) NOT NULL,
OptionB VARCHAR(250) NOT NULL,
OptionC VARCHAR(250) NOT NULL,
OptionD VARCHAR(250) NOT NULL,
Ans VARCHAR(250) NOT NULL
);

SELECT * FROM Questions
SELECT * FROM Registration

SELECT DISTINCT Subjects FROM Questions
SELECT MAX(Subjects) FROM Questions

CREATE TABLE Registration (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    DateOfBirth DATE,
    Subject NVARCHAR(50),
    Email NVARCHAR(100),
    Password NVARCHAR(64), 
    StudentNumber NVARCHAR(50)
);

SELECT * FROM UserResponse;
SELECT * FROM UserQuestion;

CREATE TABLE UserQuestion (
    ID INT PRIMARY KEY IDENTITY(1, 1),
    RegistrationID INT,
    QuestionID INT,
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Subject NVARCHAR(50),
    Test_Type NVARCHAR(250) NOT NULL,
    Question_No INT NOT NULL,
    Question NVARCHAR(350),
    OptionA NVARCHAR(250),
    OptionB NVARCHAR(250),
    OptionC NVARCHAR(250),
    OptionD NVARCHAR(250),
    Ans NVARCHAR(250) NOT NULL,
    FOREIGN KEY (RegistrationID) REFERENCES Registration(ID),
    FOREIGN KEY (QuestionID) REFERENCES Questions(Id)
);

CREATE TABLE UserResponse (
    ID INT PRIMARY KEY IDENTITY(1, 1),
    RegistrationID INT NOT NULL,
    QuestionID INT NOT NULL,
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Subject NVARCHAR(50) NOT NULL,
    Test_Type NVARCHAR(250) NOT NULL,
    Question_No NVARCHAR(250) NOT NULL,
    User_Answer NVARCHAR(250) NULL,
    Ans NVARCHAR(250) NOT NULL,
    FOREIGN KEY (RegistrationID) REFERENCES Registration(ID),
    FOREIGN KEY (QuestionID) REFERENCES Questions(Id)
);

INSERT INTO UserResponse (RegistrationID, QuestionID, Name, Surname, Subject, Test_Type, Question_No, User_Answer, Ans)
SELECT 
    R.ID AS RegistrationID,
    Q.ID AS QuestionID,
	R.Name,
	R.Surname,
    R.Subject AS Subject,
    Q.Test_Type, 
    Q.Question_No,
    '' AS User_Answer,
    Q.Ans
FROM Questions Q
JOIN Registration R ON Q.Subjects = R.Subject;
ALTER TABLE UserResponse ALTER COLUMN User_Answer NVARCHAR(250) NULL;


INSERT INTO UserQuestion (RegistrationID, QuestionID, Name, Surname, Subject, Test_Type, Question_No, Question, OptionA, OptionB, OptionC, OptionD, Ans)
SELECT 
    R.ID AS RegistrationID,
    Q.ID AS QuestionID,
    R.Name,
    R.Surname,
    R.Subject AS Subject,
    Q.Test_Type, 
    Q.Question_No,
    Q.Question,
    Q.OptionA,
    Q.OptionB,
    Q.OptionC,
    Q.OptionD,
    Q.Ans
FROM Questions Q
JOIN Registration R ON Q.Subjects = R.Subject;
