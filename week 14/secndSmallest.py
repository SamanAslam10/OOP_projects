list = [ 10 , 6 , 4 , 2]
smallest = list[0]
scnd = list[1]

for i in list:
    if smallest > list[i]:
        smallest = list[i]
        if smallest > scnd:
            scnd = smallest
print(scnd)    