using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "User Id=system;Password=db123;Data Source=localhost:1521/XE;";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT name FROM emp WHERE id = :id";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("id", empid.Text));

                    OracleDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        empname.Text = reader["name"].ToString();
                    }
                    else
                    {
                        empname.Text = "Not Found";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}

