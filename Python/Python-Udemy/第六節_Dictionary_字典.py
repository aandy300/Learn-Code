#Dictionary 字典

words = {
    'raman' : '拉麵',
    'pasta' : '義大利麵'
    # key       value
}

words ['tea'] = '茶' #增加新的key 
print(words['raman'])

p0 = {
    'name' : '麥香奶茶',
    'price' : '10'
}

p1 = {
    'name' : '珍珠奶茶',
    'price' : '50'
}

drinks = [p0, p1]
print(drinks[0]['name'])
#          |清單->|字典