.section .data
        rs:
                .string "Hello, World"
        rs_len = . -rs
.section .text
        .globl _start
_start:
movl $rs_len, %edx # message length
movl $rs, %ecx # address of message to write
movl $1, %ebx # file descriptor (stdout)
movl $4, %eax # system call number (sys_write)
int $0x80 # call kernel
movl $1, %eax # system call number (sys_exit)
int $0x80