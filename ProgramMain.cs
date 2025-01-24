namespace CCompilerNs
{
    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            string inputCFile = "../../../CExample/LCS.c";
            string srcCode = File.ReadAllText(inputCFile);
            string outputAsmFile = "../../../CExample/LCS.s";
            Compiler.GenerateAsm(srcCode, outputAsmFile);

            //MainUt.RunAllUt();
        }
    }
}
