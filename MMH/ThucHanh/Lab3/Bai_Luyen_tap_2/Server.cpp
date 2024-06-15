#include "rsa.h"
using CryptoPP::RSA;
using CryptoPP::RSASS;
using CryptoPP::InvertibleRSAFunction;

#include "pssr.h"
using CryptoPP::PSS;

#include "sha.h"
using CryptoPP::SHA1;

#include "files.h"
using CryptoPP::FileSink;
using CryptoPP::FileSource;

#include "osrng.h"
using CryptoPP::AutoSeededRandomPool;

#include "SecBlock.h"
using CryptoPP::SecByteBlock;

#include <string>
using std::string;

#include <iostream>
using std::cout;
using std::endl;

#include <assert.h>

#include "hex.h"
using CryptoPP::HexEncoder;
using CryptoPP::HexDecoder;
using CryptoPP::byte;
using CryptoPP::SecByteBlock;
using CryptoPP::StringSink;
using CryptoPP::StringSource;
using CryptoPP::StreamTransformationFilter;

void SaveKey( const RSA::PublicKey& PublicKey, const string& filename )
{
    // DER Encode Key - X.509 key format
    PublicKey.Save(
        FileSink( filename.c_str(), true /*binary*/ ).Ref()
    );
}

void SaveKey( const RSA::PrivateKey& PrivateKey, const string& filename )
{
    // DER Encode Key - PKCS #8 key format
    PrivateKey.Save(
        FileSink( filename.c_str(), true /*binary*/ ).Ref()
    );
}

void LoadKey( const string& filename, RSA::PublicKey& PublicKey )
{
    // DER Encode Key - X.509 key format
    PublicKey.Load(
        FileSource( filename.c_str(), true, NULL, true /*binary*/ ).Ref()
    );
}

void LoadKey( const string& filename, RSA::PrivateKey& PrivateKey )
{
    // DER Encode Key - PKCS #8 key format
    PrivateKey.Load(
        FileSource( filename.c_str(), true, NULL, true /*binary*/ ).Ref()
    );
}
int main(int argc, char* argv[])
{
    ////////////////////////////////////////////////
    // Generate keys
    AutoSeededRandomPool rng;

    InvertibleRSAFunction parameters;
    parameters.GenerateRandomWithKeySize( rng, 1024 );

    // Load keys from files
    RSA::PublicKey publicKey;
    //LoadKey("./Bai_1/Server/pubkey", publicKey);
    LoadKey("./Bai_1/Server/pubkey.key", publicKey);
    
    // Load message from file
    string message;
    string line;
    std::ifstream file;

    file.open ("./Bai_1/Server/message.txt");
    while(file.good()) 
    { 
        getline(file,line);
        message+=line;
    }
    file.close();
    cout << "Loaded message: " << message << endl;

    // Load signature from file
    string data;
    string line2;
    std::ifstream file2;

    file.open ("./Bai_1/Server/signature.txt");
    while(file.good()) 
    { 
        getline(file,line);
        data+=line;
    }
    file.close();

    // Convert string signature -> SecByteBlock
    SecByteBlock signature( 128 );
    StringSource (data, true,
        new HexDecoder (
            new CryptoPP::ArraySink(signature, signature.size())
        )
    );

    // Print the signed message    
    string encoded;
    StringSource(signature, sizeof(signature), true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "Loaded signature: " << encoded << endl;

    // Verifier object
    RSASS<PSS, SHA1>::Verifier verifier( publicKey );

    // Verify
    cout << "Message length: " << message.length() << endl;
    cout << "Signature size: " << signature.size() << endl;
    
    bool result = verifier.VerifyMessage( (const byte*)message.c_str(),
        message.length(), signature, signature.size() );

    // Result
    if( true == result ) {
        cout << "Signature on message verified" << endl;
    } else {
        cout << "Message verification failed" << endl;
    }
    return 0;
}
