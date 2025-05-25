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
                NumbersHolder num = new NumbersHolder();
                labelResult1.Text = "Конструктор без аргументов:\n" + num.GetValues();

                NumbersHolder oneNum = new NumbersHolder(num1);
                labelResult2.Text = "Конструктор с одним аргументом:\n" + oneNum.GetValues();

                NumbersHolder twoNums = new NumbersHolder(num1, num2);
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

        class NumbersHolder
        {
            private int number1;
            private int number2;

            public NumbersHolder()
            {
                number1 = 0;
                number2 = 0;
            }

            public NumbersHolder(int num)
            {
                number1 = num;
                number2 = num;
            }

            public NumbersHolder(int num1, int num2)
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