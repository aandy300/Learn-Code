#程式改寫 Line對話

filename = 'sample/-LINE-Viki.txt'
datas = []

# out put
def output():
    with open('sample/output.txt', 'w', encoding='utf-8-sig') as f:
        for data in resttext():
            f.write(data + '\n')

# rest text
def resttext():
    allen_word_count = 0
    allen_sticker_count = 0
    allen_image_count = 0
    viki_word_count = 0
    viki_sticker_count = 0
    viki_image_count = 0
    for data in datas :
        s = data.split(' ')
        time = s[0]
        name = s[1]
        if name == 'Allen':
            if s[2] == '貼圖':
                allen_sticker_count += 1
            elif s[2] == '圖片':
                allen_image_count +=1
            else:
                for m in s[2:]:
                    allen_word_count += len(m)
        elif name =='Viki':
            if s[2] == '貼圖':
                viki_sticker_count += 1
            elif s[2] == '圖片':
                viki_image_count +=1
            else:
                for m in s[2:]:
                    viki_word_count += len(m)

    print(s,time,name,allen_word_count, allen_sticker_count, viki_word_count, viki_sticker_count,'分隔----------','Allen', allen_word_count, 'Viki', viki_word_count)        
    print('Allen字數', allen_word_count, 'Allen貼圖', allen_sticker_count, 'Allen圖片', allen_image_count)
    print('Viki字數', viki_word_count, 'Viki貼圖', viki_sticker_count, 'Viki圖片', viki_image_count)
    
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
    # output()
    return datas
    

main()





