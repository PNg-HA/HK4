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
using CryptoPP::CBC_Mode;

#include "assert.h"
#include "include/secblock.h"
#include "include/hrtimer.h"
#include "include/modes.h"
#include "include/des.h"
using CryptoPP::CTR_Mode;
using namespace CryptoPP;

const double runTimeInSeconds = 3.0;
const double cpuFreq = 2.7 * 1000 * 1000 * 1000;

int main(int argc, char* argv[])
{
	AutoSeededRandomPool prng;

	byte key[AES::DEFAULT_KEYLENGTH];
	prng.GenerateBlock(key, sizeof(key));

	byte iv[AES::BLOCKSIZE];
	prng.GenerateBlock(iv, sizeof(iv));

	string plain = "CBC Mode Test";
	string cipher, encoded, recovered;

	/*********************************\
	\*********************************/

	// Pretty print key
	encoded.clear();
	StringSource(key, sizeof(key), true,
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

		CBC_Mode< AES >::Encryption e;
		e.SetKeyWithIV(key, sizeof(key), iv);

		// Create the random plaintext
		const int BUF_SIZE = RoundUpToMultipleOf(2048U,
        	dynamic_cast<StreamTransformation&>(e).OptimalBlockSize());
		AlignedSecByteBlock buf(BUF_SIZE);
		prng.GenerateBlock(buf, buf.size());

		// Pretty print the random plaintext
		encoded.clear();
		StringSource(buf, sizeof(buf), true,
				new HexEncoder(
					new StringSink(encoded)
				) // HexEncoder
			); // StringSource
		cout << "plain text: " << encoded << endl;

		double elapsedTimeInSeconds;
		unsigned long i=0, blocks=1;

		// Encrypt the plaintext "buf" >> "buf"
		e.ProcessString(buf, BUF_SIZE);
		e.ProcessString(buf, BUF_SIZE);

		// Pretty print cipher
		encoded.clear();
		StringSource(buf, sizeof(buf), true,
				new HexEncoder(
					new StringSink(encoded)
				) // HexEncoder
			); // StringSource
		cout << "cipher text: " << encoded << endl;

		ThreadUserTimer timer;
		timer.StartTimer();
		int countloop = 0;

		CBC_Mode< AES >::Decryption d;
		d.SetKeyWithIV(key, sizeof(key), iv);
		// do
		// {
		// 	blocks *= 2;
		// 	for (; i<blocks; i++){
		// 		d.ProcessString(buf, BUF_SIZE);
				
		// 	}
				
		// 	elapsedTimeInSeconds = timer.ElapsedTimeAsDouble();
			
		// }
		// while (elapsedTimeInSeconds < runTimeInSeconds);
		
		// Pretty Print decrypt
		d.ProcessString(buf, BUF_SIZE);
		d.ProcessString(buf, BUF_SIZE);
		encoded.clear();
		StringSource(buf, sizeof(buf), true,
				new HexEncoder(
					new StringSink(encoded)
				) // HexEncoder
			); // StringSource
		cout << "recovered text: " << encoded << endl;
		const double bytes = static_cast<double>(BUF_SIZE) * blocks;
		const double ghz = cpuFreq / 1000 / 1000 / 1000;
		const double mbs = bytes / elapsedTimeInSeconds / 1024 / 1024;
		const double cpb = elapsedTimeInSeconds * cpuFreq / bytes;
		
		// std::cout << e.AlgorithmName() << " benchmarks..." << std::endl;
		// std::cout << "  " << ghz << " GHz cpu frequency"  << std::endl;
		// std::cout << "  " << cpb << " cycles per byte (cpb)" << std::endl;
		// std::cout << "  " << mbs << " MiB per second (MiB)" << std::endl;


	//	cout << "recovered text: " << recovered << endl;
	
	/*********************************\
	\*********************************/

	return 0;
}

