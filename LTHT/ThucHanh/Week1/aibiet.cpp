#include <iostream>
using namespace std;
int bitOr(int a, int b){
    int kq = ~((~a) & (~b));
    return kq;
}
int negative (int x){
    int kq = ((~x) + 1);
    return kq;
}
int flitBit (int x, int n){
    int kq = x ^ (1 << n);
    return kq;
}
int getByte(int x, int n){
    int kq = x >> ((n << 3)) & 0xFF;
    return kq;
}
void PrintBits(unsigned int x) {
    int i;
    for (i = 8 * sizeof(x)-1; i >= 0; i--) {
        (x & (1 << i)) ? putchar('1') : putchar('0');
        if (i % 4 == 0){
            cout << " ";
        }
    }
    printf("\n");
}
void PrintBitsOfByte(unsigned int x) {
    int i;
    for (i = 7; i >= 0; i--) {
        (x & (1 << i)) ? putchar('1') : putchar('0');
        if (i % 4 == 0){
            cout << " ";
        }
    }
    printf("\n");
}
int main()
{
    PrintBits(3 >> 2);
    cout << "";
    cout << endl;
    //PrintBits(17);
    //PrintBitsOfByte(17);
    cout << "bai 1: " << (bitOr(3,-9) == (3|-9)) << endl;
    cout << "bai 2: " << ((negative(0)==0) && (negative(9)==-9) && (negative(-5)==5)) << endl;
    cout << "bai 3: " << (flitBit(15,0) == 14 && flitBit(0,3) == 8
                                                && flitBit(0x3344,9) == 0x3144
                                                && flitBit(0x7fffffff,31) == 0xffffffff)  
         << endl;
    cout << "bai 4: " << (getByte(8,0) == 8 && getByte(0x11223344, 1) == 0x33)
         << endl;
    return 0;
}
