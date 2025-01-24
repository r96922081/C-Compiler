namespace CCompilerNs
{
    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            List<string> cFiles = new List<string>();
            cFiles.Add("EightQueen.c");
            cFiles.Add("MagicSquare.c");

            foreach (string cFile in cFiles)
            {
                string inputCFile = Path.Join("../../../CExample/", cFile).ToString();
                string srcCode = File.ReadAllText(inputCFile);

                string outputAsmFile = inputCFile.Replace(".c", ".s");
                Compiler.GenerateAsm(srcCode, outputAsmFile);
            }

            //MainUt.RunAllUt();
        }
    }
}
