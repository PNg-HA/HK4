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
    RSA::PrivateKey privateKey;
    RSA::PublicKey publicKey;
    LoadKey("../key/pubkey.key", publicKey);
    LoadKey("../key/private.key", privateKey);

    // Load message from file
    string message;
    string line;
    std::ifstream file;

    file.open ("./Bai_1/Client/message.txt");
    while(file.good()) 
    { 
        getline(file,line);
        message+=line;
    }
    file.close();
    cout << "Loaded message: " << message << endl;
    
    // Signer object
    RSASS<PSS, SHA1>::Signer signer( privateKey ); //use PriKey to sign

    // Create signature space
    size_t length = signer.MaxSignatureLength();
    SecByteBlock signature( length );
    cout << "length: " << length << endl;

    // Sign message
    length = signer.SignMessage( rng, (const byte*) message.c_str(), message.length(), signature );
    
    // Resize the true length of signature
    signature.resize(length);

    string encoded;
    
    // Print the signed message
    StringSource(signature, sizeof(signature), true,
		new HexEncoder(
			new StringSink(encoded)
		) // HexEncoder
	); // StringSource
	cout << "signature: " << encoded << endl;

    // Save the signature
    std::ofstream ofs("./Bai_1/Client/signature.txt");
    ofs << encoded;
    ofs.close();

    // Load signature
    string data;
    string line2;
    std::ifstream file2;

    file.open ("./Bai_1/Client/signature.txt");
    while(file.good()) 
    { 
        getline(file,line);
        data+=line;
    }
    file.close();
    cout << "Loaded signature: " << data << endl;
    
    SecByteBlock signature2(length);
    // Convert string signature -> SecByteBlock
    StringSource (data, true,
        new HexDecoder (
            new CryptoPP::ArraySink(signature2, signature2.size())
        )
    );
    
    // Verifier object
    RSASS<PSS, SHA1>::Verifier verifier( publicKey );

    // Verify
    cout << "Message length: " << message.length() << endl;
    cout << "Signature size: " << signature2.size() << endl;
    bool result = verifier.VerifyMessage( (const byte*)message.c_str(),
        message.length(), signature2, signature2.size() );

    // Result
    if( true == result ) {
        cout << "Signature on message verified" << endl;
    } else {
        cout << "Message verification failed" << endl;
    }
    return 0;
}
