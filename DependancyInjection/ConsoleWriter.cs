using System.Diagnostics;

namespace AxiaBackend.DependancyInjection
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void Write()
        {
            Debug.WriteLine("testing dependancy injection..");
        }
    }
}
