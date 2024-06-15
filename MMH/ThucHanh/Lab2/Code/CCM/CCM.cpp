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
    using namespace std;
    using namespace CryptoPP;
    AutoSeededRandomPool prng;
    HexEncoder encoder(new FileSink(std::cout));

    SecByteBlock key( AES::DEFAULT_KEYLENGTH );
    prng.GenerateBlock( key, key.size() );

    // { 7, 8, 9, 10, 11, 12, 13 }
    CryptoPP::byte iv[12];
    prng.GenerateBlock( iv, sizeof(iv) );    

    // { 4, 6, 8, 10, 12, 14, 16 }
    const int TAG_SIZE = 8;

    // Plain text
    string pdata="CCM Mode Test";
    std::cout << "plain text: " << pdata << std::endl;

    // Encrypted, with Tag
    string cipher;

    // Recovered plain text
    string rpdata;

    /*********************************\
    \*********************************/

    try
    {
        CCM< AES, TAG_SIZE >::Encryption e;
        e.SetKeyWithIV( key, key.size(), iv, sizeof(iv) );
        e.SpecifyDataLengths( 0, pdata.size(), 0 );

        StringSource ss1( pdata, true,
            new AuthenticatedEncryptionFilter( e,
                new StringSink( cipher )
            ) // AuthenticatedEncryptionFilter
        ); // StringSource
    }
    catch( CryptoPP::Exception& e )
    {
        cerr << "Caught Exception..." << endl;
        cerr << e.what() << endl;
        cerr << endl;
    }

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

    /*********************************\
    \*********************************/

    try
    {
        CCM< AES, TAG_SIZE >::Decryption d;
        d.SetKeyWithIV( key, key.size(), iv, sizeof(iv) );
        d.SpecifyDataLengths( 0, cipher.size()-TAG_SIZE, 0 );

        AuthenticatedDecryptionFilter df( d,
            new StringSink( rpdata )
        ); // AuthenticatedDecryptionFilter

        // The StringSource dtor will be called immediately
        //  after construction below. This will cause the
        //  destruction of objects it owns. To stop the
        //  behavior so we can get the decoding result from
        //  the DecryptionFilter, we must use a redirector
        //  or manually Put(...) into the filter without
        //  using a StringSource.
        StringSource ss2( cipher, true,
            new Redirector( df )
        ); // StringSource

        // If the object does not throw, here's the only
        //  opportunity to check the data's integrity
        if( true == df.GetLastResult() ) {
            cout << "recovered text: " << rpdata << endl;
        }
    }
    catch( CryptoPP::Exception& e )
    {
        cerr << "Caught Exception..." << endl;
        cerr << e.what() << endl;
        cerr << endl;
    }
}