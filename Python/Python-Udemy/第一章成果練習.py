password = 'a123'
x = 3 # 剩餘機會
while x > 0 :
    z = input('請輸入密碼')
    if z == password :
        print('登入成功')
        break
    else:
        x -= 1
        print('密碼錯誤,剩餘',x ,'次機會')
if x == 0 :
    print('登入失敗')