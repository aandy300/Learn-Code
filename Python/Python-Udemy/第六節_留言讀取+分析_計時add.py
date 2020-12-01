#留言讀取程式分析練習

import time
import random
import progressbar

datas = []
count = 0
bar = progressbar.ProgressBar(max_value=1000000)
#                 || Object
#概念 開啟檔案讀取,並告知讀取進度,將資料回存到 datas
with open ('sample/reviews.txt', 'r') as f :

    for line in f :
        datas.append(line)
        count += 1
        bar.update(count)
        # if count % 100000 == 0:
        #     print(len(datas))

print('檔案讀取完了,總共有', len(datas), '筆資料')

print('資料做分行處理split ing...')
#將資料做分行處理split(),並將分行處理後的資料存進wc{}字典並記數,一開始wc{}為空所以資料會一筆一筆加進去
# wc{} wc[word] += 1 
# key = 單字 value = 出現次數
start_time = time.time()
wc = {}
count_spilt = 0
for d in datas:
    count_spilt += 1
    bar.update(count_spilt)
    words = d.split() #split留空 預設 = 空白
    for word in words:
        if word in wc:
            wc[word] += 1
        else:
            wc[word] = 1

#印出 100000 以上出現過的單字
for word in wc:
    if wc[word] > 100000:
        # print(word, wc[word])
        print(None)
end_time = time.time()
print(start_time - end_time)
#如果輸入的文字 同名的 key(索引) 在裡面wc{}(字典)裡面
#印出 輸入的文字(key) 與 輸入的文字(key)字典裡的值(value)
while True:
    text = input('請輸入想尋找的文字')
    if text == 'q':
        print('程式結束感謝使用')
        break
    elif text in wc:
        print(text, '在留言中出現的次數為', wc[text], '次')
    else:
        print(text, '沒有在留言中出現過')
