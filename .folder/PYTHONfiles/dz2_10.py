from random import randint
n = int(input("введите количество монет:   "))
count0=0
count1=0
list1=[]
l=0
i=0
while i < n:
    l = randint(0,1)
    i+=1
    list1.append(l)
    if l == 0:
        count0+=1
    else:
        count1+=1    
print(*list1)    
if count0 < count1:
    print(f"надо перевернуть {count0} монет с решкой")
else:
    print(f"надо перевернуть {count1} монет с орлом")