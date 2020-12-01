#Class 種類 類型
#Class一律大寫開頭 function一律都小寫

class Desk:
    def __init__(self, color):
        color = 'red'
        self.color = color
        print('hi')
    def re_color(self, newcolor):
        self.color = newcolor
d = Desk('red') # instantiation 實體化 (創作物件) # public gameobj
print(d.color)
d.re_color('blue')
print(d.color)