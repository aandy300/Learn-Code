# 載入 tkinter 全部
from tkinter import *
import time

# PS區
# BMI參考 https://blog.techbridge.cc/2019/09/21/how-to-use-python-tkinter-to-make-gui-app-tutorial/
# 窗口透明 https://stackoverflow.com/questions/19080499/transparent-background-in-a-tkinter-window
# 宣 應用程式 容器名稱
root = Tk()
# 標題
root.title('title')
# icon
# root.iconbitmap('位置')
# 視窗尺寸
root.geometry("600x400")

# 本地時間 參考下面
# time strftime() 相關
# https://www.runoob.com/python/att-time-strftime.html
def clock():
    hour = time.strftime("%I")
    minute = time.strftime("%M")
    second = time.strftime("%S")
    day = time.strftime("%A")
    am_pm = time.strftime("%p")
    time_zone = time.strftime("%Z")
    
    my_label.config(text= am_pm + hour + ":" + minute + ":" + second)        
    # 幾秒後更新 毫秒 1000 = 1s
    my_label.after(1000, clock)

    # my_label2.config(text=time_zone + " " + day)
    print('1234')    
def update():
    my_label.config(text="New Text")

# 標籤 指定程式root > 文字內容 
my_label = Label(root, text="", font=("Helvetica", 48), fg="green", bg="black")
# my_label2 = Label(root, text="", font=("Helvetica", 14))
# 位置
my_label.pack(pady=20)
# my_label2.pack(pady=10)

# run
clock()
# main.loop()如何理解 GUI编程都有一个主体的死循环，一旦退出这个死循环，程序就结束了，mainloop就可以理解为这样一个循环
# https://www.zhihu.com/question/23542885
root.overrideredirect(1) # 隱藏介面 但是拉不了位置
# root.lift()
root.attributes("-topmost", True) # 畫面置頂
root.configure(bg='') # 
root.mainloop()