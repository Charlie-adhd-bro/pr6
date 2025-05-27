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

            labelResult1.Text = "";
            labelResult2.Text = "";

            if (int.TryParse(textBox1.Text, out int num))
            {

                NumberHolder numberHolder = new NumberHolder(num);
                labelResult1.Text = "Конструктор с аргументом: " + numberHolder.GetNumber();

               

                numberHolder.SetNumber(num);
                labelResult2.Text += "Метод с аргументом: " + numberHolder.GetNumber();

                
            }

            else
            {

                NumberHolder numberHolder = new NumberHolder();
                labelResult1.Text += "\nКонструктор без аргумента: " + numberHolder.GetNumber();

                numberHolder.SetNumber();
                labelResult2.Text += "\nМетод без аргумента: " + numberHolder.GetNumber();

                MessageBox.Show(
                    "Был вызван конструктор по умолчанию",
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
            labelResult2.Text = "";
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

            public void SetNumber(int num)
            {
                number = CheckNumber(num);
            }
            public void SetNumber()
            {
                number = 0;
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