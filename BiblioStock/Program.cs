using BiblioStock.Formularios;

namespace BiblioStock
{
    
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        
        }
    }
}