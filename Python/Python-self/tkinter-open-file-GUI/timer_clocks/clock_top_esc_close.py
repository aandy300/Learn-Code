# 參考
# 移動視窗 
# https://stackoverflow.com/questions/29641616/drag-window-when-using-overrideredirect/29643532#29643532


import threading ,time, datetime
import tkinter as tk

import ctypes # 執行python時不顯示cmd
ctypes.windll.user32.ShowWindow( ctypes.windll.kernel32.GetConsoleWindow(), 0 ) # 執行python時不顯示cmd

hour = time.strftime("%I")
minute = time.strftime("%M")
second = time.strftime("%S")
am_pm = time.strftime("%p")

# 子執行緒的工作函數
def clock():
    while getattr(t, "do_run", True):
        global hour, minute, second, am_pm        
        am_pm = datetime.datetime.now().strftime("%p")
        hour = datetime.datetime.now().strftime("%I")
        minute = datetime.datetime.now().strftime("%M")
        # second = str(int(datetime.datetime.now().strftime("%S"))+1)
        second = datetime.datetime.now().strftime("%S")
        
        print(am_pm, hour, minute, second)        
        time.sleep(1)
# 建立一個子執行緒
t = threading.Thread(target = clock)

# 執行該子執行緒
t.start()

# 主執行緒繼續執行自己的工作
class Win(tk.Tk):
    def __init__(self):
        super().__init__()        
        super().overrideredirect(True)
        self._offsetx = 0
        self._offsety = 0
        super().bind("<Button-1>" ,self.clickwin)
        super().bind("<B1-Motion>", self.dragwin)
        super().bind("<Escape>", self.exit)        

    def dragwin(self,event):
        x = super().winfo_pointerx() - self._offsetx
        y = super().winfo_pointery() - self._offsety
        super().geometry(f"+{x}+{y}")
    def clickwin(self,event):
        self._offsetx = super().winfo_pointerx() - super().winfo_rootx()
        self._offsety = super().winfo_pointery() - super().winfo_rooty()
    def exit(self,event):
        global t
        root.destroy()        
        t.do_run = False    
    
def uptext():
    global label_1    
    label_1.config(text= am_pm + ' ' + hour + ":" + minute + ":" + second) 
    # label_1.pack(pady=20)    
    label_1.after(500, uptext)
root = Win()
label_1 = tk.Label(root, text= am_pm + ' ' + hour + ":" + minute + ":" + second)
label_1.pack(side="left")
label_1.after(50, uptext)


# 下面介面相關
root.overrideredirect(1) # 隱藏介面 但是拉不了位置
# root.lift() 視窗堆疊 下面方法取代
root.attributes("-topmost", True) # 畫面置頂
# root.configure(bg='') #如果有設定背景的話背景消失?
root.mainloop()

# 等待 t 這個子執行緒結束
t.join()

print("Done.")