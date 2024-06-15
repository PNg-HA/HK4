.section .data
        NhapSo:
                .string "Enter a 1-digit number: "
        NS_len = . -NhapSo

        Count4:
                .string "Count 4x: "
        C4_len = . -Count4
        divisor:
                .int 4
        #InputCount:
        #       .int 0
.section .bss
        .lcomm InputN, 4                                # So' se~ nhap
        .lcomm SoDu, 4
        .lcomm InputCount, 4                            # bien' dem'
.section .text
        .globl _start
_start:
        movl    $0, InputCount
        movl    $0, %edi                                # i = 0
loop1:
        cmpl    $5, %edi
        je      Exit
        call    NhapNam                                 # jump to the show-"Enter a 1-digit number"-string show function
        call    Keyboard1                               # jump to the input from keyboard func
        call    div4_1                                  # divide by 4

        movl    %edx, SoDu                              # SoDu = Input % 4, for printing, not related to program
        #addl   $48, SoDu                               # To read in ASCII

        cmpl    $0, %edx                                # If (Input % 4 == 0), then
        jne     EndIf
        addl    $1, InputCount                          # count4x++
EndIf:
        incl    %edi                                    # i++
        # cmpl  $4, %edi                                # Compare i:4
        jmp     loop1                                   # If i <= 4, Goto loop1
Exit:
        #call    HienSoBoi
        # In ra"Count4x: "
        movl    $Count4, %ecx                           # messeage length
        movl    $11, %edx
        movl    $4, %eax
        movl    $1, %ebx
        int     $0x80

        # Tinh' so boi cua 4
        addl    $48, InputCount                         # Chuyen int sang ascii, vd: 0 -> 48 trong ascii la` 0
        movl    $InputCount, %ecx                       #  messeage length
        movl    $2, %edx
        movl    $4, %eax
        movl    $1, %ebx
        int     $0x80

        movl    $1, %eax                                # system_exit prepare
        int     $0x80                                   # Exit
        # In so' du
NhapNam:
        # In "Enter ...: "
        movl    $NS_len, %edx                           # messeage length
        movl    $NhapSo, %ecx
        movl    $4, %eax
        movl    $1, %ebx
        int     $0x80
        ret
Keyboard1:
        # Get input from keyboard
        movl    $2, %edx                                # messeage length
        movl    $InputN, %ecx
        movl    $3, %eax
        movl    $0, %ebx
        int     $0x80
        ret
div4_1:
        # Chia cho 4
        movl    $0, %edx                                # refresh register edx
        movl    InputN, %eax                            # So bi chia = so nhap tu ban` phim
        movl    $4, %ecx                                # so chia = 4
        divl    %ecx                                    # thuc. hien. phep' chia

        movl    %edx, SoDu                              # De` phong` %edx thay doi?, luu so' du tu` edx -> bien' SoDu
        addl    $48, SoDu                               # Chuyen sang ascii
        ret
#IncCount:
#       incl    InputCount
#       jmp     Next
#HienSoBoi:
#       # In "Count4x: "
#       movl    $Count4, %ecx                   # NhapNam messeage length
#        movl    $11, %edx
#        movl    $4, %eax
#        movl    $1, %ebx
#        int     $0x80
#        ret
SoBoi:
#       addl    $48, InputCount
#       movl    $InputCount, %ecx                   # NhapNam messeage length
#       movl    $2, %edx
#       movl    $4, %eax
#       movl    $1, %ebx
#       int     $0x80
#       ret