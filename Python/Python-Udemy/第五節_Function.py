#Function 自製化程序

#water(參數)
def wash(dry=False, water=8):
    print('加水', water, '分滿')
    print('加洗衣精')
    print('旋轉')
    if dry:
        print('烘衣服')

wash() #使用Function

#參數放入數字
def add(x, y):
    print(x + y)
add(3, 4)
add(123, 2323)

#指定參數
def adds(x=6, y=2):
    print(x + y)
adds(5)
adds(y=6)
