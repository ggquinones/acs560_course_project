

from urllib2 import urlopen as uReq
from bs4 import BeautifulSoup as soup




ids =''
index=1
while index<1000:
	url= 'https://www.gutenberg.org/ebooks/search/?start_index='+str(index)+'&sort_order=downloads'

	uclient = uReq(url)
	page_html = uclient.read()
	uclient.close()
	page_soup = soup(page_html,"html.parser")
	container= page_soup.find("ul",class_="results").findAll("a")

	for item in container:
		if 'search'not in item['href']:
			print(item['href'][8:])
	index+=25
