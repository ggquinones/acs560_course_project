package main

import (
	"DBDriver"
	"fmt"
	"io"
	"net/http"
	"os"
	"strconv"
)

func main() {
	fmt.Println("Starting http file sever")
	http.HandleFunc("/GetBook", GetBook)
	http.HandleFunc("/GetUserLib", GetUserLib)
	http.HandleFunc("/GetGutenLib", GetGutenLib)

	http.HandleFunc("/AddToUserLib", AddToUserLib)
	http.HandleFunc("/DeleteFromUserLib", DeleteFromUserLib)
	err := http.ListenAndServe(":8080", nil)
	if err != nil {
		fmt.Println(err)
	}

}

func DeleteFromUserLib(writer http.ResponseWriter, request *http.Request){
	//First of check if Get is set in the URL
	useridInput := request.URL.Query().Get("userid")
	bookidInput := request.URL.Query().Get("bookid")
	if useridInput == ""  {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}

	if bookidInput == ""{
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}
	fmt.Println("Client requests: DeleteFromUserLib. User: " + useridInput +" Book:" + bookidInput)
	userid,_ :=strconv.Atoi(useridInput)
	bookid,_ :=strconv.Atoi(bookidInput)
	DBDriver.DeleteFromUserLibDB(bookid,userid)
	writer.Header().Set("Content-Type", "application/json; charset=utf-8") // normal header
	io.WriteString(writer, `{"status":"OK"}` )
}

func AddToUserLib(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	useridInput := request.URL.Query().Get("userid")
	bookidInput := request.URL.Query().Get("bookid")
	if useridInput == ""  {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}

	if bookidInput == ""{
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: AddToUserLib. User: " + useridInput +" Book:" + bookidInput)
	userid,_ :=strconv.Atoi(useridInput)
	bookid,_ :=strconv.Atoi(bookidInput)

	DBDriver.AddToUserLibDB(bookid,userid)

	writer.Header().Set("Content-Type", "application/json; charset=utf-8") // normal header
	io.WriteString(writer, `{"status":"OK"}` )
}

func GetUserLib(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	userid := request.URL.Query().Get("userid")
	if userid == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'userid' not specified in url.", 400)
		return
	}
	fmt.Println("Client requests: " + userid)
	writer.Header().Set("Content-Type", "application/json; charset=utf-8") // normal header
	id,_ :=strconv.Atoi(userid)
	userlib := DBDriver.GetUserLibDB(id)
	io.WriteString(writer, userlib)
}

func GetGutenLib(writer http.ResponseWriter, request *http.Request) {

	fmt.Println("Client requests: GutenLib")
	writer.Header().Set("Content-Type", "application/json; charset=utf-8") // normal header
	gutenlib := DBDriver.GetGutenLibDB()
	io.WriteString(writer, gutenlib)
}

func GetBook(writer http.ResponseWriter, request *http.Request) {
	//First of check if Get is set in the URL
	bookid := request.URL.Query().Get("bookid")
	if bookid == "" {
		//Get not set, send a 400 bad request
		http.Error(writer, "Get 'bookid' not specified in url.", 400)
		return
	}

	fmt.Println("Client requests: " + bookid + ".epub")

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
	writer.Header().Set("Content-Disposition", "attachment; filename="+bookid + ".epub")
	writer.Header().Set("Content-Type", FileContentType)
	writer.Header().Set("Content-Length", FileSize)

	//Send the file
	//We read 512 bytes from the file already so we reset the offset back to 0
	Openfile.Seek(0, 0)
	io.Copy(writer, Openfile) //'Copy' the file to the client
	return
}
