# enumerate
#  enumerate(sequence, [start=0])
import os
openfilename = 'C:/Users/admin/Desktop/test.txt' # 要開啟的檔案路徑

with open (openfilename, 'r', encoding='UTF-8') as file :  
    
    food = ['apple', 'banana', 'orange']
    
    print('### normal for loop ###')
    # normal for loop
    i = 0
    for line in food:
        print(i, line)
        i +=1
    
    # enumerate

    # enumerate normal for loop
    print('### enumerate ###')
    for i, line in enumerate(food):
        print(i, line)

    print('### enumerate use start= ###')
    # enumerate use start=
    x = list(enumerate(food, start=100))
    for i, line in x:
        print(i, line)    
