# pillow 第三方 圖片處理
from PIL import Image
import os

#路徑手動版
# for file in os.listdir('sample/input'): #lsit列表 dir資料夾 '.' = 同階級 現在位置
#     if file.endswith('.png'): #endswith = 檢查字串最後的結尾是否是 ('')
#         image_file = Image.open('sample/input/' + file)
#         image_file = image_file.convert('L') #convert 轉化
#         image_file.save('sample/output/' + file[:-4] + '_output.png') # file[:-4] = .png 之前的文字
#         print(file)

#os.path.join版        
for file in os.listdir('sample/input'): #lsit列表 dir資料夾 '.' = 同階級 現在位置
    if file.endswith('.png'): #endswith = 檢查字串最後的結尾是否是 ('')
        image_file = Image.open(os.path.join('sample','input', file))
        image_file = image_file.convert('L') #convert 轉化 'L'模式
        image_file.save(os.path.join('sample','output', file[:-4] + '_output.png'))
                        # join不需要/ 把要的路徑裝進()裡就可以 多個的話用,分隔     
        print(image_file)