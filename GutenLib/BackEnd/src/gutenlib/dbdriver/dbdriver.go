package dbdriver

import (
	"database/sql"
	"encoding/json"
	"fmt"
	_ "github.com/mattn/go-sqlite3"
	"strconv"
	"strings"
	"time"
)

func GetGutenLibDB() string {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	fmt.Println("connects to db")
	checkErr(err)
	//Get Guten Lib
	rows, err := db.Query("select * from books;")
	checkErr(err)
	var bookid int
	var title string
	var author string
	var subject string
	var viewlink string
	var books string = `{"list":[`

	for rows.Next() {
		err = rows.Scan(&bookid, &title, &author, &subject, &viewlink)
		checkErr(err)
		currBook := &Book{Bookid: bookid, Title: title, Author: author, Subject: subject, Viewlink: viewlink}
		res2B, _ := json.Marshal(currBook)
		books += string(res2B) + ","
	}
	index := strings.LastIndex(books, `,`)
	books2 := books[0:index]
	books2 += `]}`

	rows.Close()
	db.Close()
	return books2
}

func GetUserLibDB(userid int) string {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)

	//Get User Lib
	stmt, err := db.Prepare("select bookid,viewlink from books where bookid in(select bookid from userbooks where userid=?);")
	checkErr(err)
	rows, err := stmt.Query(userid)
	checkErr(err)

	var bookid int
	var viewlink string
	var books string = `{"list":[`

	for rows.Next() {
		err = rows.Scan(&bookid, &viewlink)
		checkErr(err)
		currBook := &UserBook{Bookid: bookid, Viewlink: viewlink}
		res2B, _ := json.Marshal(currBook)
		books += string(res2B) + ","
	}
	index := strings.LastIndex(books, `,`)
	books2 := books[0:index]
	books2 += `]}`

	rows.Close()
	db.Close()
	return books2
}

func AddToUserBooksDB(bookid int, userid int) bool {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)
	lastread := time.Now()
	//Add Book to UserLib
	db.Exec("PRAGMA foreign_keys = ON", nil)
	checkErr(err)

	stmt, err := db.Prepare("INSERT INTO userbooks(userid,bookid,lastread) values(?,?,?);")
	checkErr(err)
	res, err := stmt.Exec(userid, bookid, lastread)
	//checkErr(err)
	if err != nil {
		return false
	} else {
		fmt.Println(res.LastInsertId())
		db.Close()
		return true
	}

}

func ValidateUserDB(username string) bool {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)

	//look for user
	stmt, err := db.Prepare("select * from users where username==?")
	checkErr(err)
	rows, _ := stmt.Query(username)

	checkErr(err)
	return (rows.Next())
}

func ValidateLoginDB(username string, pwd string) (bool, string) {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)

	//look for user
	stmt, err := db.Prepare("select userid from users where username==? and pwd==?")
	checkErr(err)

	rows, _ := stmt.Query(username, pwd)

	if rows.Next() {
		var userid int
		err := rows.Scan(&userid)
		checkErr(err)
		id := strconv.Itoa(userid)
		return true, id
	} else {
		return false, "-1"
	}

}

func AddUserDB(username string, pwd string) bool {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)
	//Add User attempt
	stmt, err := db.Prepare("INSERT INTO users(username,pwd) values(?,?)")
	checkErr(err)
	res, err := stmt.Exec(username, pwd)

	if err != nil || res == nil {
		return false
	} else {
		fmt.Println(res.LastInsertId())
		db.Close()
		return true
	}

}

func DeleteUserDB(username string, pwd string) bool {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)
	db.Exec("PRAGMA foreign_keys = ON", nil)
	checkErr(err)
	//Delete User
	stmt, err := db.Prepare("DELETE FROM users where username=? and pwd=?;")
	checkErr(err)
	res, err := stmt.Exec(username, pwd)
	rows, _ := res.RowsAffected()
	if err != nil || rows == 0 {
		return false
	} else {
		fmt.Println(res.RowsAffected())
		db.Close()
		return true
	}

}

func UpdateLastReadDB(userid int, bookid int) bool {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)
	stmt, err := db.Prepare("UPDATE userbooks SET lastread=? where userid=? and bookid=?")
	checkErr(err)
	res, err := stmt.Exec(time.Now(), userid, bookid)
	//return (res.RowsAffected())
	rows, _ := res.RowsAffected()
	return (rows > 0)
}

func DeleteFromUserLibDB(userid int, bookid int) bool {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)
	db.Exec("PRAGMA foreign_keys = ON", nil)
	checkErr(err)
	//Delete Book from UserLib
	stmt, err := db.Prepare("DELETE FROM userbooks where userid=? and bookid=?")
	checkErr(err)
	res, err := stmt.Exec(userid, bookid)
	checkErr(err)
	rows, _ := res.RowsAffected()
	if err != nil || rows == 0 {
		return false
	} else {
		fmt.Println(res.RowsAffected())
		db.Close()
		return true
	}

}

type Book struct {
	Bookid   int    `json:"bookid"`
	Title    string `json:"title"`
	Author   string `json:"author"`
	Subject  string `json:"subject"`
	Viewlink string `json:"viewlink"`
}

type UserBook struct {
	Bookid   int    `json:"bookid"`
	Viewlink string `json:"viewlink"`
}

//-----------------------------------------------------------------------------------------------------------------------//
//-----------------------------TEST DB SET_UP----------------------------------------------------------------------------//
// used to quickly populate userbooks with test data
func AddUserBooks() {
	//Gabe's List
	AddToUserBooksDB(2, 1)
	AddToUserBooksDB(3, 1)
	AddToUserBooksDB(4, 1)
	//Joe's List
	AddToUserBooksDB(1, 2)
	AddToUserBooksDB(3, 2)

}

// used for quickly adding test users
func AddUsers() {
	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)

	//Add Gabe
	stmt, err := db.Prepare("INSERT INTO users(username,pwdHash) values(?,?)")
	checkErr(err)
	res, err := stmt.Exec("gabe", "pwd")
	checkErr(err)
	//Add Joe
	stmt, err = db.Prepare("INSERT INTO users(username,pwdHash) values(?,?)")
	checkErr(err)
	res, err = stmt.Exec("joe", "pwd2")
	checkErr(err)
	fmt.Println("Users Added!")
	fmt.Println(res.LastInsertId())
	db.Close()

}

// used for quickly creating test db
func AddBooks() {

	db, err := sql.Open("sqlite3", "./GutenLib.db")
	checkErr(err)

	//Add Book 9
	stmt, err := db.Prepare("INSERT INTO books(title,author,subject) values(?,?,?)")
	checkErr(err)
	res, err := stmt.Exec("The Adventures of Tom Sawyer", "Mark Twain", "Humorous stories")
	checkErr(err)

	fmt.Println("Books Added!")
	fmt.Println(res.LastInsertId())
	db.Close()
}

func checkErr(err error) {
	if err != nil {
		panic(err)
	}
}
