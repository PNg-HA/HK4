#include "cryptlib.h"
#include "aes.h"
#include "modes.h"
#include "files.h"
#include "osrng.h"
#include "hex.h"

#include <ccm.h>
#include <xts.h>
#include <gcm.h>

#include <iostream>
#include <string>

int main(int argc, char* argv[])
{
    using namespace CryptoPP;
    
    AutoSeededRandomPool prng;
    HexEncoder encoder(new FileSink(std::cout));

    SecByteBlock key(32), iv(16);
    prng.GenerateBlock( key, key.size() );
    prng.GenerateBlock( iv, iv.size() );

    std::string plain = "XTS Mode Test XTS Mode Test";
    std::string cipher, encoded, recovered;

    /*********************************\
    \*********************************/

    try
    {
        std::cout << "plain text: " << plain << std::endl;

        XTS_Mode< AES >::Encryption enc;
        enc.SetKeyWithIV( key, key.size(), iv );

        // The StreamTransformationFilter adds padding
        //  as requiredec. ECB and XTS Mode must be padded
        //  to the block size of the cipher.
        StringSource ss( plain, true, 
            new StreamTransformationFilter( enc,
                new StringSink( cipher ),
                StreamTransformationFilter::NO_PADDING
            ) // StreamTransformationFilter      
        ); // StringSource
    }
    catch( const CryptoPP::Exception& ex )
    {
        std::cerr << ex.what() << std::endl;
        exit(1);
    }

    std::cout << "key: ";
    encoder.Put(key, key.size());
    encoder.MessageEnd();
    std::cout << std::endl;

    std::cout << "iv: ";
    encoder.Put(iv, iv.size());
    encoder.MessageEnd();
    std::cout << std::endl;

    /*********************************\
    \*********************************/

    // Pretty print cipher text
    StringSource ss( cipher, true,
        new HexEncoder(
            new StringSink( encoded )
        ) // HexEncoder
    ); // StringSource
    std::cout << "cipher text: " << encoded << std::endl;

    /*********************************\
    \*********************************/

    try
    {
        XTS_Mode< AES >::Decryption dec;
        dec.SetKeyWithIV( key, key.size(), iv );

        // The StreamTransformationFilter removes
        //  padding as requiredec.
        StringSource ss( cipher, true, 
            new StreamTransformationFilter( dec,
                new StringSink( recovered ),
                StreamTransformationFilter::NO_PADDING
            ) // StreamTransformationFilter
        ); // StringSource

        std::cout << "recovered text: " << recovered << std::endl;
    }
    catch( const CryptoPP::Exception& ex )
    {
        std::cerr << ex.what() << std::endl;
        exit(1);
    }
}