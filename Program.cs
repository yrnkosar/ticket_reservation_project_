namespace Prolab2
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
          
            ApplicationConfiguration.Initialize();
            Application.Run(new giris());
        }
    }
}