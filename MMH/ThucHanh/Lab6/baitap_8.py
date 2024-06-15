import os
# 2^128 collision protection!
BLOCK_SIZE = 32

# Nothing up my sleeve numbers (ref: Dual_EC_DRBG P-256 coordinates)
W = [0x6b17d1f2, 0xe12c4247, 0xf8bce6e5, 0x63a440f2, 0x77037d81, 0x2deb33a0, 0xf4a13945, 0xd898c296]
X = [0x4fe342e2, 0xfe1a7f9b, 0x8ee7eb4a, 0x7c0f9e16, 0x2bce3357, 0x6b315ece, 0xcbb64068, 0x37bf51f5]
Y = [0xc97445f4, 0x5cdef9f0, 0xd3e05e1e, 0x585fc297, 0x235b82b5, 0xbe8ff3ef, 0xca67c598, 0x52018192]
Z = [0xb28ef557, 0xba31dfcb, 0xdd21ac46, 0xe2a91e3c, 0x304f44cb, 0x87058ada, 0x2cb81515, 0x1e610046]

# Lets work with bytes instead!
W_bytes = b''.join([x.to_bytes(4,'big') for x in W])
X_bytes = b''.join([x.to_bytes(4,'big') for x in X])
Y_bytes = b''.join([x.to_bytes(4,'big') for x in Y])
Z_bytes = b''.join([x.to_bytes(4,'big') for x in Z])

def pad(data):
    padding_len = (BLOCK_SIZE - len(data)) % BLOCK_SIZE
    if padding_len == 0:
        padding_len = BLOCK_SIZE
    return data + bytes([padding_len]*padding_len)

def blocks(data):
    return [data[i:(i+BLOCK_SIZE)] for i in range(0,len(data),BLOCK_SIZE)]

def xor(a,b):
    return bytes([x^y for x,y in zip(a,b)])

def rotate_left(data, x):
    x = x % BLOCK_SIZE
    return data[x:] + data[:x]

def rotate_right(data, x):
    x = x % BLOCK_SIZE
    return  data[-x:] + data[:-x]

def scramble_block(block):
    for _ in range(40):
        block = xor(W_bytes, block)
        block = rotate_left(block, 6)
        block = xor(X_bytes, block)
        block = rotate_right(block, 17)
        #print("rotate_right((x_bytes xor rotate_left((block xor w_bytes),6)),17)")
    return block

def cryptohash(msg):
    initial_state = xor(Y_bytes, Z_bytes)

    msg_padded = pad(msg)

    msg_blocks = blocks(msg_padded)

    for i,b in enumerate(msg_blocks):
        
        mix_in = scramble_block(b)
        for _ in range(i):
            mix_in = rotate_right(mix_in, i+11)
            mix_in = xor(mix_in, X_bytes)
            mix_in = rotate_left(mix_in, i+6)
        initial_state = xor(initial_state,mix_in)
    return initial_state.hex()

def reverse_scramble_block(block):
    for _ in range(40):
        block = rotate_left(block, 17)
        block = xor(X_bytes, block)
        block = rotate_right(block, 6)
        block = xor(W_bytes, block)
    return block

def main():

    bl_a1 = os.urandom(31)
    bl_a1_pad = pad(bl_a1)

    mix_in_a1 = scramble_block(bl_a1_pad)

    bl_b2 = os.urandom(31)
    bl_b2_pad = pad(bl_b2)
    mix_in_b2 = scramble_block(bl_b2_pad)
    mix_in_b2 = rotate_right(mix_in_b2, 1+11)
    mix_in_b2 = xor(mix_in_b2, X_bytes)
    mix_in_b2 = rotate_left(mix_in_b2, 1+6)

    mix_in_b1 = xor(mix_in_a1, mix_in_b2)

    bl_b1 = reverse_scramble_block(mix_in_b1)

    mess1 = bl_a1.hex()
    mess2 = (bl_b1+bl_b2).hex()

    print("m1: ", mess1)
    print("m2: ", mess2)

    m1 = input("Please enter a hex encoded messages m1:\n")
    m2 = input("Enter a hex encoded messages m2:\n")

    if cryptohash(bytes.fromhex(m1)) == cryptohash(bytes.fromhex(m2)):
        if m1 != m2:
            print(f'Congratulations on finding the collision value {cryptohash(bytes.fromhex(m1))}')


if __name__ == "__main__":
    main()
