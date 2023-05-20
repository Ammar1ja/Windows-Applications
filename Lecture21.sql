Use Lecture21
/*Create new table in the database and give him attributes*/
Create Table Students 
(
	StudentId int PRIMARY KEY Identity(1,1),
	StudentName nvarchar(50) not null
)
Insert into Students(StudentName) values('Ammar Jaber')
Insert into Students(StudentName) values('Ahmad Shraim')
Insert into Students(StudentName) values('Khalid Ahmad')
Insert into Students(StudentName) values('Issam Azelhad')
Insert into Students(StudentName) values('Baraa Mohammed')
Select * from Students /*Read / Retrieve*/
