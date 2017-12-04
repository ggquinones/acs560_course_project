import os
from urllib2 import urlopen as uReq
from bs4 import BeautifulSoup as soup



for filename in os.listdir("robot"):	
	page_soup = soup(open("robot/"+filename),"html.parser")
	container= page_soup.findAll("a")
	for item in container:
		if "harvest" not in item["href"]:
			print(item['href'])
	
