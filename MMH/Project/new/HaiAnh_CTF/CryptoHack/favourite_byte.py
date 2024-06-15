string = "73626960647f6b206821204f21254f7d694f7624662065622127234f726927756d"
string_ord = [o for o in bytes.fromhex(string)]
for i in range(256):
        pos = [o^i for o in string_ord]
        p = "".join(chr(o) for o in pos)
        if p[:6] == 'crypto':
                flag = p
                break
print(flag)