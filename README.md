

# C Compiler 
A C compiler written by C#, supports subset of C89 syntax. 


## Compile 8-Queen
C code: [8-Queen.c](https://github.com/r96922081/C-Compiler/blob/main/CExample/EightQueen.c), generated ASM code: [8-Queen.s](https://github.com/r96922081/C-Compiler/blob/main/CExample/EightQueen.s)\
\
Output of exe:\
\
![enter image description here](https://r96922081.github.io/C-Compiler/EightQueen.png)

## Compile LCS (Longest common subsequence)
[C code](https://github.com/r96922081/C-Compiler/blob/main/CExample/LCS.c), [generated ASM code](https://github.com/r96922081/C-Compiler/blob/main/CExample/LCS.s)\
\
Output of exe:\
\
![enter image description here](https://r96922081.github.io/C-Compiler/LCS.png)

## Compile ReverseLinkedList
C code: [LCS.c](https://github.com/r96922081/C-Compiler/blob/main/CExample/ReverseLinkedList.c), generated ASM code: [ReverseLinkedList.s](https://github.com/r96922081/C-Compiler/blob/main/CExample/ReverseLinkedList.s)\
\
Output of exe:\
\
![enter image description here](https://r96922081.github.io/C-Compiler/ReverseLinkedList.png)

## Compile MagicSquare
C code: [MagicSquare.c](https://github.com/r96922081/C-Compiler/blob/main/CExample/MagicSquare.c), generated ASM code: [MagicSquare.s](https://github.com/r96922081/C-Compiler/blob/main/CExample/MagicSquare.s)\
\
Output of exe:\
\
![enter image description here](https://r96922081.github.io/C-Compiler/MagicSquare.png)

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
