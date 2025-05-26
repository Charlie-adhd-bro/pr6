namespace pr6
{
    public partial class Pr6_4 : Form
    {
        public Pr6_4()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (int.TryParse(textBox2.Text, out int num) && textBox1.Text.Length == 1)
            {
                CharAndNumber charAndNumber = new CharAndNumber(textBox1.Text[0], num);
                labelResult1.Text = charAndNumber.output();
                success = true;
            }

            if (double.TryParse(textBox3.Text, out double doubleNum))
            {
                CharAndNumber charAndNumber = new CharAndNumber(doubleNum);
                labelResult2.Text = charAndNumber.output();
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
            textBox2.Clear();
            textBox3.Clear();

            labelResult1.Text = "";
            labelResult2.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        class CharAndNumber
        {
            private int number;
            private char character;

            public CharAndNumber (char symbol, int num)
            {
                number = num;
                character = symbol;
            }
            public CharAndNumber(double num)
            { 

                character = (char)(int)Math.Truncate(num);

                double fractionalPart = num - Math.Truncate(num);

                //MessageBox.Show("Math.("+ fractionalPart+") = " + fractionalPart * 100);

                int fractionalDigits = (int)Math.Truncate(fractionalPart * 100);
                number = fractionalDigits;
            }

            public string output()
            {
                return $"Символ: {character} \nЧисло: {number}";
            }
        }
    }
}