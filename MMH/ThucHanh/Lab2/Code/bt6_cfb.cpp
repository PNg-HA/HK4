// g++ -g3 -ggdb -O0 -DDEBUG -I/usr/include/cryptopp Driver.cpp -o Driver.exe -lcryptopp -lpthread
// g++ -g -O2 -DNDEBUG -I/usr/include/cryptopp Driver.cpp -o Driver.exe -lcryptopp -lpthread

#include "include/osrng.h"
using CryptoPP::AutoSeededRandomPool;
using CryptoPP::byte;

#include <iostream>
using std::cout;
using std::cerr;
using std::endl;

#include <string>
using std::string;

#include <cstdlib>
using std::exit;

#include "include/cryptlib.h"
using CryptoPP::Exception;

#include "include/hex.h"
using CryptoPP::HexEncoder;
using CryptoPP::HexDecoder;

#include "include/filters.h"
using CryptoPP::StringSink;
using CryptoPP::StringSource;
using CryptoPP::StreamTransformationFilter;

#include "include/aes.h"
using CryptoPP::AES;

#include "include/ccm.h"
using CryptoPP::CFB_Mode;
#include "assert.h"
using CryptoPP::SecByteBlock;

int main(int argc, char* argv[])
{
	AutoSeededRandomPool prng;

	SecByteBlock key(AES::DEFAULT_KEYLENGTH);
	prng.GenerateBlock(key, key.size());

	byte iv[AES::BLOCKSIZE];
	prng.GenerateBlock(iv, sizeof(iv));

	string plain = "CFB Mode Test";
	string cipher, encoded, recovered;

	StringSource(iv, sizeof(iv), true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "iv: " << encoded << endl;

	// Pretty print key
	encoded.clear();
	StringSource(key, sizeof(key), true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "key: " << encoded << endl;

	cout << "plain text: " << plain << endl;

	CFB_Mode< AES >::Encryption e;
	e.SetKeyWithIV(key, sizeof(key), iv);

	// The StreamTransformationFilter removes
	//  padding as required.
	StringSource s(plain, true, 
		new StreamTransformationFilter(e,
			new StringSink(cipher)
		) // StreamTransformationFilter
	); // StringSource

	// Pretty print
	encoded.clear();
	StringSource(cipher, true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "cipher text: " << encoded << endl;


	CFB_Mode< AES >::Decryption d;
	d.SetKeyWithIV(key, sizeof(key), iv);

	// The StreamTransformationFilter removes
	//  padding as required.
	StringSource s2(cipher, true, 
		new StreamTransformationFilter(d,
			new StringSink(recovered)
		) // StreamTransformationFilter
	); // StringSource

	cout << "recovered text: " << recovered << endl;

	return 0;
}

