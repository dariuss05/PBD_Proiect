using Microsoft.Win32;
using System;

namespace PBD_Proiect.LoginApp
{
    class DatabaseConnection
    {
        public static string databaseConnectionString = @"Data Source=" + getDataSource() + ";Initial Catalog=Students;Integrated Security=True";
        private static string getDataSource()
        {
            string serverMachineName = Environment.MachineName;
            string dataSource = String.Empty;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        dataSource = dataSource + (serverMachineName + "\\" + instanceName);
                    }
                }
            }
            return dataSource;
        }
    }
}
