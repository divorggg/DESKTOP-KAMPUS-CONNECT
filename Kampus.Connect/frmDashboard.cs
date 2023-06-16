using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kampus.Connect
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var newform = new Pertamina();
            newform.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
