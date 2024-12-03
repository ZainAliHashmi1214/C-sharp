using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Work_Station : Form
    {
        public Work_Station()
        {
            InitializeComponent();
        }

        private void Work_Station_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }
    }
}
