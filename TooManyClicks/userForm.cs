using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooManyClicks
{
    public partial class userForm : Form
    {
        public userForm(string recordData)
        {
            InitializeComponent();
            recordLbl.Text = recordData;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameUserTbx.Text))
            {
                MessageBox.Show("Por favor de introducir un nombre válido.");
            }
            else
            {
                ConnectionDB myConnection = new ConnectionDB();

                MessageBox.Show(myConnection.insertarRecord(nameUserTbx.Text, Convert.ToInt32(recordLbl.Text)));

                Close();
            }
        }
    }
}
