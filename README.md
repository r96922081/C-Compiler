

## C Compiler 
This is a C compiler written by C#, supports several (not all) C89 syntax. 

Compile, [8-Queen.c](https://github.com/r96922081/C-Compiler/blob/main/CExample/EightQueen.c), it generates [8-Queen.s](https://github.com/r96922081/C-Compiler/blob/main/CExample/EightQueen.s), here is the output of 8-Queen.exe

    . . . . . . . Q
    . . . Q . . . .
    Q . . . . . . .
    . . Q . . . . .
    . . . . . Q . .
    . Q . . . . . .
    . . . . . . Q .
    . . . . Q . . .
    Solution count =  92
    
Compile [LCS.c](https://github.com/r96922081/C-Compiler/blob/main/CExample/LCS.c)  (Longest common subsequence), it generates [LCS.s](https://github.com/r96922081/C-Compiler/blob/main/CExample/LCS.s), here is the output of LCS.exe

    Length of Longest Common Subsequence of AGGTABWZ, GXTXAYBYZ :  5
    Longest Common Subsequence: GTABZ

Compile [ReverseLinkedList.c](https://github.com/r96922081/C-Compiler/blob/main/CExample/ReverseLinkedList.c), it generates [ReverseLinkedList.s](https://github.com/r96922081/C-Compiler/blob/main/CExample/ReverseLinkedList.s), here is the output of ReverseLinkedList.exe

    Original list: 50 -> 40 -> 30 -> 20 -> 10 -> NULL
    Reversed list: 10 -> 20 -> 30 -> 40 -> 50 -> NULL
## How to Run

 1. Generate AT&T syntax ASM

        C-Compiler.exe D:\github\C-Compiler\CExample\LCS.c D:\github\C-Compiler\CExample\LCS.s

 1. Generate executable by gcc

        gcc -no-pie -o LCS.exe LCS.s
        
 1. Run LCS.exe

        LCS.exe
        Length of Longest Common Subsequence of AGGTABWZ, GXTXAYBYZ :  5
        Longest Common Subsequence: GTABZ
## Architecture
![enter image description here](https://r96922081.github.io/C-Compiler/arch.png)

[LexYacc](https://github.com/r96922081/LexYacc) is my another project, it generates C# code.

[cc.l](https://github.com/r96922081/C-Compiler/blob/main/LexYaccInput/cc.l) 

[cc.y](https://github.com/r96922081/C-Compiler/blob/main/LexYaccInput/cc.y)
