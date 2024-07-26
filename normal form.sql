CREATE TABLE StudentsNotIn1NF (
    StudentID INT PRIMARY KEY,
    StudentName NVARCHAR(50),
    Courses NVARCHAR(100) 
);

INSERT INTO StudentsNotIn1NF (StudentID, StudentName, Courses)
VALUES
(1, 'Zain ALi', 'Math,Science,English'),
(2, 'Zain Hashmi', 'History,Math,Art');

select * from StudentsNotIn1NF


CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    StudentName NVARCHAR(50)
);


CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName NVARCHAR(50)
);


CREATE TABLE StudentCourses (
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);


INSERT INTO Students (StudentID, StudentName)
VALUES
(1, 'Zain'),
(2, 'Ali');


INSERT INTO Courses (CourseID, CourseName)
VALUES
(1, 'Math'),
(2, 'Science'),
(3, 'English'),
(4, 'History'),
(5, 'Art');


INSERT INTO StudentCourses (StudentID, CourseID)
VALUES
(1, 1), 
(1, 2), 
(1, 3), 
(2, 4), 
(2, 1), 
(2, 5); 

select * from StudentCourses

