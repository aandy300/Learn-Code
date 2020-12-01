import random

r = random.randint(1, 1000)
c = 0

while True:
    c += 1
    x = input('請猜數字1~1000')
    
    x = int(x) # 型態轉換
    print(r) # 答案
    if x == r :
        print('中獎','答案為',r ) 
        print('已經猜過',c ,'次')
        break
    elif r <= x:
        print('小於',x )
    elif r >= x:
        print('大於',x )
    else :
        print('請猜1~1000')
    print('已經猜過',c ,'次')
