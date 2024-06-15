#include <iostream>
#include <string>
#include "aes.h"
#include "modes.h"
#include "filters.h"
using CryptoPP::AES;
using CryptoPP::CBC_Mode;

#include "secblock.h"
using CryptoPP::SecByteBlock;

using namespace std;
using namespace CryptoPP;

CryptoPP::byte* find_key(CryptoPP::byte* iv, string ciphertext) {
CryptoPP::byte key[AES::DEFAULT_KEYLENGTH];
// Duyệt từng khả năng của key
for (int i = 0; i <= 255; i++) {
for (int j = 0; j <= 255; j++) {
key[0] = i;
key[1] = j;

    // Giải mã ciphertext sử dụng key và IV 
    string decryptedtext; 
    try 
    { 
        CBC_Mode<AES>::Decryption decryption;
        decryption.SetKeyWithIV(key, sizeof(key), iv);
        StringSource(ciphertext, true, new StreamTransformationFilter(decryption, new StringSink(decryptedtext))); 
    } 
    catch (CryptoPP::Exception& e) 
    { 
        if (i == 0)
            cout << "i, j: " << i << ", " << j << endl;
        continue;   // Bỏ qua các ciphertext không hợp lệ 
    } 

    // Nếu đúng plaintext thì trả về key 
    if (decryptedtext == "Day la chuong trinh tan cong vao AES") { 
        CryptoPP::byte* found_key = new CryptoPP::byte[AES::DEFAULT_KEYLENGTH]; 
        memcpy(found_key, key, AES::DEFAULT_KEYLENGTH); 
        return found_key; 
    } 
} 
}
return NULL;
}

int main()
{
CryptoPP::byte key[AES::DEFAULT_KEYLENGTH] = {'k', 'e', 'y', '1', '2', '3', '4', '5', '6', '7', '8', '9', '1', '0', '1', '1'};
CryptoPP::byte iv[AES::BLOCKSIZE] = {'I', 'V', '1', '2', '3', '4', '5', '6', '7', '8', '9', '1', '0', '1', '1', '2'};

// Plaintext cố định
string plaintext = "Day la chuong trinh tan cong vao AES";
cout << "plaintext: " << plaintext << endl;

// Mã hóa plaintext
string ciphertext;
try
{
CBC_Mode<AES>::Encryption encryption;
encryption.SetKeyWithIV(key, sizeof(key), iv);
StringSource(plaintext, true, new StreamTransformationFilter(encryption, new StringSink(ciphertext)));
}
catch (CryptoPP::Exception& e)
{
cerr << e.what() << endl;
exit(1);
}
cout << "Ciphertext: " << ciphertext << endl;

// Tìm key sử dụng IV và ciphertext
CryptoPP::byte found_key[AES::DEFAULT_KEYLENGTH];
memcpy(found_key, find_key(iv, ciphertext), sizeof(found_key));
cout << "Found key: " << int(found_key[0]) << endl;

// Giải mã ciphertext sử dụng key và IV
string decryptedtext;
try
{
CBC_Mode<AES>::Decryption decryption(found_key, sizeof(found_key), iv);
StringSource(ciphertext, true, new StreamTransformationFilter(decryption, new StringSink(decryptedtext)));
}
catch (CryptoPP::Exception& e)
{
cerr << e.what() << endl;
exit(1);
}
cout << "Recovered text: " << decryptedtext << endl;
}