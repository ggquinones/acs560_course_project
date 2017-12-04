from epub_meta import get_epub_metadata, get_epub_opf_xml, EPubException
import os
import sqlite3
conn = sqlite3.connect('GutenLib.db')
c = conn.cursor()
print("Strarting process....")
count =0
for filename in os.listdir("books"):
	#print("Processing...."+ filename)
	try:
		metadata = get_epub_metadata('books/'+filename.strip() ,read_cover_image=False, read_toc=False)
		
		bookid = int(filename[:len(filename)-5])
		viewlink= "https://www.gutenberg.org/files/"+str(bookid)+"/"+str(bookid)+"-h/"+str(bookid)+"-h.htm"
		title = metadata["title"].decode("utf-8")
		author =metadata["authors"][0].decode("utf-8")
		subject = metadata["subject"]
		c.execute('INSERT INTO books VALUES (?,?,?,?,?)', [bookid,title,author,subject,viewlink])
		
		print("bookid"+str(bookid)+"\ntitle: "+title+"\nauthor: "+author+"\nsubject: "+subject+"\nlink: "+viewlink)
		print("------")
		count+=1	
	except :
		print("Error "+ filename)
		continue
conn.commit()
conn.close()

print("--- PROCESS COMPLETE ---" + str(count))
