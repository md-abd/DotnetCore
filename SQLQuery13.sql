create table FacultyInformation
(
Faculty_ID int primary key identity(1,1),
Faculty_Name varchar(50),
Highest_Qualification varchar(50),
Year_of_Experience varchar(50),
Contact varchar(50),
Faculty_Email varchar(50),
Address varchar(50)
)



create table FacultyCertification
(
Faculty_ID int primary key identity(1,1),
Faculty_Skill varchar(50),
Faculty_Skill1 varchar(50),
Faculty_Skill2 varchar(50),
Certification_Title varchar(50)
)



create table ModuleRegistration
(
M_ID int primary key identity(1,1),
Technology_Name varchar(50),
Domain_Description varchar(50),
Module_Type varchar(50),
Duration varchar(50)
)



create table BatchAllocation
(
Domain_ID int primary key identity(1,1),
Faculty_ID int,
Batch_start_date varchar(50),
Batch_end_date  varchar(50)
)



create table BatchUpdateForm
(
Faculty_ID int
)



create table BatchUpdateSearch
(
ID int primary key identity(1,1),
Batch_id int,
Faculty_Id int,
Batch_Start_Date varchar(50),
Batch_End_Date  varchar(50)  ,
Batch_Closure_Date  varchar(50)
)




create table ReportManagement
(
ID int primary key identity(1,1),
Batch_Code varchar(50)
)



create table ReportSubmission
(
Id int primary key IDENTITY(1,1),
Batch_Code varchar(50),
Faculty_Id varchar(20),
Submitted_Weekly_Reports varchar(50),
Mock_Tests_Conducted varchar(50),
BHS_Report_submitted varchar(50),
Innovation_Project_Title varchar(50),
Innovation_Project_Description varchar(50),
Project_Status varchar(50)
)




create table FacultySearch
(
Faculty_id 
)



create table BatchInfoTable
(
ID int primary key identity(1,1),
Batch_id int,
Faculty_Id int,
Batch_Start_Date varchar(50),
Batch_End_Date  varchar(50)  ,
Batch_Closure_Date  varchar(50)
)



create table BatchScreen
(
F_ID int primary key IDENTITY(1,1),
Batch_Id int,
Feedback_Percentage int,
Extra_Hours int,
BatchPass_Percentage int,
Faculty_Upgrade varchar(50),
Certification_Done varchar(50),
Handson_Completion int
)


create table Login
( id int primary key IDENTITY(1,1),
UserName varchar(50),
Password varchar(50)
)


















