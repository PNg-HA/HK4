#include <fstream>
#include <iostream>
#include <filesystem>
using namespace std;
#include <string>
using std::string;
#include "sha.h"
using CryptoPP::SHA1;
#include "filters.h"
using CryptoPP::ArraySink;
using CryptoPP::SignatureVerificationFilter;
using CryptoPP::StringSink;
using CryptoPP::StringSource;
#include <base64.h>
#include <hex.h>
using CryptoPP::HexEncoder;
#include "files.h"
using CryptoPP::FileSink;
using CryptoPP::FileSource;
#include "eccrypto.h"
using CryptoPP::DL_GroupParameters_EC;
using CryptoPP::ECDSA;
using CryptoPP::ECP;
using std::cout;

void LoadPublicKey(const string &filename, ECDSA<ECP, SHA1>::PublicKey &key);
void PrintPublicKey(const ECDSA<ECP, SHA1>::PublicKey &key);
bool VerifyMessage(const ECDSA<ECP, SHA1>::PublicKey &publicKey, string &message, string &signature);
string ReadData(string filename);
void removePrefix(std::string &str, const std::string &prefix);
void removeSuffix(std::string& str, const std::string& suffix);
string GetMessage(string path);

string hex(string decoded) {
    string encoded;
    StringSource ss(decoded, true,
        new HexEncoder(
            new StringSink(encoded)
        ) // HexDecoder
    ); // StringSource
    return encoded;
}

int main(int argc, char *argv[])
{
    ECDSA<ECP, SHA1>::PublicKey key;
    LoadPublicKey("./ec.public.key", key);
    string prefix = ReadData("./uit.png");
    string message = GetMessage("./uit.png");
    std::filesystem::path directoryPath = "./signature";
        if (std::filesystem::exists(directoryPath) && std::filesystem::is_directory(directoryPath)) {
        std::vector<std::string> filePaths;

        for (const auto& entry : std::filesystem::directory_iterator(directoryPath)) {
            if (entry.is_regular_file()) {
                filePaths.push_back(entry.path().string());
            }
        }

        // Access the file paths in the vector for further processing
        for (const auto& filePath : filePaths) {
            string signature = ReadData(filePath);
            removePrefix(signature, prefix);
            if (VerifyMessage(key, message, signature))        
                cout << "ya sua, valid signature in: " << filePath << endl;        
            else
                cout << "Invalid" << endl;     
        }
    } 
    else {
        std::cout << "Invalid directory path." << std::endl;
        return 1;
    }
}
void removeSuffix(std::string& str, const std::string& suffix) {
    if (str.size() >= suffix.size() && str.compare(str.size() - suffix.size(), suffix.size(), suffix) == 0) {
        str.erase(str.size() - suffix.size());
    }
}
void PrintPublicKey(const ECDSA<ECP, SHA1>::PublicKey &key)
{
    cout << "Public Key:" << endl;
    cout << " X: " << key.GetPublicElement().x << endl;
    cout << " Y: " << key.GetPublicElement().y << endl;
}
void LoadPublicKey(const string &filename, ECDSA<ECP, SHA1>::PublicKey &key)
{
    key.Load(FileSource(filename.c_str(), true /*pump all*/).Ref());
}
string ReadData(string filename)
{
    std::ifstream file(filename, std::ios::binary);
    if (!file)
    {
        cout << "Can't open file!" << endl;
        return "";
    }
    string data;
    char ch;
    while (file.get(ch))
        data += ch;
    file.close();
    return data;
}
bool VerifyMessage(const ECDSA<ECP, SHA1>::PublicKey &publicKey, string &message, string &signature)
{
    bool result = false;
    StringSource(signature + message, true,
                 new SignatureVerificationFilter(
                     ECDSA<ECP, SHA1>::Verifier(publicKey),
                     new ArraySink((CryptoPP::byte *)&result, sizeof(result))));
    return result;
}
string GetMessage(string path)
{
    string input, encoded;
    CryptoPP::FileSource file(path.c_str(), true, new StringSink(input));
    CryptoPP::StringSource(input, true,
                           new CryptoPP::Base64Encoder(
                               new CryptoPP::StringSink(encoded)));
    return encoded;
}
void removePrefix(std::string &str, const std::string &prefix)
{
    if (str.substr(0, prefix.size()) == prefix)
        str.erase(0, prefix.size());
}