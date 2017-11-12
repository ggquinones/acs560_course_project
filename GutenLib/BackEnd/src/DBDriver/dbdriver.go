package DBDriver

import (
	"database/sql"
	"encoding/json"
	"fmt"
	_ "github.com/mattn/go-sqlite3"
	"strings"
	//"time"
)


func GetGutenLibDB() string {
    db, err := sql.Open("sqlite3", "./Library.db")
	checkErr(err)
	//Get Guten Lib
	rows, err := db.Query("select * from books;")
	checkErr(err)
	var bookid int
	var title string
	var author string
	var subject string
	var books string = `{"list":[`

	for rows.Next() {
		err = rows.Scan(&bookid, &title, &author, &subject)
		checkErr(err)
		currBook := &Book{Bookid: bookid, Title: title, Author: author, Subject: subject}
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
	db, err := sql.Open("sqlite3", "./Library.db")
	checkErr(err)

	//Get User Lib
	rows, err := db.Query("select * from books where bookid in(select bookid from userbooks where userid=1);")
	checkErr(err)
	var bookid int
	var title string
	var author string
	var subject string
	var books string = `{"list":[`

	for rows.Next() {
		err = rows.Scan(&bookid, &title, &author, &subject)
		checkErr(err)
		currBook := &Book{Bookid: bookid, Title: title, Author: author, Subject: subject}
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

func AddToUserLibDB(bookid int, userid int) {
	db, err := sql.Open("sqlite3", "./Library.db")
	checkErr(err)

	//Add Book to UserLib
	stmt, err := db.Prepare("INSERT INTO userbooks(bookid,userid) values(?,?)")
	checkErr(err)
	res, err := stmt.Exec(bookid, userid)
	checkErr(err)

	fmt.Println(res.LastInsertId())
	db.Close()
}

func DeleteFromUserLibDB(bookid int, userid int){
	db, err := sql.Open("sqlite3", "./Library.db")
	checkErr(err)
	//Delete Book rom UserLib
	stmt, err := db.Prepare("DELETE FROM userbooks where bookid=? and userid=?")
	checkErr(err)
	res, err := stmt.Exec(bookid, userid)
	checkErr(err)

	fmt.Println(res.RowsAffected())
	db.Close()
}


type Book struct {
	Bookid  int    `json:"bookid"`
	Title   string `json:"title"`
	Author  string `json:"author"`
	Subject string `json:"subject"`
}

//-----------------------------------------------------------------------------------------------------------------------//
//-----------------------------TEST DB SET_UP----------------------------------------------------------------------------//
// used to quickly populate userbooks with test data
func AddUserBooks() {
	//Gabe's List
	AddToUserLibDB(2, 1)
	AddToUserLibDB(3, 1)
	AddToUserLibDB(4, 1)
	//Joe's List
	AddToUserLibDB(1, 2)
	AddToUserLibDB(3, 2)

}

// used for quickly adding test users
func AddUsers() {
	db, err := sql.Open("sqlite3", "./Library.db")
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

	db, err := sql.Open("sqlite3", "./Library.db")
	checkErr(err)

	//Add Book 1
	stmt, err := db.Prepare("INSERT INTO books(title,author,subject) values(?,?,?)")
	checkErr(err)
	res, err := stmt.Exec("Alice's Adventures in Wonderland", "Lewis Carroll", "Fantasy literature")
	checkErr(err)

	//Add Book 2
	stmt, err = db.Prepare("INSERT INTO books(title,author,subject) values(?,?,?)")
	checkErr(err)
	res, err = stmt.Exec("A Christmas Carol in Prose; Being a Ghost Story of Christmas", "Charles Dickens", "Christmas stories")
	checkErr(err)

	//Add Book 3
	stmt, err = db.Prepare("INSERT INTO books(title,author,subject) values(?,?,?)")
	checkErr(err)
	res, err = stmt.Exec("Frankenstein; Or, The Modern Prometheus", "Mary Wollstonecraft Shelley", "Science fiction")
	checkErr(err)

	//Add Book 4
	stmt, err = db.Prepare("INSERT INTO books(title,author,subject) values(?,?,?)")
	checkErr(err)
	res, err = stmt.Exec("Pride and Prejudice", "Jane Austen", "England -- Fiction")
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
