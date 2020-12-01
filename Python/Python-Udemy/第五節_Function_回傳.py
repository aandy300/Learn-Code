#Function 回傳 return

#return 回傳 
def add(x, y):
    return x + y

a = add(6, 8)
print(a)

#sampl a 除 b
def average(number):
    avg = sum(number) / len(number)
    return avg

a = average([1, 5, 6])
print(a)

#簡寫法
def averages(number):
    return sum(number) / len(number)
print(averages([1, 5, 9]))
#averages 加入要算的目標後 return 後 averages 會變為答案 所以可以直接印 averages
