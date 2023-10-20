create table class (
	id int identity primary key,
	name nvarchar(5) not null
);

create table student (
	number int primary key,
	name nvarchar(200) not null,
	classId int references class(id)
);