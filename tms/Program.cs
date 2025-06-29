using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using tms.Data;
using tms.DataSeed;
using Login;

namespace tms
{
    internal static class Program
    {
        public static MySqlConnection Connection;
        public static Confi Confi;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (!ReadConfig())
                return;

            var connectionString = Confi.GetConnectionString(); // ✅ Use the actual connection string


            MessageBox.Show("✅ MySQL database initialization complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Run(new LoginFrm());
        }

        private static bool ReadConfig()
        {
            try
            {
                var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsetting.json");
                var json = File.ReadAllText(jsonPath);
                Confi = JsonSerializer.Deserialize<Confi>(json) ?? new Confi();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to read configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public class Confi
    {
        public string server { get; set; }
        public string database { get; set; }
        public string uid { get; set; }
        public string password { get; set; }
        public int port { get; set; }

        public string GetConnectionString()
        {
            return $"server={server};port={port};database={database};uid={uid};pwd={password};";
        }
    }
}
