#Class 種類 類型
#Class一律大寫開頭 function一律都小寫

class Student:
    def __init__(self, name, score):
        self.name = name
        self.score = score
        print('hi')

    def read(self):
        self.score += 2
        print(self.name, 'reading...')

    def rest(self):
        print('resting...')

# instantiation 實體化 (創作物件) # public gameobj
s1 = Student('A', 50)
s2 = Student('B', 60)
print(s1.name, s1.score, s2.name, s2.score)
s2.read()
print(s1.name, s1.score, s2.name, s2.score)