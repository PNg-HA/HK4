#include "cryptlib.h"
#include "secblock.h"
#include "hrtimer.h"
#include "osrng.h"
#include "modes.h"
#include "aes.h"
#include "des.h"
#include "xts.h"
#include "ccm.h"
#include "gcm.h"
#include <iostream>
using CryptoPP::CTR_Mode;

const double runTimeInSeconds = 3.0;
const double cpuFreq = 2.7 * 1000 * 1000 * 1000;

int main(int argc, char* argv[])
{
    using namespace CryptoPP;
    AutoSeededRandomPool prng;

    SecByteBlock key(32);
    prng.GenerateBlock(key, key.size());
    
    CCM< AES >::Encryption cipher;
    cipher.SetKeyWithIV(key, key.size(), key);

    const int BUF_SIZE = RoundUpToMultipleOf(1025U,
        dynamic_cast<StreamTransformation&>(cipher).OptimalBlockSize());

    AlignedSecByteBlock buf(BUF_SIZE);
    prng.GenerateBlock(buf, buf.size());

    double elapsedTimeInSeconds;
    unsigned long i=0, blocks=1;

    ThreadUserTimer timer;
    timer.StartTimer();

    do
    {
        blocks *= 2;
        for (; i<blocks; i++)
            cipher.ProcessString(buf, BUF_SIZE);
        elapsedTimeInSeconds = timer.ElapsedTimeAsDouble();
    }
    while (elapsedTimeInSeconds < runTimeInSeconds);

    const double bytes = static_cast<double>(BUF_SIZE) * blocks;
    const double ghz = cpuFreq / 1000 / 1000 / 1000;
    const double mbs = bytes / elapsedTimeInSeconds / 1024 / 1024;
    const double cpb = elapsedTimeInSeconds * cpuFreq / bytes;

    std::cout << cipher.AlgorithmName() << " benchmarks..." << std::endl;
    std::cout << "  " << ghz << " GHz cpu frequency"  << std::endl;
    std::cout << "  " << cpb << " cycles per byte (cpb)" << std::endl;
    std::cout << "  " << mbs << " MiB per second (MiB)" << std::endl;

    // std::cout << "  " << elapsedTimeInSeconds << " seconds passed" << std::endl;
    // std::cout << "  " << (word64) bytes << " bytes processed" << std::endl;

    return 0;
}