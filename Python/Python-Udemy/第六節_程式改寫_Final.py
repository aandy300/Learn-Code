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
        for data in resttext():
            f.write(data + '\n')

# rest text
def resttext():
    new = []
    # print('rest text_UP', datas)
    Says = None # null 防止程式空白故障
    for data in datas :
        if data == 'Allen':
            Says = 'Allen'
            continue 
        elif data == 'Tom':
            Says = 'Tom'
            continue
        if Says: # null 防止程式空白故障
            new.append(Says + ': ' + data)
    # print(new)
    
    return new   

# read file
def readfile():
    with open (filename, 'r', encoding='utf-8-sig') as f : # utf-8-sig 去 '\ufeff'
        for texts in f :
            datas.append(texts.strip())
    # print('readfile', datas)
    return datas

# run script
def main():
    # print('run script', datas)
    readfile()
    resttext()
    print('otys1',resttext())
    datas = resttext() # 轉存後 resttext() 就變回 []
    print('otys',resttext())
    output()
    return datas
    

main()




