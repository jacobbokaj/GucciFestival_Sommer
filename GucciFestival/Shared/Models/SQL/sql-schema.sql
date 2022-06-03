-- PROCEDURE: public.create_user5(text, date, text, integer, text, integer[])

-- DROP PROCEDURE IF EXISTS public.create_user5(text, date, text, integer, text, integer[]);

CREATE OR REPLACE PROCEDURE public.create_user5(
	_name text,
	_birthday date,
	_email text,
	_phone integer,
	_password text,
	_kompetence_id integer[])
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
co_id int;
us_id int;

BEGIN

INSERT INTO "User" (name, birthday,email,phone, password,type_id, type)
VALUES (_name,_birthday,_email,_phone,_password,2,'frivillig') returning user_id into us_id;
foreach co_id IN ARRAY $6 
loop
insert into "User_competence"("User_user_id", competence_competence_id) values (us_id, co_id);
end loop; 

end
$BODY$;

GRANT EXECUTE ON PROCEDURE public.create_user5(text, date, text, integer, text, integer[]) TO "Anders95";

GRANT EXECUTE ON PROCEDURE public.create_user5(text, date, text, integer, text, integer[]) TO user_festival WITH GRANT OPTION;

GRANT EXECUTE ON PROCEDURE public.create_user5(text, date, text, integer, text, integer[]) TO PUBLIC;



-- PROCEDURE: public.delete_user1(integer)

-- DROP PROCEDURE IF EXISTS public.delete_user1(integer);

CREATE OR REPLACE PROCEDURE public.delete_user1(
	_user_id integer)
LANGUAGE 'plpgsql'
AS $BODY$

BEGIN

DELETE FROM "User_competence" WHERE "User_user_id" = _user_id; 
Delete from "User" Where user_id = _user_id ;  

end
$BODY$;

-- PROCEDURE: public.update_user1(text, date, text, integer, text, integer, integer[])

-- DROP PROCEDURE IF EXISTS public.update_user1(text, date, text, integer, text, integer, integer[]);

CREATE OR REPLACE PROCEDURE public.update_user1(
	_name text,
	_birthday date,
	_email text,
	_phone integer,
	_password text,
	_user_id integer,
	_kompetence_id integer[])
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
co_id int;

BEGIN
IF EXISTS (SELECT FROM "User" WHERE user_id = _user_id) THEN

DELETE FROM "User_competence" WHERE "User_user_id" = _user_id; 

foreach co_id IN ARRAY $7
loop
insert into "User_competence"("User_user_id", competence_competence_id) values (_user_id, co_id);
end loop; 

Update "User"
SET name = _name
where user_id = _user_id;

Update "User"
SET birthday = _birthday
where user_id = _user_id;

Update "User"
SET email = _email
where user_id = _user_id;

Update "User"
SET phone = _phone
where user_id = _user_id;

Update "User"
SET password = _password
where user_id = _user_id;

ELSE
RAISE EXCEPTION 'Brugeren med id % blev ikke fundet.', _user_id;
END IF;
end
$BODY$;