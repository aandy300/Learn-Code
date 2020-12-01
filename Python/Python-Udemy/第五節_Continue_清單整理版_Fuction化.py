#購買清單整理版

#運作概念
#products = [] 開始時為空的-> 讀取檔案寫入過往資料 -> 使用者輸入新資料,寫入在過往資料後面 -> 印出目前所有資料 -> 存取檔案

import os # operating system
import sys

products = []
filename = 'products.csv'

def readfile(): #讀取檔案
    with open(filename, 'r', encoding='utf-8') as f:
        for line in f:
            if '商品,價格' in line:
                continue #跳過這一次迴圈
            name, price = line.strip().split(',') # 先去除換行符號 在執行切割 # spilt = 切割完的結果是清單
            #|| 直接將內容存入 EX 拉麵,280 存入 name,price 如果有三個目標就得有三個容器
            products.append([name, price])
    return products
    
def userinput(): #讓使用者輸入
    print('輸入q結束輸入', '輸入showlist看過往清單')
    while True : 
        name = input('請輸入名稱')
        if name == 'q':
            break
        elif name == 'showlist':
            print('過往購物清單 ')
            showlist()
            userinput()
            break
        price = input('請輸入價格')
        price = int(price) #字串轉會為數字Str
        # p = []
        # p.append(name)
        # p.append(price)
        # || 以下簡寫
        # p = [name, price]
        # || 更簡寫
        products.append([name, price])
    return products

def showlist(): #印出購買清單
    for p in products :
        print(p[0], '的價格', p[1])

def savefile(): #存取檔案
    with open('products.csv', 'w', encoding='utf-8') as f: # 'w'= 寫入 #encoding='utf-8' = 指定存取為 utf-8 格式
        f.write('商品,價格\n') #新增標題
        for p in products:
            f.write(p[0] + ',' + str(p[1]) + '\n') # \n = 空白 ','在excel會自動換格子 
            # 因為文字只能加文字不能加數字  str(p[1]) 轉換為字串
    print('結束輸入,已存檔')

def main(): #確認檔案是否存在
    if os.path.isfile(filename):
        print('找到檔案,繼續作業...')
    else:
        print('找不到檔案')

main()
products = readfile()
products = userinput()
savefile()