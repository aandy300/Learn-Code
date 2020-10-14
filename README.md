# 01-環境設置
# 02-環境設置2-debug 
# 03-for-while-if-印出格式
# 04-Class
# 05-參考型別-Reference-Type-實質型別-堆疊-Heap
# 06-建構子-Constructor
# 07-this
# 08-static-class-靜態類別
# 09-Array-陣列
# 10-垃圾回收
# 11-封裝性-public-private
# 12-private-exsample
# 13-get-set-存取器-class-func()-更簡潔化
# 14-get-set-練習-value
# 15-封裝性
# 16-繼承性-Q沒辦法用-基底用法?
# 17-亂數-Random
# 18-複寫-Override
# 19-Override-Method-Hiding-隱藏-new
# 20-Protected-保護
# 21-Base-指向基底類別
# 22-Abstract-Class-抽象class
# 23-Constant-readonly-常數
# 24-Switch-enum-列舉
# 25-Multidimensional-Array-多維陣列
# 26-Multidimensional-Array-多維陣列-加法
# 26-數學課-多維陣列-乘法

04.21
超過陣列 範圍 編譯的時候才會發現問題
07.40
二維  三圍 作圖?
幾維=幾個編號要找
幾維陣列 用逗號來增減
12.55
宣時放入東 西 看不懂
a: 官網 圖 一個包 一個
20.27
加乘法
左至右 上至下

畫格子 EX WIKI
A 左至右 A1 * B1 上至下


不相等尺寸時

當AB = AC時,且 A≠0
但 B = C 未必成立
未解:
Q 
1. 填入資訊時
2. 可以產生物件時填入資訊  base 與  繼承的 印出不同資訊
// 沒辦法取到基底的 info why?  | 被override了? 不是取用最近的?


# Tip

C#  判定  func() 是否相同是以 func()名稱 與 (容器內容是否一樣)
VSCODE CTRL+SHIFT+C  = CMD here

宣告時:
變數每個單字大寫
常數每個字大寫單字下引號

基底容器,new 衍伸類型

已解:

Q沒辦法用 結構子 繼承
https://dotblogs.com.tw/chichiBlog/2017/08/20/Inheritance
A1 # 18 Npc.cs 用this 在 該class本身下? this.Name =  name;
A2 # 21 Dog.cs base指向?  public Dog(string name) : base(name)
