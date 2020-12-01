#Class 種類 類型
#Class一律大寫開頭 function一律都小寫

class Sa:
    def __init__(self, name, score): #初始化 屬性 #會先讀取完 __init__ 裡面的內容
        self.name = name
        self.score = score
        print('hi')

    def read(self): # 屬性
        self.score += 2
        print(self.name, 'reading...')

    def rest(self): #屬性
        print('resting...')

# instantiation 實體化 (創作物件) # public gameobj

Sa1 = Sa('AN', 5)