#range
#python 內建清單產生器

# 90% 以上 for i in range 是為了 執行固定次數

# d = 暫存 可以當次數
for d in range(10) :
    print('hi') #印5次hi
    print('這是第', d,'次印出hi')

#延伸

range(5) #0.1.2.3.4
range(3) #0.1.2

range(2, 5) #2.3.4
range(8, 10) #8.9
range(2, 10, 3) #2.5.8
range(10, 2, -2) #10.8.6.4
