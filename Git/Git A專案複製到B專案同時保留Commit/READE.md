###### tags:`Git`
<!-- ###### tags:`TagName` -->

Git A專案複製到B專案同時保留Commit
===

[TOC]


# 事前工作
:::success
1. 遠程
    - 準備號要移動的專案(A)
    - 新增空的儲存庫(B)
2. 本地
    - 新增要放B的空資料夾
    
![圖1](https://i.imgur.com/8Hq009c.png)

![圖2](https://i.imgur.com/7r8M63N.png)

![圖3](https://i.imgur.com/6E6FDHg.png)
:::

# 開始移動
:::info

步驟 :
1. 移動到本地要放B的空資料夾
\
`cd Test-repoB`
3. 初始化
\
`git init`
3. 拉 A專案 資料進 B專案 本地空資料夾
\
`git pull <遠程儲存庫位置(A) https://github.com/***/Test-repoA.git>`
4. 設定 B專案遠程儲存庫 的位置
\
`git remote add origin <遠程儲存庫位置(B) https://github.com/***/Test-repoB.git>`
5. 確認 B專案遠程儲存庫 位置
\
`git remote -v` 
6. 將複製過來的 A專案資料 推至 B專案的遠程儲存庫
\
`git push --set-upstream origin master `
7. 完成 
\
`防萬一在pull下來確認是否正常`

![](https://i.imgur.com/DA3P5mv.png)

:::
