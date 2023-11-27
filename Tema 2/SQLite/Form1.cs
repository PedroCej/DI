using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using static System.Net.WebRequestMethods;


namespace SQLite
{
    public partial class Form1 : Form
    {
        SQLiteConnection conexion;
        SQLiteCommand comando;
        SQLiteDataAdapter adaptador;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();

            String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            String strFilePath = Path.Combine(strAppPath, "Resources");
            String strFullFilename = Path.Combine(strFilePath, "BDSQLite.db");
            conexion = new SQLiteConnection("Data Source = " + strFullFilename + " ; Version = 3; New = False; Compress = True; ");



        }
    }
}