CREATE TABLE admin
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password_hash VARCHAR(MAX) NULL,
	date_created DATE NULL
)
