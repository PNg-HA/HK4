// g++ -g3 -ggdb -O0 -DDEBUG -I/usr/include/cryptopp Driver.cpp -o Driver.exe -lcryptopp -lpthread
// g++ -g -O2 -DNDEBUG -I/usr/include/cryptopp Driver.cpp -o Driver.exe -lcryptopp -lpthread

#include "osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include <iostream>
using std::cout;
using std::cerr;
using std::endl;

#include <string>
using std::string;

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

#include "aes.h"
using CryptoPP::AES;

#include "modes.h"
using CryptoPP::CBC_Mode;

#include "secblock.h"
using CryptoPP::SecByteBlock;
using CryptoPP::byte;

#include <locale>
#include <codecvt>
#include <string>
#include <io.h>
#include <fcntl.h>
#include <stdio.h>


int main(int argc, char* argv[])
{
	AutoSeededRandomPool prng;

	SecByteBlock key(AES::DEFAULT_KEYLENGTH);
	prng.GenerateBlock(key, key.size());

	byte iv[AES::BLOCKSIZE];
	prng.GenerateBlock(iv, sizeof(iv));


	std::wstring wplain = L"صفحة";
    std::wstring_convert<std::codecvt_utf8<wchar_t>> converter;
	std::string plain = converter.to_bytes(wplain);
	
	
	string cipher, encoded, recovered;
	std::wstring wencoded;

	/*********************************\
	\*********************************/

    // cout << "key length: " << DES::DEFAULT_KEYLENGTH << endl;
    // cout << "block size: " << DES::BLOCKSIZE << endl;

	// Pretty print key
	encoded.clear();
	StringSource(key, key.size(), true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "key: " << encoded << endl;

	// Pretty print iv
	encoded.clear();
	StringSource(iv, sizeof(iv), true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "iv: " << encoded << endl;

	/*********************************\
	\*********************************/

	_setmode(_fileno(stdout), _O_U16TEXT); // <=== Windows madness
	try
	{
		std::wcout << "plain text: " << wplain << std::endl;

		CBC_Mode< AES >::Encryption e;
		e.SetKeyWithIV(key, key.size(), iv);

		// The StreamTransformationFilter adds padding
		//  as required. ECB and CBC Mode must be padded
		//  to the block size of the cipher.
		StringSource(plain, true, 
			new StreamTransformationFilter(e,
				new StringSink(cipher)
			) // StreamTransformationFilter      
		); // StringSource
	}
	catch(const CryptoPP::Exception& e)
	{
		cerr << e.what() << endl;
		exit(1);
	}

	/*********************************\
	\*********************************/

	// Pretty print
	encoded.clear();
	StringSource(cipher, true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	std::wstring_convert<std::codecvt_utf8_utf16<wchar_t>> converter1;
    wencoded = converter1.from_bytes(encoded);

	std::wcout << "cipher text: " << wencoded << endl;

	/*********************************\
	\*********************************/

	try
	{
		CBC_Mode< AES >::Decryption d;
		d.SetKeyWithIV(key, key.size(), iv);

		// The StreamTransformationFilter removes
		//  padding as required.
		StringSource s(cipher, true, 
			new StreamTransformationFilter(d,
				new StringSink(recovered)
			) // StreamTransformationFilter
		); // StringSource
    	std::wstring wrecovered = converter1.from_bytes(recovered);

		std::wcout << "recovered text: " << wrecovered << endl;
	}
	catch(const CryptoPP::Exception& e)
	{
		cerr << e.what() << endl;
		exit(1);
	}

	/*********************************\
	\*********************************/

	return 0;
}