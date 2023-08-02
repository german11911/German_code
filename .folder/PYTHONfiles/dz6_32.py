# Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону 
# (т.е. не меньше заданного минимума и не больше заданного максимума)
import random
#случайно сгенерированные n целых чисел в диапазоне между a и b
def fillist(n,a,b):
    list=[]
    for i in range(n):
        list.append(random.uniform(a,b))
    return list
n = int(input("введите количество элементов списка :   "))
a = float(input("введите минимум диапазона :   "))
b = float(input("введите максимум диапазона :   "))
# для наглядности будем генерировать в диапазоне в 2 раза большем максимума и минимума отрицательные и положительные числа
if abs(a)<abs(b):
    d = abs(b)
else:
    d =abs(a)
listn=fillist(n,-d*2,d*2)
print(listn)
print("{20.2f}".format(listn))
listindex=[]
for i in range(n-1):
    if listn[i]>=a and listn[i]<=b:
        listindex.append(i)
print(f' индексы элементов внутри диапазона {listindex}')