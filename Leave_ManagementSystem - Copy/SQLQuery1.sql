use LMS;

--Create table for Employee 
Create table Employee(EmpID int primary key Identity(1,1),Name varchar(20) Not null,MobileNo bigint,Address varchar(50),Department varchar(20),Gender varchar(10),Dob date,Marital_Status varchar(10)); 
select * from Employee



--create store procedure for Emmployee insert 
create procedure sp_Insert(@Name varchar(20),@MobileNo bigint,@Address varchar(50),@Department varchar(20),@Gender varchar(10),@Dob date,@Marital_Status varchar(10))
as 
begin
insert into Employee values(@Name,@MobileNo,@Address,@Department,@Gender,@DOB,@marital_Status);
end

exec sp_Insert @Name='Keshav',@MobileNo=1234567890,@Address='Thane',@Department='Cs',@Gender='Male',@DOB='2000-04-21',@marital_Status='Single';



--Create store procedure for employee Delete

create procedure sp_Delete(@EmpID bigint)
as
begin
delete from Employee where EmpID=@EmpID;
end

exec sp_Delete @EmpID = 10;



--Create store procedure for employee Update

create procedure sp_Updates(@EmpID bigint,@Name varchar(20),@MobileNo bigint,@Address varchar(50),@Department varchar(20),@Gender varchar(10),@Dob date,@Marital_Status varchar(10))
as 
begin
Update Employee set Name=@Name,MobileNo=@MobileNo,Address=@Address,Department=@Department,Gender=@Gender,Dob=@Dob,Marital_Status=@Marital_Status where EmpID=@EmpID;
end;

exec sp_Update @EmpID = 1,@Name ='Rajesh';



--Create store procedure employee for Show
create procedure sp_Show
as 
begin
Select *from Employee
end;

exec sp_Show



--Create Table for Leaves

Create table Leave(EmpID int primary key,Name varchar(20) Not null, LeaveReason Varchar(50),Leave_Type Varchar(10), LeaveSD date,LeaveED date,Status Varchar(20)); 
select *from Leave



--create store procedure for insert for leaves table
create procedure sp_InsertLeave(@EmpID int,@Name varchar(20),@LeaveReason varchar(50),@LeaveType varchar(50),@LeaveSD date,@LeaveED date,@Status Varchar(20))
as 
begin
insert into Leave values(@EmpID,@Name,@LeaveReason ,@LeaveType,@LeaveSD,@LeaveED,@Status);
end

exec sp_InsertLeave @EmpID=3, @name='Aman',@LeaveReason='sick',@LeaveType='sick',@LeaveSD='2025-07-29',@LeaveED='2025-08-01',@Status='Approved';



--Create store procedure for Show Leave table
create procedure sp_ShowLeave
as 
begin
Select *from Leave
end;

exec sp_ShowLeave


SELECT E.EmpId as EmpID,E.Name as Name,e.MobileNo,e.Address,e.Department,e.Gender,e.Dob,e.Marital_Status,l.LeaveReason,l.Leave_Type,l.LeaveSD,l.LeaveED,l.Status from Employee E inner join Leave L on e.EmpID=l.EmpID



--Create store procedure for update leave table
create procedure sp_UpdateLeave(@EmpID int,@Name varchar(20),@LeaveReason Varchar(50),@Leave_Type Varchar(10),@LeaveSD date,@LeaveED date,@Status Varchar(20))
as
begin
update Leave set Name=@Name,LeaveReason=@LeaveReason,Leave_Type=@Leave_Type,LeaveSD=@LeaveSD,LeaveED=@LeaveED,Status=@Status where EmpID=@EmpID;
end;



--create store procedure for delete Leave table
create procedure sp_DeleteLeave(@EmpID bigint)
as
begin
delete from Leave where EmpID=@EmpID;
end


--Create store procedure for LeaveReports join of Table Employee and leave

create procedure sp_LeaveReports
as
begin
SELECT E.EmpId as EmpID,E.Name as Name,e.MobileNo,e.Address,e.Department,e.Gender,e.Dob,e.Marital_Status,l.LeaveReason,l.Leave_Type,l.LeaveSD,l.LeaveED,l.Status from Employee E inner join Leave L on e.EmpID=l.EmpID

end;

exec sp_LeaveReports




--Store procedure for approved
create procedure sp_LeaveReportsApproved
as
begin
SELECT E.EmpId as EmpID,E.Name as Name,e.MobileNo,e.Address,e.Department,e.Gender,e.Dob,e.Marital_Status,l.LeaveReason,l.Leave_Type,l.LeaveSD,l.LeaveED,l.Status from Employee E inner join Leave L on e.EmpID=l.EmpID where Status='Approved'

end;

--store procedure for Pending

create procedure sp_LeaveReportsPending
as
begin
SELECT E.EmpId as EmpID,E.Name as Name,e.MobileNo,e.Address,e.Department,e.Gender,e.Dob,e.Marital_Status,l.LeaveReason,l.Leave_Type,l.LeaveSD,l.LeaveED,l.Status from Employee E inner join Leave L on e.EmpID=l.EmpID where Status='Pending'

end;

--store procedure for Rejected
create procedure sp_LeaveReportsRejected
as
begin
SELECT E.EmpId as EmpID,E.Name as Name,e.MobileNo,e.Address,e.Department,e.Gender,e.Dob,e.Marital_Status,l.LeaveReason,l.Leave_Type,l.LeaveSD,l.LeaveED,l.Status from Employee E inner join Leave L on e.EmpID=l.EmpID where Status='Rejected'

end;
