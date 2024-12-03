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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchasingSummery_Click(object sender, EventArgs e)
        {
            Purchasing_Summery purchasing_Summery = new Purchasing_Summery();
            purchasing_Summery.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
