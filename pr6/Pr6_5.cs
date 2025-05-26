namespace pr6
{
    public partial class Pr6_5 : Form
    {
        public Pr6_5()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (int.TryParse(textBox1.Text, out int num))
            {
                NumberHolder numberHolder = new NumberHolder(num);
                labelResult1.Text = "Констурктор";
                success = true;
            }

           

            if (!success)
            {
                MessageBox.Show(
                    "Введите корректные значения",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            labelResult1.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        class NumberHolder
        {
            private int number;
           
            public NumberHolder()
            {
                number = 0;
            }
         
            public NumberHolder(int num)
            {
                number = CheckNumber(num);
            }

            public void SetNumber(int? num = null)
            {
                if (num.HasValue)
                {
                    number = CheckNumber(num.Value);
                }
                else
                {
                    number = 0;
                }
            }
          
            private int CheckNumber(int num)
            {
                return num > 100 ? 100 : num;
            }

            public int GetNumber()
            {
                return number;
            }
        }
    }
}