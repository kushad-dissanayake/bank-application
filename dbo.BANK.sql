 CREATE DATABASE USERS;

  CREATE TABLE Bank
 (
    Account_No        INTEGER NOT NULL,
    Crd_NO            VARCHAR(10) NOT NULL,
    Full_Name         VARCHAR(50) NOT NULL,
    Account_Balance   INTEGER NOT NULL,
	Passward          INTEGER NOT NULL,
	Phone_No          BIGINT NOT NULL
);

INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1988032456,987654321,'Nimali Weerasinghe',2000,1234,1715669895);
INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1994052465,19990324,'Nimal Wickramarachchi',5000,8642,1761784449);
INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1999032478,123456789,'Kamal Dasanayake',25000,2468,1781569762);
INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1999032412,321564236,'KusalPerera',75000,6543,1415698745);
INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1995012398,156533554,'Chamara Silva',10000,2240,1745369758);
INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1995024578,699855363,'Malith Jayaweera',1100,2595,1762072498);
INSERT INTO Bank (Account_No,Crd_No,Full_Name,Account_Balance,Passward,Phone_No )
VALUES (1563542980,654545522,'Suresh Witharana',45000,1238,1412248516);

SELECT *
FROM Bank;

  CREATE TABLE Manager
 (
    Manager_ID        INTEGER NOT NULL,
    Branch            VARCHAR(10) NOT NULL,
    Full_Name         VARCHAR(50) NOT NULL,
	Passward               INTEGER NOT NULL,
	Phone_No          BIGINT NOT NULL
);

INSERT INTO Manager(Manager_ID,Branch,Full_Name,Passward,Phone_No)
VALUES (256,'Matara','Niroshi Raajapaksha',5678,2345987512);
INSERT INTO Manager (Manager_ID,Branch,Full_Name,Passward,Phone_No)
VALUES (230,'Colombo','Amith Gajanayake',1354,1345975641);
INSERT INTO Manager (Manager_ID,Branch,Full_Name,Passward,Phone_No)
VALUES (158,'Kandy','Sumith Attanayake',1987,4897236547);
INSERT INTO Manager (Manager_ID,Branch,Full_Name,Passward,Phone_No)
VALUES (168,'Galle','Jagath Wanniarachchi',4658,6478513687);
 
SELECT *
FROM Manager;

  CREATE TABLE Accountent
 (
    Accountent_ID     INTEGER NOT NULL,
    Full_Name         VARCHAR(50) NOT NULL,
	Pin_no          INTEGER NOT NULL,
	Phone_No          BIGINT NOT NULL
);

INSERT INTO Accountent(Accountent_ID,Full_Name,Pin_no,Phone_No)
VALUES (1,'Miran Kaluarachchi',5869,1236589535);
INSERT INTO Accountent(Accountent_ID,Full_Name,Pin_no,Phone_No)
VALUES (2,'Charitha Dissanayake',5641,1387564698); 
INSERT INTO Accountent(Accountent_ID,Full_Name,Pin_no,Phone_No)
VALUES (3,'Sman Ekanayake',1671,1987343478); 

 
SELECT *
FROM Accountent;