namespace pr6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr6_1 mainForm = new();
            mainForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr6_2 mainForm = new();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr6_3 mainForm = new();
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr6_4 mainForm = new();
            mainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Pr6_5 mainForm = new();
            //mainForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
