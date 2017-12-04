


CREATE TABLE userbooks(
userid integer references users(userid) ON DELETE CASCADE,
bookid integer references books(bookid) ON DELETE CASCADE,
lastread text,
constraint pk_userbooks primary key(userid,bookid)
);