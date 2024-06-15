
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
using CryptoPP::AES;

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
    cout << "Type 16-byte key: ";
    std::getline(std::cin, keystring);

    // Convert string  to SecByteBlock
    // &keystring[0]: the beginning of the data
    // keystring.size: the size of the array
    SecByteBlock key(reinterpret_cast<const byte*>(&keystring[0]), keystring.size());

    string plain  = "CBC Mode Test demo CBC Mode Test demo CBC Mode Test demo";
    cout << "plaintext: " << plain << endl;  //  std::getline(std::cin, plain);

    // Input IV
    byte iv[8];
    cout << "Type array IV: " << endl;
    for (size_t i = 0; i < 16; i++){
        cout << i << ": ";
        std::cin >> iv[i];
    }

    // Convert string  to SecByteBlock
 
    string cipher, encoded, recovered;

    CBC_Mode< AES >::Encryption e;
    e.SetKeyWithIV( key, key.size(), iv ); 

    StringSource ss(
        plain, 
        true, 
        
        new StreamTransformationFilter( //mã hóa, cipher = f(plain, e);
            e,
            new StringSink(cipher)
        )
    );
    cout << "cipher text: " << cipher << endl;

    //eP1 means First Plaintext from eavesdropper , eC1 means First Cipher from eavesdropper 
    string eP1 = "CBC Mode Test demo", eC1 = ""; 
    //Create e2 because e properties (key, iv) will be changed after e is used.
    CBC_Mode< AES >::Encryption e2;
    e2.SetKeyWithIV( key, key.size(), iv ); 
    StringSource s2(
        eP1, 
        true, 
        
        new StreamTransformationFilter( //mã hóa, cipher = f(plain, e);
            e2,
            new StringSink(eC1)
        )
    );
    cout << "Eve cipher text: " << eC1 << endl;
    // Decrypt
    CBC_Mode< AES >::Decryption d;
    d.SetKeyWithIV( key, key.size(), iv );

    
    StringSource ss2(
        cipher, 
        true, 
        new StreamTransformationFilter(
            d,
            new StringSink(recovered)
        )
    );
    cout << "Recovered text: " << recovered << endl;

    return 0;
}