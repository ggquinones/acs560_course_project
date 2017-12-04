from urllib2 import urlopen as uReq
from bs4 import BeautifulSoup as soup

baseurl= 'https://www.gutenberg.org'

urlext = '/browse/scores/top'

'''
uclient = uReq(baseurl+urlext)
page_html = uclient.read()
uclient.close()
soup = soup("","html.parser")
firstList = soup.ol
limit = len(soup.ol.contents)
for x in range(0,limit):
	print(soup.ol.contents[x])
	
'''	 

uclient = uReq(baseurl+urlext)
page_html = uclient.read()
uclient.close()
page_soup = soup(page_html,"html.parser")
container= page_soup.findAll("a")

for item in container:
	if 'ebooks' in item['href']:
		print(item['href'][8:])

