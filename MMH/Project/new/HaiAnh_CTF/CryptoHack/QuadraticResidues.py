a = []
for i in range(28):
        if (i**2 % 29 in [14, 6, 11]): # pow(i,2,29)
            a.append (i)
print(min(a))