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
    public partial class recordsForm : Form
    {
        public recordsForm()
        {
            InitializeComponent();
        }

        private void recordsForm_Load(object sender, EventArgs e)
        {
            ConnectionDB myConnection = new ConnectionDB();
            myConnection.cargarRecords(recordsDgv);
        }
    }
}
