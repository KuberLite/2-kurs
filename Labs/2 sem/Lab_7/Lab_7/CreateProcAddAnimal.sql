create proc AnimalsAdd
@nameAnimal varchar(50),
@classAnimal varchar(50),
@age int,
@curator int
as
insert into Animals(nameAnimal, classAnimal, age, curator)
values (@nameAnimal, @classAnimal, @age, @curator)