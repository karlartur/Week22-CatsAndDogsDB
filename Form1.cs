using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColordDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColordDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateShadesTable();
        }
        private void PopulateShadesTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColor", connection))
            {
                DataTable shadesTable = new DataTable();
                adapter.Fill(shadesTable);

                listShades.DisplayMember = "PrimaryColorName";
                listShades.ValueMember = "Id";
                listShades.DataSource = shadesTable;
            }
                    

        }

        private void listShades_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShadeNames();
        }
        private void PopulateShadeNames()
        {
            string query = "SELECT Shades.ColorName FROM PrimaryColor INNER JOIN Shades ON Shades.PrimaryColorId = PrimaryColor.Id WHERE PrimaryColor.Id = @PrimaryColorId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryColorId", listShades.SelectedValue);
                DataTable shadesColorNameTable = new DataTable();
                adapter.Fill(shadesColorNameTable);

                listShades.DisplayMember = "PrimaryColorName";
                listShades.ValueMember = "Id";
                listShades.DataSource = shadesColorNameTable;
            }
        }
    }
}
