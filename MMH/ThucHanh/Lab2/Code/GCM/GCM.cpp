#include "cryptlib.h"
#include "aes.h"
#include "modes.h"
#include "files.h"
#include "osrng.h"
#include "hex.h"

#include "ccm.h"
#include <xts.h>
#include <gcm.h>

#include <iostream>
#include <string>

int main(int argc, char* argv[])
{
    using namespace CryptoPP;
    using namespace std;

    AutoSeededRandomPool prng;
    HexEncoder encoder(new FileSink(std::cout));

    SecByteBlock key( AES::DEFAULT_KEYLENGTH );
    prng.GenerateBlock( key, key.size() );

    CryptoPP::byte iv[ AES::BLOCKSIZE ];
    prng.GenerateBlock( iv, sizeof(iv) );    

    const int TAG_SIZE = 12;
    const int DEFAULT_FLAGS = 12;

    // Plain text
    string pdata="GCM Mode Test";
    std::cout << "plain text: " << pdata << std::endl;


    // Encrypted, with Tag
    string cipher, encoded;

    // Recovered plain text
    string rpdata;

    /*********************************\
    \*********************************/

    try
    {
        GCM< AES >::Encryption e;
        e.SetKeyWithIV( key, key.size(), iv, sizeof(iv) );

        StringSource ss1( pdata, true,
            new AuthenticatedEncryptionFilter( e,
                new StringSink( cipher ), false, TAG_SIZE
            ) // AuthenticatedEncryptionFilter
        ); // StringSource
    }
    catch( CryptoPP::Exception& e )
    {
        cerr << e.what() << endl;
        exit(1);
    }

    /*********************************\
    \*********************************/
    std::cout << "key: ";
    encoder.Put(key, key.size());
    encoder.MessageEnd();
    std::cout << std::endl;

    std::cout << "iv: ";
    encoder.Put(iv, sizeof(iv));
    encoder.MessageEnd();
    std::cout << std::endl;

    std::cout << "cipher text: ";
    encoder.Put((const CryptoPP::byte*)&cipher[0], cipher.size());
    encoder.MessageEnd();
    std::cout << std::endl;

    try
    {
        GCM< AES >::Decryption d;
        d.SetKeyWithIV( key, key.size(), iv, sizeof(iv) );

        AuthenticatedDecryptionFilter df( d,
            new StringSink( rpdata ),
            DEFAULT_FLAGS, TAG_SIZE
        ); // AuthenticatedDecryptionFilter

        // The StringSource dtor will be called immediately
        //  after construction below. This will cause the
        //  destruction of objects it owns. To stop the
        //  behavior so we can get the decoding result from
        //  the DecryptionFilter, we must use a redirector
        //  or manually Put(...) into the filter without
        //  using a StringSource.
        StringSource ss2( cipher, true,
            new Redirector( df /*, PASS_EVERYTHING */ )
        ); // StringSource

        // If the object does not throw, here's the only
        //  opportunity to check the data's integrity
        if( true == df.GetLastResult() ) {
            cout << "recovered text: " << rpdata << endl;
        }
    }
    catch( CryptoPP::Exception& e )
    {
        cerr << e.what() << endl;
        exit(1);
}   
}