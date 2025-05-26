namespace pr6
{
    public partial class Pr6_3 : Form
    {
        public Pr6_3()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) &&
                int.TryParse(textBox2.Text, out int num2))
            {
                Numbers num = new Numbers();
                labelResult1.Text = "Конструктор без аргументов:\n" + num.GetValues();

                Numbers oneNum = new Numbers(num1);
                labelResult2.Text = "Конструктор с одним аргументом:\n" + oneNum.GetValues();

                Numbers twoNums = new Numbers(num1, num2);
                labelResult3.Text = "Конструктор с двумя аргументами:\n" + twoNums.GetValues();
            }
            else
            {
                MessageBox.Show(
                    "Введите корректные целые числа",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            labelResult1.Text = "";
            labelResult2.Text = "";
            labelResult3.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        class Numbers
        {
            private int number1;
            private int number2;

            public Numbers()
            {
                number1 = 0;
                number2 = 0;
            }

            public Numbers(int num)
            {
                number1 = num;
                number2 = num;
            }

            public Numbers(int num1, int num2)
            {
                number1 = num1;
                number2 = num2;
            }

            public string GetValues()
            {
                return $"Первое число: {number1}\nВторое число: {number2}";
            }
        }
    }
}