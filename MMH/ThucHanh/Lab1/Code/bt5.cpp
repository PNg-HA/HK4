
#include "osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include <iostream>
using std::cout;
using std::cerr;
using std::endl;

#include <string>
using std::string;
#include  <bits/stdc++.h>
  
#include <cstdlib>
using std::exit;

#include "cryptlib.h"
using CryptoPP::Exception;

#include "hex.h"
using CryptoPP::HexEncoder;
using CryptoPP::HexDecoder;

#include "filters.h"
using CryptoPP::StringSink;
using CryptoPP::StringSource;
using CryptoPP::StreamTransformationFilter;

#include "des.h"
using CryptoPP::DES;

#include "modes.h"
using CryptoPP::CBC_Mode;

#include "secblock.h"
using CryptoPP::SecByteBlock;
using CryptoPP::byte;
#include <string.h>
#include "misc.h"
#include <initializer_list>
#include <vector>
#include "filters.h"



int main(){
    AutoSeededRandomPool prng;

    //SecByteBlock key(DES::DEFAULT_KEYLENGTH);
    //prng.GenerateBlock(key, key.size());
    //cout << DES::DEFAULT_KEYLENGTH << " " << DES::BLOCKSIZE;
   // CryptoPP::byte iv[DES::BLOCKSIZE];
   
   

    string keystring;
    cout << "Type 8-byte key: ";
    std::getline(std::cin, keystring);
    // Convert string  to SecByteBlock
    // &keystring[0]: the beginning of the data
    // keystring.size: the size of the array
    SecByteBlock key(reinterpret_cast<const byte*>(&keystring[0]), keystring.size());

    string plain = "CBC Mode Test";
    
    byte iv[8];
    for (size_t i = 0; i < 8; i++){
        cout << i << ": ";
        std::cin >> iv[i];
    }

    // Convert string  to SecByteBlock
 
    string cipher, encoded, recovered;

    CBC_Mode< DES >::Encryption e;
    e.SetKeyWithIV( key, key.size(), iv ); // e = key XOR IV

    // Encrypt
    /* 
    StringSource là 1 lớp chuyển chuỗi từ 1 nguồn sang đích, ở đây cipher là nguồn, 
    true nhằm thông báo thao tác chuyển sẽ được thực hiện, chuỗi đích là tham số thứ 3 của hàm
    */
    StringSource ss(
        plain, 
        true, 
        
        new StreamTransformationFilter( //mã hóa, cipher = f(plain, e);
            e,
            // StringSink là 1 hàm sinh ra chuỗi, chuỗi được sinh ra sẽ lưu vào trong tham số cipher
            new StringSink(cipher)
        )
    );
    cout << "cipher text: " << cipher << endl;

    // Decrypt
    CBC_Mode< DES >::Decryption d;
    d.SetKeyWithIV( key, key.size(), iv );

    
    StringSource ss2(
        cipher, 
        true, 
        new StreamTransformationFilter(
            d,
            // StringSink là 1 hàm sinh ra chuỗi, chuỗi được sinh ra sẽ lưu vào trong tham số recovered
            new StringSink(recovered)
        )
    );
    cout << "Recovered text: " << recovered << endl;

    return 0;
}