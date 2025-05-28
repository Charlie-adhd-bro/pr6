

namespace pr6
{
    public partial class Pr6_6 : Form
    {
        public Pr6_6()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {   
            MinMax minMax = new MinMax(60, 40);
            labelResult1.Text = "Один аргумент через конструктор (первый элемент): " + minMax.GetValues() + "(мин, макс)";

            minMax.MinMaxArguments(50,10);
            labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";

            minMax.MinMaxArguments(12,70);
            labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";


            minMax.MinMaxArguments(-1, 80);
            labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";


            minMax.MinMaxArguments(0);
            labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";


            minMax.MinMaxArguments(-10);
            labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";

            minMax.MinMaxArguments(90);
            labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";

            //try
            //{
            //    string[] inputs = textBox1.Text.Split([' ', ',']);
            //    int[] numbers = Array.ConvertAll(inputs, int.Parse);

            //    if (numbers.Length > 2 || numbers.Length == 0)
            //    {
            //        MessageBox.Show(
            //            "Введите один-два элемента",
            //            "Ошибка ввода",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Error
            //        );
            //        return;
            //    }

            //    labelResult1.Text = "";
            //    labelResult2.Text = "";

            //    MinMax minMax = new MinMax(numbers[0]);
            //    labelResult1.Text = "Один аргумент через конструктор (первый элемент): " + minMax.GetValues() + "(мин, макс)";

            //    minMax.MinMaxArguments(numbers[0]);
            //    labelResult2.Text = "Один аргумент через метод (первый элемент): " + minMax.GetValues() + "(мин, макс)";

            //    if (numbers.Length == 2)
            //    {
            //        minMax = new MinMax(numbers[0], numbers[1]);
            //        labelResult1.Text += "\nДва аргумента через конструктор: " + minMax.GetValues() + "(мин, макс)";

            //        minMax.MinMaxArguments(numbers[0], numbers[1]);
            //        labelResult2.Text += "\nДва аргумента через метод: " + minMax.GetValues() + "(мин, макс)";

            //        minMax = new MinMax(numbers[1]);
            //        labelResult1.Text += "\nОдин аргумент через конструктор (второй элемент): " + minMax.GetValues() + "(мин, макс)";

            //        minMax.MinMaxArguments(numbers[1]);
            //        labelResult2.Text += "\nОдин аргумент через метод (второй элемент): " + minMax.GetValues() + "(мин, макс)";

            //    }
            //}

            //catch (FormatException)
            //{
            //    MessageBox.Show(
            //        "Введите только целые числа, разделенные пробелами или запятыми",
            //        "Ошибка ввода",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //}

            //catch (OverflowException)
            //{
            //    MessageBox.Show(
            //        "Введено слишком большое или слишком маленькое число",
            //        "Ошибка ввода",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(
            //        $"Произошла ошибка: {ex.Message}",
            //        "Ошибка",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //}
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

        class MinMax
        {
            private int min = int.MaxValue;
            private int max = int.MinValue;

            public MinMax(int num)
            {
                max = max < num ? num : max;
                min = min > num ? num : min;
            }


            public MinMax(int num1, int num2)
            {
                min = Math.Min(num1, num2);
                max = Math.Max(num1, num2);

            }



            public void MinMaxArguments(int num)
            {
                max = max < num ? num : max;
                min = min > num ? num : min;
            }


            public void MinMaxArguments(int num1, int num2)
            {
                if (num1 > max)
                {
                    max = num1;
                }
                if (num2 > max) 
                {
                    max = num2; 
                }

                if (num1 < min)
                {
                    min = num1;
                }

                if (num2 < min) 
                { 
                    min = num2; 
                }
            }
            public (int, int) GetValues()
            {
                return (min, max);
            }
        }
    }
}