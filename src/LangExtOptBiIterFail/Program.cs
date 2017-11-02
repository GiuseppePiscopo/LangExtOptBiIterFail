using LanguageExt;
using System;
using System.Threading.Tasks;
using static LanguageExt.Prelude;

namespace LangExtOptBiIterFail
{
    public class Program
    {
        public static void Main(string[] _)
        {
            Console.WriteLine("Press key to start");
            Console.ReadKey();

            RunIssue().Wait();

            Console.WriteLine("Press key to terminate");
            Console.ReadKey();
        }

        static Task RunIssue()
        {
            return ValidateAsync();
        }

        static async Task<Unit> ValidateAsync()
        {
            Option<string> textOpt = await Task.Run(() => (Option<string>)None);

            Unit doAction = textOpt.BiIter(
                None: () =>
                    Console.WriteLine("Do Action None"),
                Some: text =>
                    Console.WriteLine($"Do Action Some: '{text ?? "<null>"}'"));

            return doAction;
        }
    }
}
