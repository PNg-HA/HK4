key = b'myXORkey'
encrypted_msg = bytes.fromhex('0e0b213f26041e480b26217f27342e175d0e070a3c5b103e2526217f27342e175d0e077e263451150104')
flag = []
for i in range(len(encrypted_msg)):
    flag.append(encrypted_msg[i] ^ key[i % (len(key))])

print("".join(chr(i) for i in flag))