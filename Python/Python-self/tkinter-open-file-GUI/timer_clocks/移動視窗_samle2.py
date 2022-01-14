import tkinter as tk


class Win(tk.Tk):
    def __init__(self):
        super().__init__()
        super().overrideredirect(True)
        self._offsetx = 0
        self._offsety = 0
        super().bind("<Button-1>" ,self.clickwin)
        super().bind("<B1-Motion>", self.dragwin)

    def dragwin(self,event):
        x = super().winfo_pointerx() - self._offsetx
        y = super().winfo_pointery() - self._offsety
        super().geometry(f"+{x}+{y}")

    def clickwin(self,event):
        self._offsetx = super().winfo_pointerx() - super().winfo_rootx()
        self._offsety = super().winfo_pointery() - super().winfo_rooty()

    
root = Win()

label_1 = tk.Label(root, text="Label 1")
label_1.pack(side="left")

label_2 = tk.Label(root, text="Label 2")
label_2.pack(side="left")

root.mainloop()