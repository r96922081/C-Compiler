namespace CCompilerNs
{
    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            string inputCFile = args[0];
            string outputAsmFile = args[1];

            //string inputCFile = "../../../CExample/ReverseLinkedList.c";
            //string outputAsmFile = "../../../CExample/ReverseLinkedList.s";
            string srcCode = File.ReadAllText(inputCFile);
            Compiler.GenerateAsm(srcCode, outputAsmFile);

            //MainUt.RunAllUt();
        }
    }
}
