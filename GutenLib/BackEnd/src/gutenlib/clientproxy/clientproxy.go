package main

import (
	"fmt"
	"gutenlib/dbdriver"
	"io"
	"net/http"
	"os"
	"strconv"
	"time"
)

func main() {
	fmt.Println("Starting http file server")

	//-- CREATE --//
	http.HandleFunc("/AddToUserBooks", AddToUserBooks) //DONE
	http.HandleFunc("/AddUser", AddUser)               // DONE

	//-- READ --//
	http.HandleFunc("/", GetGutenLib)                //DONE
	http.HandleFunc("/GutenLib", GetGutenLib)        //DONE
	http.HandleFunc("/GetBookFile", GetBookFile)     // NOT NEEDED
	http.HandleFunc("/GetUserLib", GetUserLib)       // DONE
	http.HandleFunc("/ValidateUser", ValidateUser)   // DONE
	http.HandleFunc("/ValidateLogin", ValidateLogin) // DONE

	//-- UPDATE --//
	http.HandleFunc("/UpdateLastRead", UpdateLastRead) // DONE
	http.HandleFunc("/ChangePassword", ChangePassword) // DONE
	//-- DELETE --//
	http.HandleFunc("/DeleteFromUserLib", DeleteFromUserLib) //DONE
	http.HandleFunc("/DeleteUser", DeleteUser)               // NOT NEEDED

	err := http.ListenAndServe(":8080", nil)
	if err != nil {
		fmt.Println(err)
	}

}

func DeleteFromUserLib(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	useridInput := request.URL.Query().Get("userid")
	bookidInput := request.URL.Query().Get("bookid")
	if useridInput == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}

	if bookidInput == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}

	t := time.Now()
	fmt.Println("Client request:\nDeleteFromUserLib. User: " + useridInput + " Book:" + bookidInput + "\nTimestamp: " + t.String())

	userid, _ := strconv.Atoi(useridInput)
	bookid, _ := strconv.Atoi(bookidInput)
	validation := dbdriver.DeleteFromUserLibDB(userid, bookid)

	if validation == true {
		io.WriteString(writer, "book deleted from userlib")
	} else {
		http.Error(writer, "delete userlib book error", 400)
		return
	}

}

func AddToUserBooks(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	useridInput := request.URL.Query().Get("userid")
	bookidInput := request.URL.Query().Get("bookid")

	if useridInput == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}

	if bookidInput == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: AddToUserLib. User: " + useridInput + " Book:" + bookidInput)
	userid, _ := strconv.Atoi(useridInput)
	bookid, _ := strconv.Atoi(bookidInput)

	validation := dbdriver.AddToUserBooksDB(bookid, userid)

	if validation == true {
		io.WriteString(writer, "added book to user library")
	} else {
		http.Error(writer, "input error", 400)
		return
	}
}

func ChangePassword(writer http.ResponseWriter, request *http.Request) {

}

func AddUser(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	username := request.URL.Query().Get("username")
	pwd := request.URL.Query().Get("pwd")
	fmt.Println(username)
	if username == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'username' not specified in url.", 400)
		return
	}

	if pwd == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'pwd' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: AddUser Username: " + username + " pwd:" + pwd)

	validation := dbdriver.AddUserDB(username, pwd)

	if validation == true {
		io.WriteString(writer, "user added successfully")
	} else {
		http.Error(writer, "add user error", 400)
		return
	}

}

func DeleteUser(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	username := request.URL.Query().Get("username")
	pwd := request.URL.Query().Get("pwd")
	if username == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'username' not specified in url.", 400)
		return
	}

	if pwd == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'pwd' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: DeleteUser Username: " + username + " pwd:" + pwd)

	validation := dbdriver.DeleteUserDB(username, pwd)

	if validation == true {
		io.WriteString(writer, "user deleted successfully")
	} else {
		http.Error(writer, "user delete failure", 400)
		return
	}

}

func GetUserLib(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	userid := request.URL.Query().Get("userid")
	if userid == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}
	t := time.Now()
	fmt.Println("Client requests: " + userid + "\nTime-Log: " + t.String())
	writer.Header().Set("Content-Type", "application/json; charset=utf-8") // normal header
	id, _ := strconv.Atoi(userid)
	userlib := dbdriver.GetUserLibDB(id)
	io.WriteString(writer, userlib)
}

func UpdateLastRead(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	useridInput := request.URL.Query().Get("userid")
	bookidInput := request.URL.Query().Get("bookid")

	if useridInput == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}

	if bookidInput == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: UpdateLastRead. User: " + useridInput + " Book:" + bookidInput)
	userid, _ := strconv.Atoi(useridInput)
	bookid, _ := strconv.Atoi(bookidInput)

	validation := dbdriver.UpdateLastReadDB(userid, bookid)
	if validation {
		io.WriteString(writer, "last read updated")
	} else {
		http.Error(writer, "failed lastread update", 400)
		return
	}
}

func ValidateUser(writer http.ResponseWriter, request *http.Request) {
	username := request.URL.Query().Get("username")

	if username == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'username' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: ValidateUser Username: " + username)

	validation := dbdriver.ValidateUserDB(username)
	if validation {
		io.WriteString(writer, "valid user")
	} else {
		http.Error(writer, "invalid user", 400)
		return
	}

}

func ValidateLogin(writer http.ResponseWriter, request *http.Request) {
	username := request.URL.Query().Get("username")
	pwd := request.URL.Query().Get("pwd")
	if username == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'username' not specified in url.", 400)
		return
	}

	if pwd == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'pwd' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: ValidateLogin Username: " + username + "Pwd: " + pwd)

	validation, userid := dbdriver.ValidateLoginDB(username, pwd)
	if validation {
		io.WriteString(writer, userid)
	} else {
		http.Error(writer, "invalid user", 400)
		return
	}

}

func GetGutenLib(writer http.ResponseWriter, request *http.Request) {
	t := time.Now()
	fmt.Println("Client requests:\nGutenLib\nTimestamp:" + t.String())
	writer.Header().Set("Content-Type", "application/json; charset=utf-8") // normal header
	gutenlib := dbdriver.GetGutenLibDB()
	io.WriteString(writer, gutenlib)
}

func GetBookFile(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	bookid := request.URL.Query().Get("bookid")
	if bookid == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}
	t := time.Now()
	fmt.Println("Client requests: " + bookid + ".epub\nTime-Log: " + t.String())

	//Check if file exists and open

	Openfile, err := os.Open(bookid + ".epub")
	defer Openfile.Close() //Close after function return
	if err != nil {
		//File not found, send 404
		http.Error(writer, "File not found.", 404)
		return
	}

	//File is found, create and send the correct headers

	//Get the Content-Type of the file
	//Create a buffer to store the header of the file in
	FileHeader := make([]byte, 512)
	//Copy the headers into the FileHeader buffer
	Openfile.Read(FileHeader)
	//Get content type of file
	FileContentType := http.DetectContentType(FileHeader)

	//Get the file size
	FileStat, _ := Openfile.Stat()                     //Get info from file
	FileSize := strconv.FormatInt(FileStat.Size(), 10) //Get file size as a string

	//Send the headers
	writer.Header().Set("Content-Disposition", "attachment; filename="+bookid+".epub")
	writer.Header().Set("Content-Type", FileContentType)
	writer.Header().Set("Content-Length", FileSize)

	//Send the file
	//We read 512 bytes from the file already so we reset the offset back to 0
	Openfile.Seek(0, 0)
	io.Copy(writer, Openfile) //'Copy' the file to the client
	return
}
