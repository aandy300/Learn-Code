#記帳程式

products = []

while True :
    name = input('請輸入名稱')
    if name == 'q':
        break
    price = input('請輸入價格')
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