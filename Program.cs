using System;
using System.Globalization;
using System.Windows.Forms;

namespace FlowerSales
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Nöqtəli say formatı (5.6, 22.40) üçün invariant mədəniyyət
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
