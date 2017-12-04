from urllib import urlopen as uReq
from urllib import urlretrieve as uRet
import time
ids=[]
with open('top1000.txt') as f:
	for line in f:
		ids.append(line.strip())
currID =0
with open("getlinks.txt") as f:
	for line in f:
		uRet(line.strip(),ids[currID]+".epub")
		currID+=1
		time.sleep(3)
