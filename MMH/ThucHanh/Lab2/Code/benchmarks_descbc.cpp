#include "include/cryptlib.h"
#include "include/secblock.h"
#include "include/hrtimer.h"
#include "include/osrng.h"
#include "include/modes.h"
#include "include/aes.h"
#include "include/des.h"
#include <iostream>
using CryptoPP::CTR_Mode;

const double runTimeInSeconds = 3.0;
const double cpuFreq = 2.7 * 1000 * 1000 * 1000;

int main(int argc, char* argv[])
{
    using namespace CryptoPP;
    AutoSeededRandomPool prng;

    SecByteBlock key(DES::DEFAULT_KEYLENGTH);
    prng.GenerateBlock(key, key.size());

    byte iv[DES::BLOCKSIZE];
	prng.GenerateBlock(iv, sizeof(iv));
    CBC_Mode< DES >::Encryption cipher;
    cipher.SetKeyWithIV(key, key.size(), iv);

    const int BUF_SIZE = RoundUpToMultipleOf(2048U,
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