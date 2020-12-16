# redaline
# fileObject.readlines();
import os

openfilename = 'C:/Users/admin/Desktop/test.txt' # 要開啟的檔案路徑

with open (openfilename, 'r', encoding='UTF-8') as file :  

    # readline
    z = file.readline()
    print(z) 
    
    # readlines
    for line in file.readlines():
        line = line.strip() 
        print(line)
