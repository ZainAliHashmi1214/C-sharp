namespace Pos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit ();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Work_Station work_Station = new Work_Station();
            work_Station.Show();
        }
    }
}
