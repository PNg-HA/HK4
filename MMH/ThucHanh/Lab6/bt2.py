from Crypto.Cipher import DES
from Crypto.Util.Padding import pad, unpad
from Crypto.Random import get_random_bytes
import base64
def encrypt_des(key, plaintext):
    cipher = DES.new(key, DES.MODE_ECB)  # Create AES cipher object in ECB mode
    ciphertext = cipher.encrypt(pad(plaintext, DES.block_size))
    return ciphertext

def decrypt_des(key, ciphertext):
    cipher = DES.new(key, DES.MODE_ECB)  # Create AES cipher object in ECB mode
    decrypted_text = cipher.decrypt(ciphertext)
    return decrypted_text
list = ['1F1F1F1F0E0E0E0E', 'E0E0E0E0F1F1F1F1', '011F011F010E010E', '0101010101010101', 'FEFEFEFEFEFEFEFE', '0000000000000000', 'FFFFFFFFFFFFFFFF', 'E1E1E1E1F0F0F0F0', '1E1E1E1E0F0F0F0F', '1F011F010E010E01', '01E001E001F101F1', 'E001E001F101F101', '01FE01FE01FE01FE', 'FE01FE01FE01FE01', '1FE01FE00EF10EF1', 'E01FE01FF10EF10E', '1FFE1FFE0EFE0EFE', 'FE1FFE1FFE0EFE0E', 'E0FEE0FEF1FEF1FE', 'FEE0FEE0FEF1FEF1']

ciphertext = base64.b64decode('6MupHn98v/yhX3jSCMf+LFOVQc7iRLALzTjd5ow34a5vnoPkSmZ1MHG/wU9Elkva') #encrypt_aes(key, plaintext)
for k in list:                 
    try:
         a = k
         k = bytes.fromhex(str(k))
         decrypted_text = decrypt_des(k, ciphertext)
         print(decrypted_text.decode('utf-8'))
         print('key: ', a)
    except:
         print('wrong key: ', a)
# print("Decrypted text:", decrypted_text)
# print(decrypted_text.decode("utf-8") )