#字串分割3

datas = []
with open('sample/3.txt', 'r', encoding='utf-8-sig') as f:
        for data in f:
            datas.append(data.strip())
for data in datas:
    s = data.split(' ')
    time = s[0][:5] #清單0的 前5個 0~5
    name = s[0][5:] #5之後的所有
    print(name)