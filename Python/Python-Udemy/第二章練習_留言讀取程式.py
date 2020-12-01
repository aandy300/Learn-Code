#留言讀取程式練習

data = []
count = 0
with open ('sample/reviews.txt', 'r', encoding='UTF-8') as f :

    for line in f :
        data.append(line)
        count += 1
        if count % 100000 == 0:
            print(len(data))

print('檔案讀取完了,總共有', len(data), '筆資料')

#平均字數
sum_len = 0
for d in data:
    sum_len = sum_len + len(d)
print('總字數', sum_len) #總字數
print('平均字數', sum_len / len(data)) #平均字數

#條件塞選

#留言長度塞選
new = []
for d in data:
    if len(d) > 100:
        new.append(d)
print('總共有', len(new), '筆留言長度大於100')

#文字內容塞選
good = []
for d in data:
    if 'good' in d:
        good.append(d)
print('總共有', len(good), '筆提到good')