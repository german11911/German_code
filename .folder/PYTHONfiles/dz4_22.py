from random import randint
#случайно сгенерированные n целых чисел в диапазоне между a и b
def fillist(n,a,b):
    list=[]
    i=0
    while i < n:
        i+=1
        list.append(randint(a,b))
    return list
n = int(input("введите количество элементов первого списка :   "))
m = int(input("введите количество элементов второго списка :   "))
list1=fillist(n,0,100)
list2=fillist(m,0,150)
c=set(list1).intersection(set(list2))
print(list1)
print(list2)
# print(c)
# c=set(fillist(n,0,100)).intersection(set(fillist(m,0,150)))
d=[]
for k in c:
    d.append(k)
d.sort()
print(d) 
# print(d.sort()) - непонятно,почему выдаёт None
