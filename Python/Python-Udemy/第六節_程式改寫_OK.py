#程式改寫

filename = 'sample/input.txt'
datas = []

# out put
def output():
    with open('sample/output.txt', 'w', encoding='utf-8-sig') as f:
        # || origin
        # line = []
        # for data in datas:
        #     line.append(data)
        #     f.write(str(line))
        #     print(line)
        # ||
        for data in datas:
            f.write(data + '\n')

# rest text
def resttext():
    new = []
    Says = None
    for data in datas :
        if data == 'Allen':
            Says = 'Allen'
            continue 
        elif data == 'Tom':
            Says = 'Tom'
            continue
        if Says:
            new.append(Says + ': ' + data)
    return new   

# read file
def readfile():
    with open (filename, 'r', encoding='utf-8-sig') as f : # utf-8-sig 去 '\ufeff'
        for texts in f :
            datas.append(texts.strip())
    return datas

# run script
def main():
    readfile()
    resttext()

main()
print(datas)
output()




# for line in f:
#             if '商品,價格' in line:
#                 continue #跳過這一次迴圈
#             name, price = line.strip().split(',') # 先去除換行符號 在執行切割 # spilt = 切割完的結果是清單
#             #|| 直接將內容存入 EX 拉麵,280 存入 name,price 如果有三個目標就得有三個容器
#             products.append([name, price])
#     return products