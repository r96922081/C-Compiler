using System.Diagnostics;
using System.Text;

namespace CCompilerNs
{
    public class ProgramMain
    {
        public static void CompileAsm(string asmPath, string exePath)
        {
            Process gcc = new Process();
            gcc.StartInfo.FileName = "gcc.exe";
            gcc.StartInfo.Arguments = "-no-pie -o " + exePath + " " + asmPath;

            gcc.Start();
            gcc.WaitForExit();
            if (gcc.ExitCode != 0)
                throw new Exception("Compile failed");
        }

        public static void RunExe(string exePath)
        {
            Process exe = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            StringBuilder outputBuilder = new StringBuilder();

            exe.OutputDataReceived += (sender, args) =>
            {
                if (args.Data != null)
                {
                    outputBuilder.AppendLine(args.Data);
                }
            };

            exe.Start();
            exe.BeginOutputReadLine();
            exe.WaitForExit();

            string output = outputBuilder.ToString();

            Console.Write(output);
        }

        public static void Main(string[] args)
        {
            string file = "../../../CExample/LCS";
            string c = file + ".c";
            string asm = file + ".s";
            string exe = file + ".exe";

            Compiler.GenerateAsm(File.ReadAllText(c), asm);
            CompileAsm(asm, exe);
            RunExe(exe);

            //MainUt.RunAllUt();
        }
    }
}
