# tkinter open file GUI
import os
from tkinter.filedialog import askopenfilename
from tkinter import Tk


# filename = askopenfilename()
filename = askopenfilename(filetypes=[("Image files", "*.png"), ("All Files", "*.*")]) # 檔案類型 篩選
Tk().withdraw() # we don't want a full GUI, so keep the root window from appearing # 隱藏tk ui
# filename = askopenfilename() # show an "Open" dialog box and return the path to the selected file
print(filename)



