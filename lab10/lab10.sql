use Univer1
ALTER TABLE Student
ADD CONSTRAINT UF_Users UNIQUE (Email);

INSERT INTO Student (Email, Password, Firstname, Secondname) VALUES ('vika@gmail.com', '4213312', 'Viktoria', 'Shakhlai')

Truncate Table Student