﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace TooManyClicks
{
    internal class ConnectionDB
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;

        string chain = "Data Source=EGBAZUA-PC;Initial Catalog=TooManyClicks; Integrated Security=True";
        public SqlConnection myConnection = new SqlConnection();

        public ConnectionDB()
        {
            myConnection.ConnectionString = chain;
        }

        public void open()
        {
            try
            {
                myConnection.Open();
                Console.WriteLine("Connection open");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection error" + ex.Message);
            }
        }

        public void close()
        {
            myConnection.Close();
        }

        // Función para cargar records.
        public void cargarRecords(DataGridView dgv)
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("select * from records", myConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }
    }
}
