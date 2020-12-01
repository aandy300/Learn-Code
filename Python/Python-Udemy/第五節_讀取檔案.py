#寫入檔案

products = []
print('為更改前', products)
#讀取寫都得統一格式  
with open('products.csv', 'r', encoding='utf-8') as f:
    for line in f:
            print('讀取到的', products)
            name, price = line.strip().split(',') # 先去除換行符號 在執行切割 # spilt = 切割完的結果是清單
            #|| 直接將內容存入 EX 拉麵,280 存入 name,price 如果有三個目標就得有三個容器
            products.append([name, price])

while True :
    name = input('請輸入名稱')
    if name == 'q':
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
print(products)

for p in products :
    print(p[0], '的價格', p[1])

#存入'products.csv'

with open('products.csv', 'w', encoding='utf-8') as f: # 'w'= 寫入 #encoding='utf-8' = 指定存取為 utf-8 格式
    f.write('商品,價格\n') #新增標題
    for p in products:
        f.write(p[0] + ',' + str(p[1]) + '\n') # \n = 空白 ','在excel會自動換格子 
        # 因為文字只能加文字不能加數字  str(p[1]) 轉換為字串