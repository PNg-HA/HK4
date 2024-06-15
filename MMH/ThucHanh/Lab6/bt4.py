import base64
def xor_strings(string1, string2):
    str1 = int(string1, 16)
    str2 = int(string2, 16)
    xor_result = hex(str1 ^ str2)
    result = str(xor_result)[2:]
    result = bytes.fromhex(result)
    print(result.decode("utf-8"))
def remove_spaces(string):
    return string.replace(" ", "")
print ("cipher: ", remove_spaces('5c491d9b 80063faa 102b439f 2a137b6b f7d305bf 97c94325 28e1c02a 83d6ef05 33adc6ee 2678f8d2 36827d55 6294798b 53557f75 7225b541 7c76c021 0bc2c304 820186f2 b30ee72f 611c20d4 7c17f730 30c66791 22af6a16 cebe7a2f 34b00cde 9ec7418b 2177e93a 713de7ec 25125344 97ea68ee c557a2cb 4f6d0691 9aeaa256 8a117133 b96001f9 2b96a9aa 01fabb95 1fd54f98 21fa23c3 ef7dd0c0 fb46c4b7 55c2e28b 521cc483 73d5f97c 3a14b3bf 7aa0fa47 b8978034 02cdaf5b 3d57613e 545ade66 49f6db96 5c95d73e 5deb9e06 3ca0e2ec b44b0265 b5ea18bc 5fed5775'))
ciphers = ['c88c199f44545ef970f65c6d5610ae3a5c491d9b80063faa102b439f2a137b6bf7d305bf97c9432528e1c02a83d6ef0533adc6ee2678f8d236827d556294798b53557f757225b5417c76c0210bc2c304820186f2b30ee72f611c20d47c17f73030c6679122af6a16cebe7a2f34b00cde9ec7418b2177e93a713de7ec2512534497ea68eec557a2cb4f6d06919aeaa2568a117133b96001f92b96a9aa01fabb951fd54f9821fa23c3ef7dd0c0fb46c4b755c2e28b521cc48373d5f97c3a14b3bf7aa0fa47b897803402cdaf5b3d57613e545ade6649f6db965c95d73e5deb9e06']
print("plain2: ", remove_spaces('854fbabf 2c97ed98 50b7193e 76d43ffc eca8a638 e3264bc2 f190f2fc 0a7b128a 4c546b9f e3a18091 4686e05b f6b7cf30 13ceae0f 9dd19bf2 5846fe3b 05b41ae3 90f8111d 524976e1 5c37a445 59adb66a e64ae38b 9f2eb45a 035e59a0 1964db10 63ae0ef7 56fd0561 bd925a62 5dc84fb1 f2b22ce5 52579ff9 d11dac89 5c572b34 f6841b87 aa398ceb 01a985fc ba89cab7 31b81213 d7a48297 4cb6c769 a1839b51 8e13ff79 9a5940e3 9c9c6a6f 8b66bc56 ef7d92ab 968d2538 f0f58d14 dbaf02dc 5ac893a6 0310ee14 60ac8f39 fbe78085 cf39fe05 8f57fbf4 bd2f7450 73e89d05') )
plain2s = ['854fbabf2c97ed9850b7193e76d43ffceca8a638e3264bc2f190f2fc0a7b128a4c546b9fe3a180914686e05bf6b7cf3013ceae0f9dd19bf25846fe3b05b41ae390f8111d524976e15c37a44559adb66ae64ae38b9f2eb45a035e59a01964db1063ae0ef756fd0561bd925a625dc84fb1f2b22ce552579ff9d11dac895c572b34f6841b87aa398ceb01a985fcba89cab731b81213d7a482974cb6c769a1839b518e13ff799a5940e39c9c6a6f8b66bc56ef7d92ab968d2538f0f58d14dbaf02dc5ac893a60310ee1460ac8f39fbe78085cf39fe058f57fbf4bd2f745073e89d05']

for str1, str2 in zip(ciphers, plain2s):
    xor_strings(str1, str2)